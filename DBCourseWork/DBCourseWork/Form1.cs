using System.Data.OleDb;
using System.Security.Cryptography;

namespace DBCourseWork
{
    public partial class Form1 : Form
    {
        private const int Iterations = 600_000;
        private bool registration;

        public Form1()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            registerButton.Click += registerButton_Click;
        }

        private void registerButton_Click(object? sender, EventArgs e)
        {
            SetRegistrationMode(!registration);
        }

        private void SetRegistrationMode(bool enabled)
        {
            registration = enabled;
            fullNameLabel.Visible = enabled;
            fullNameTextBox.Visible = enabled;
            button1.Text = enabled ? "Зарегистрироваться" : "Войти";
            registerButton.Text = enabled ? "Назад ко входу" : "Создать учётную запись";
            Text = enabled ? "Регистрация рабочего" : "Вход на склад";
            textBox1.Clear();
            if (enabled)
                fullNameTextBox.Focus();
            else
                textBox2.Focus();
        }

        private void button1_Click(object? sender, EventArgs e)
        {
            string login = textBox2.Text.Trim();
            string password = textBox1.Text;
            WarehouseDb.Run(this, () =>
            {
                if (registration)
                {
                    RegisterWorker(fullNameTextBox.Text.Trim(), login, password);
                    SetRegistrationMode(false);
                    MessageBox.Show(this, "Учётная запись создана. Теперь войди с этим логином.", "Регистрация");
                    return;
                }

                var user = FindUser(login, password);
                if (user == null)
                    throw new InvalidOperationException("Неверный логин или пароль.");

                using Form dashboard = user.Value.Role switch
                {
                    "worker" => new ClientForm(user.Value.Id, user.Value.FullName),
                    "manager" => new AdminForm(user.Value.FullName),
                    _ => throw new InvalidOperationException("У учётной записи неизвестная роль.")
                };

                textBox1.Clear();
                Hide();
                try
                {
                    dashboard.ShowDialog();
                }
                finally
                {
                    Show();
                    textBox2.Focus();
                }
            });
        }

        internal static void RegisterWorker(string fullName, string login, string password)
        {
            if (fullName.Length is < 1 or > 120 || login.Length is < 1 or > 64)
                throw new InvalidOperationException("Укажи ФИО и логин.");
            if (password.Length is < 8 or > 128)
                throw new InvalidOperationException("В пароле должно быть от 8 до 128 символов.");

            using OleDbConnection connection = WarehouseDb.Open();
            string sQ = "SELECT Count(*) FROM [users] WHERE [login] = ?";
            using (OleDbCommand checkCmd = new OleDbCommand(sQ, connection))
            {
                checkCmd.Parameters.AddWithValue("?", login);
                if (Convert.ToInt32(checkCmd.ExecuteScalar()) > 0)
                    throw new InvalidOperationException("Этот логин уже занят.");
            }

            sQ = "INSERT INTO [users] ([full_name], [login], [password_hash], [role]) VALUES (?, ?, ?, 'worker')";
            using OleDbCommand cmd = new OleDbCommand(sQ, connection);
            cmd.Parameters.AddWithValue("?", fullName);
            cmd.Parameters.AddWithValue("?", login);
            cmd.Parameters.AddWithValue("?", HashPassword(password));
            cmd.ExecuteNonQuery();
        }

        internal static (int Id, string FullName, string Role)? FindUser(string login, string password)
        {
            if (string.IsNullOrWhiteSpace(login) || password.Length == 0)
                return null;

            string sQ = "SELECT [id], [full_name], [password_hash], [role] FROM [users] WHERE [login] = ?";
            using OleDbConnection connection = WarehouseDb.Open();
            using OleDbCommand cmd = new OleDbCommand(sQ, connection);
            cmd.Parameters.AddWithValue("?", login);

            using OleDbDataReader reader = cmd.ExecuteReader();
            if (!reader.Read() || !VerifyPassword(password, reader.GetString(2)))
                return null;

            return (reader.GetInt32(0), reader.GetString(1), reader.GetString(3));
        }

        private static string HashPassword(string password)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(16);
            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(password, salt, Iterations, HashAlgorithmName.SHA256, 32);
            return $"pbkdf2-sha256${Iterations}${Convert.ToBase64String(salt)}${Convert.ToBase64String(hash)}";
        }

        private static bool VerifyPassword(string password, string storedHash)
        {
            string[] parts = storedHash.Split('$');
            if (parts.Length != 4 || parts[0] != "pbkdf2-sha256" || parts[1] != Iterations.ToString())
                return false;

            try
            {
                byte[] salt = Convert.FromBase64String(parts[2]);
                byte[] expected = Convert.FromBase64String(parts[3]);
                if (salt.Length != 16 || expected.Length != 32)
                    return false;

                byte[] actual = Rfc2898DeriveBytes.Pbkdf2(password, salt, Iterations, HashAlgorithmName.SHA256, expected.Length);
                return CryptographicOperations.FixedTimeEquals(actual, expected);
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
