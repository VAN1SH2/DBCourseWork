using System.Data;
using System.Data.OleDb;

namespace DBCourseWork
{
    internal static class OrderQueries
    {
        internal static DataTable ShowOrders(int? workerId = null, string? status = null)
        {
            string sQ = "SELECT o.[id], u.[full_name], o.[order_date], o.[status], " +
                "CCur(IIf(Count(i.[id]) = 0, 0, Sum(i.[total]))) AS [order_total] " +
                "FROM ([orders] AS o INNER JOIN [users] AS u ON o.[user_id] = u.[id]) " +
                "LEFT JOIN [order_items] AS i ON o.[id] = i.[order_id] WHERE 1 = 1";

            using OleDbConnection connection = WarehouseDb.Open();
            using OleDbCommand cmd = new OleDbCommand(sQ, connection);
            if (workerId.HasValue)
            {
                cmd.CommandText += " AND o.[user_id] = ?";
                cmd.Parameters.AddWithValue("?", workerId.Value);
            }
            if (status != null)
            {
                cmd.CommandText += " AND o.[status] = ?";
                cmd.Parameters.AddWithValue("?", status);
            }

            cmd.CommandText += " GROUP BY o.[id], u.[full_name], o.[order_date], o.[status]" +
                " ORDER BY o.[order_date] DESC, o.[id] DESC";
            DataTable table = WarehouseDb.ReadTable(cmd);
            table.Columns.Add("status_text", typeof(string));
            foreach (DataRow row in table.Rows)
            {
                row["status_text"] = (string)row["status"] switch
                {
                    "created" => "Создана",
                    "approved" => "Одобрена",
                    "rejected" => "Отклонена",
                    _ => row["status"]
                };
            }

            return table;
        }

        internal static DataTable ShowItems(int orderId, int? workerId = null)
        {
            string sQ = "SELECT m.[name] AS [material_name], m.[unit], i.[quantity], i.[price], i.[total] " +
                "FROM ([order_items] AS i INNER JOIN [materials] AS m ON i.[material_id] = m.[id]) " +
                "INNER JOIN [orders] AS o ON i.[order_id] = o.[id] WHERE i.[order_id] = ?";

            using OleDbConnection connection = WarehouseDb.Open();
            using OleDbCommand cmd = new OleDbCommand(sQ, connection);
            cmd.Parameters.AddWithValue("?", orderId);
            if (workerId.HasValue)
            {
                cmd.CommandText += " AND o.[user_id] = ?";
                cmd.Parameters.AddWithValue("?", workerId.Value);
            }
            cmd.CommandText += " ORDER BY i.[id]";
            return WarehouseDb.ReadTable(cmd);
        }

        internal static int CreateOrder(int workerId, DataTable draft)
        {
            if (draft.Rows.Count == 0)
                throw new InvalidOperationException("Добавь хотя бы один материал в заявку.");

            using OleDbConnection connection = WarehouseDb.Open();
            using OleDbTransaction transaction = connection.BeginTransaction();
            string sQ = "INSERT INTO [orders] ([user_id], [order_date], [status]) VALUES (?, Now(), 'created')";
            using (OleDbCommand cmd = new OleDbCommand(sQ, connection, transaction))
            {
                cmd.Parameters.AddWithValue("?", workerId);
                cmd.ExecuteNonQuery();
            }

            using OleDbCommand identity = new OleDbCommand("SELECT @@IDENTITY", connection, transaction);
            int orderId = Convert.ToInt32(identity.ExecuteScalar());
            if (orderId <= 0)
                throw new InvalidOperationException("Не удалось получить номер заявки.");

            foreach (DataRow row in draft.Rows)
            {
                int materialId = (int)row["material_id"];
                double quantity = (double)(decimal)row["quantity"];
                string materialName = (string)row["material_name"];

                sQ = "SELECT [price] FROM [materials] WHERE [id] = ? AND [quantity] >= ?";
                using OleDbCommand priceCmd = new OleDbCommand(sQ, connection, transaction);
                priceCmd.Parameters.AddWithValue("?", materialId);
                priceCmd.Parameters.AddWithValue("?", quantity);
                if (priceCmd.ExecuteScalar() is not decimal price)
                    throw new InvalidOperationException("Недостаточный остаток: " + materialName);
                if (price != (decimal)row["price"])
                    throw new InvalidOperationException("Цена изменилась: " + materialName + ". Добавь позицию заново.");

                sQ = "INSERT INTO [order_items] ([order_id], [material_id], [quantity], [price]) VALUES (?, ?, ?, ?)";
                using OleDbCommand itemCmd = new OleDbCommand(sQ, connection, transaction);
                itemCmd.Parameters.AddWithValue("?", orderId);
                itemCmd.Parameters.AddWithValue("?", materialId);
                itemCmd.Parameters.AddWithValue("?", quantity);
                itemCmd.Parameters.Add("?", OleDbType.Currency).Value = price;
                itemCmd.ExecuteNonQuery();
            }

            transaction.Commit();
            return orderId;
        }

        internal static void DecideOrder(int orderId, bool approve)
        {
            using OleDbConnection connection = WarehouseDb.Open();
            using OleDbTransaction transaction = connection.BeginTransaction();
            string sQ = "UPDATE [orders] SET [status] = ? WHERE [id] = ? AND [status] = 'created'";
            using (OleDbCommand cmd = new OleDbCommand(sQ, connection, transaction))
            {
                cmd.Parameters.AddWithValue("?", approve ? "approved" : "rejected");
                cmd.Parameters.AddWithValue("?", orderId);
                if (cmd.ExecuteNonQuery() != 1)
                    throw new InvalidOperationException("Заявка уже обработана. Обнови список заявок.");
            }

            if (approve)
            {
                sQ = "SELECT i.[material_id], i.[quantity], m.[name] FROM [order_items] AS i " +
                    "INNER JOIN [materials] AS m ON i.[material_id] = m.[id] WHERE i.[order_id] = ?";
                using OleDbCommand itemsCmd = new OleDbCommand(sQ, connection, transaction);
                itemsCmd.Parameters.AddWithValue("?", orderId);
                DataTable items = WarehouseDb.ReadTable(itemsCmd);
                if (items.Rows.Count == 0)
                    throw new InvalidOperationException("В заявке нет материалов.");

                foreach (DataRow row in items.Rows)
                {
                    double quantity = (double)row["quantity"];
                    sQ = "UPDATE [materials] SET [quantity] = Round([quantity] - ?, 3) WHERE [id] = ? AND [quantity] >= ?";
                    using OleDbCommand stockCmd = new OleDbCommand(sQ, connection, transaction);
                    stockCmd.Parameters.AddWithValue("?", quantity);
                    stockCmd.Parameters.AddWithValue("?", (int)row["material_id"]);
                    stockCmd.Parameters.AddWithValue("?", quantity);
                    if (stockCmd.ExecuteNonQuery() != 1)
                        throw new InvalidOperationException("Недостаточный остаток: " + row["name"]);
                }
            }

            transaction.Commit();
        }
    }
}
