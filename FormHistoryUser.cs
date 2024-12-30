using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SertifikasiPerpustakaan
{
    public partial class FormHistoryUser : Form
    {
        private string connectionString = "server=127.0.0.1;port=3306;database=db_sertifperpus;uid=root;pwd=;";

        public FormHistoryUser()
        {
            InitializeComponent();
            LoadUserHistory(); // Memuat riwayat peminjaman saat form dibuka
        }

        private void LoadUserHistory()
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT b.title AS 'Judul Buku', br.borrowed_at AS 'Tanggal Pinjam', br.due_date AS 'Tanggal Jatuh Tempo', br.returned_at AS 'Tanggal Pengembalian' " +
                               "FROM Borrowings br " +
                               "JOIN Books b ON br.book_id = b.book_id " +
                               "WHERE br.user_id = @user_id";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@user_id", CurrentUser.UserId); // Menggunakan user_id dari pengguna yang sedang login
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridViewHst.DataSource = dataTable; // Menampilkan riwayat di DataGridView
                    }
                }
            }
        }

        private void iconButtonkoleksi_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUser formUser = new FormUser();
            formUser.Show();
        }

        private void iconButtonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin loginForm = new FormLogin();
            loginForm.Show();
        }
    }
}
