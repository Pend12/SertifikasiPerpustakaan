using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SertifikasiPerpustakaan
{
    public partial class FormManajemenuser : Form
    {
        private string connectionString = "server=127.0.0.1;port=3306;database=db_sertifperpus;uid=root;pwd=;";

        public FormManajemenuser()
        {
            InitializeComponent();
            LoadUsers(); // Memuat daftar pengguna saat form dibuka
        }

        private void iconButtonkoleksi_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmin adminForm = new FormAdmin();
            adminForm.Show();
        }

        private void iconButtonPeminjaman_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPeminjaman peminjamanForm = new FormPeminjaman();
            peminjamanForm.Show();
        }

        private void iconButtonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin loginForm = new FormLogin();
            loginForm.Show();
        }

        private void buttonAdduser_Click(object sender, EventArgs e)
        {
            string username = textBoxUser.Text;
            string password = textBoxPass.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and password cannot be empty.");
                return;
            }

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Users (username, password) VALUES (@username, @password)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("User added successfully.");
            LoadUsers();
            textBoxUser.Clear();
            textBoxPass.Clear();
        }

        private void buttonSearchhistoryuser_Click(object sender, EventArgs e)
        {
            if (comboBoxPeminjaman.SelectedValue == null)
            {
                MessageBox.Show("Please select a user from the list.");
                return;
            }

            int selectedUserId = (int)comboBoxPeminjaman.SelectedValue;

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT b.title AS 'Judul Buku', br.borrowed_at AS 'Tanggal Pinjam', br.due_date AS 'Tanggal Jatuh Tempo', br.returned_at AS 'Tanggal Pengembalian' " +
                               "FROM Borrowings br " +
                               "JOIN Books b ON br.book_id = b.book_id " +
                               "WHERE br.user_id = @user_id";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@user_id", selectedUserId);
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridViewHistory.DataSource = dataTable;
                    }
                }
            }
        }

        private void LoadUsers()
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                // Modifikasi query untuk mengecualikan pengguna dengan role 'admin'
                string query = "SELECT user_id, username FROM Users WHERE role != 'admin'";

                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        comboBoxPeminjaman.DataSource = null;
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        comboBoxPeminjaman.DataSource = dataTable;
                        comboBoxPeminjaman.DisplayMember = "username";
                        comboBoxPeminjaman.ValueMember = "user_id";
                    }
                }
            }
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxPeminjaman.SelectedValue == null)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            int selectedUserId = (int)comboBoxPeminjaman.SelectedValue;

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Hapus semua riwayat peminjaman untuk pengguna yang dipilih
                string deleteBorrowingsQuery = "DELETE FROM Borrowings WHERE user_id = @user_id";
                using (var command = new MySqlCommand(deleteBorrowingsQuery, connection))
                {
                    command.Parameters.AddWithValue("@user_id", selectedUserId);
                    command.ExecuteNonQuery();
                }

                // Hapus pengguna dari tabel Users
                string deleteUserQuery = "DELETE FROM Users WHERE user_id = @user_id";
                using (var command = new MySqlCommand(deleteUserQuery, connection))
                {
                    command.Parameters.AddWithValue("@user_id", selectedUserId);
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("User and their borrowing history deleted successfully.");
            }

            LoadUsers(); 
        }

    }
}
