using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SertifikasiPerpustakaan
{
    public partial class FormUser : Form
    {
        private string connectionString = "server=127.0.0.1;port=3306;database=db_sertifperpus;uid=root;pwd=;";

        public FormUser()
        {
            InitializeComponent();
            this.Load += new EventHandler(FormUser_Load); // Menambahkan event handler
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            radioButtonAll.Checked = true; // Mengatur radioButtonAll terpilih secara otomatis
            LoadKoleksi(); // Memuat koleksi saat form dibuka
        }

        private void LoadKoleksi()
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query;

                if (radioButtonAll.Checked)
                {
                    query = "SELECT * FROM Books"; // Menampilkan semua buku
                }
                else
                {
                    query = "SELECT * FROM Books WHERE status = 'available'"; // Menampilkan buku yang tersedia
                }

                using (var command = new MySqlCommand(query, connection))
                {
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridViewKoleksiUser.DataSource = dataTable; // Menampilkan data di DataGridView
                    }
                }
            }
        }


        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            LoadKoleksi(); // Memuat koleksi saat radioButtonAll dipilih
        }

        private void radioButtonNoPinjam_CheckedChanged(object sender, EventArgs e)
        {
            LoadKoleksi(); // Memuat koleksi saat radioButtonNoPinjam dipilih
        }

        private void iconButtonMuser_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHistoryUser formHistoryUser = new FormHistoryUser();
            formHistoryUser.Show();
        }

        private void iconButtonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin loginForm = new FormLogin();
            loginForm.Show();
        }
    }
}

