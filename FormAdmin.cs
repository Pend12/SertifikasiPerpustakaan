using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SertifikasiPerpustakaan
{
    public partial class FormAdmin : Form
    {
        private string connectionString = "server=127.0.0.1;port=3306;database=db_sertifperpus;uid=root;pwd=;";
        public FormAdmin()
        {
            InitializeComponent();
            LoadBooks();
        }

        private void LoadBooks(string searchQuery = "")
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Books";
                if (!string.IsNullOrEmpty(searchQuery))
                {
                    query += " WHERE title LIKE @search";
                }

                using (var command = new MySqlCommand(query, connection))
                {
                    if (!string.IsNullOrEmpty(searchQuery))
                    {
                        command.Parameters.AddWithValue("@search", "%" + searchQuery + "%");
                    }

                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridViewKoleksi.DataSource = dataTable;
                    }
                }
            }
        }


        private void iconButtonMuser_Click(object sender, EventArgs e)
        {
            // Navigasi ke FormManajemenUser
            this.Hide();
            FormManajemenuser userForm = new FormManajemenuser();
            userForm.Show();
        }

        private void iconButtonPeminjaman_Click(object sender, EventArgs e)
        {
            // Navigasi ke FormPeminjaman
            this.Hide();
            FormPeminjaman peminjamanForm = new FormPeminjaman();
            peminjamanForm.Show();
        }

        private void iconButtonLogout_Click(object sender, EventArgs e)
        {
            // Kembali ke FormLogin
            this.Hide();
            FormLogin loginForm = new FormLogin();
            loginForm.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = textBoxSearch.Text; 
            LoadBooks(searchQuery);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text; 
            string author = textBoxAuthor.Text; 
            int publishedYear;

            if (int.TryParse(textBoxPublish.Text, out publishedYear))
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Books (title, author, published_year) VALUES (@title, @author, @publishedYear)";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@title", title);
                        command.Parameters.AddWithValue("@author", author);
                        command.Parameters.AddWithValue("@publishedYear", publishedYear);
                        command.ExecuteNonQuery();
                    }
                }

                textBoxTitle.Clear();
                textBoxAuthor.Clear();
                textBoxPublish.Clear();

                LoadBooks();
            }
            else
            {
                MessageBox.Show("Please enter a valid year.");
            }
        }
    }
}
