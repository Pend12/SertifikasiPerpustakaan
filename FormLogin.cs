using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SertifikasiPerpustakaan
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void iconButtonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            string connectionString = "server=127.0.0.1;port=3306;database=db_sertifperpus;uid=root;pwd=;";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT user_id, role FROM Users WHERE username = @username AND password = @password";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Menyimpan informasi pengguna yang sedang login
                            CurrentUser.UserId = reader.GetInt32("user_id");
                            CurrentUser.Username = username;
                            CurrentUser.Role = reader.GetString("role");

                            // Navigasi ke form yang sesuai
                            if (CurrentUser.Role == "admin")
                            {
                                FormAdmin adminForm = new FormAdmin();
                                adminForm.Show();
                            }
                            else if (CurrentUser.Role == "user")
                            {
                                FormUser userForm = new FormUser();
                                userForm.Show();
                            }

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Username atau password salah.");
                        }
                    }
                }
            }
        }

        private void iconButtonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
