using System.Data;
using System.Data.OleDb;

namespace DBCourseWork
{
    internal static class WarehouseDb
    {
        internal static string DatabasePath
        {
            get
            {
                string? configuredPath = Environment.GetEnvironmentVariable("DBCOURSEWORK_DB_PATH");
                if (!string.IsNullOrWhiteSpace(configuredPath))
                    return Path.GetFullPath(configuredPath);

                string localPath = Path.Combine(AppContext.BaseDirectory, "Coursework.accdb");
                if (File.Exists(localPath))
                    return localPath;

                return Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "Coursework.accdb"));
            }
        }

        internal static OleDbConnection Open(string? path = null)
        {
            path ??= DatabasePath;
            if (!File.Exists(path))
                throw new InvalidOperationException("Файл базы данных не найден: " + path);

            var settings = new OleDbConnectionStringBuilder
            {
                Provider = "Microsoft.ACE.OLEDB.12.0",
                DataSource = path
            };
            var connection = new OleDbConnection(settings.ConnectionString);
            try
            {
                connection.Open();
                return connection;
            }
            catch
            {
                connection.Dispose();
                throw;
            }
        }

        internal static DataTable ReadTable(OleDbCommand cmd)
        {
            using (OleDbDataAdapter ad = new OleDbDataAdapter(cmd))
            {
                DataTable table = new DataTable();
                ad.Fill(table);
                return table;
            }
        }

        internal static DataTable ReadTable(string sQ)
        {
            using OleDbConnection connection = Open();
            using OleDbCommand cmd = new OleDbCommand(sQ, connection);
            return ReadTable(cmd);
        }

        internal static void BindColumns(DataGridView grid, params string[] fields)
        {
            grid.AutoGenerateColumns = false;
            for (int index = 0; index < fields.Length; index++)
                grid.Columns[index].DataPropertyName = fields[index];
        }

        internal static DataRow? SelectedRow(DataGridView grid)
        {
            if (grid.SelectedRows.Count == 0)
                return null;

            return (grid.SelectedRows[0].DataBoundItem as DataRowView)?.Row;
        }

        internal static void Run(Form form, Action action)
        {
            try
            {
                action();
            }
            catch (Exception error) when (error is OleDbException or InvalidOperationException)
            {
                MessageBox.Show(form, error.Message, "Склад", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
