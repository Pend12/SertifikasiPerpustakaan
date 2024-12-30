using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SertifikasiPerpustakaan
{
    public partial class FormPeminjaman : Form
    {
        private string connectionString = "server=127.0.0.1;port=3306;database=db_sertifperpus;uid=root;pwd=;";

        public FormPeminjaman()
        {
            InitializeComponent();
            LoadUsers();
            LoadBooks();
            LoadBorrowedBooks();
        }

        private void LoadUsers()
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT user_id, username FROM Users WHERE role != 'admin'"; 

                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBoxUser.Items.Add(reader["username"].ToString());
                        }
                    }
                }
            }
        }

        private void LoadBooks()
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT book_id, title FROM Books WHERE status = 'available'";

                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        listBoxKoleksi.Items.Clear();
                        while (reader.Read())
                        {
                            listBoxKoleksi.Items.Add(new { Id = reader["book_id"], Title = reader["title"] });
                        }
                    }
                }
            }
        }


        private int GetSelectedUserId()
        {
            if (comboBoxUser.SelectedItem == null)
                return -1;

            string selectedUser = comboBoxUser.SelectedItem.ToString();
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT user_id FROM Users WHERE username = @username";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", selectedUser);
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        private int GetSelectedUserIdFromGrid()
        {
            if (dataGridViewBorrowed.SelectedRows.Count == 0)
                return -1;

            string selectedUser = dataGridViewBorrowed.SelectedRows[0].Cells["Peminjam"].Value.ToString();
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT user_id FROM Users WHERE username = @username";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", selectedUser);
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }



        private void buttonPinjam_Click(object sender, EventArgs e)
        {
            int selectedUserId = GetSelectedUserId(); // Metode untuk mendapatkan user_id dari comboBoxUser
            var selectedBooks = listBoxKoleksi.SelectedItems;

            if (selectedUserId == -1 || selectedBooks.Count == 0)
            {
                MessageBox.Show("Please select a user and at least one book.");
                return;
            }

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                foreach (var book in selectedBooks)
                {
                    int bookId = (book as dynamic).Id; // Ambil book_id dari objek yang dipilih

                    // Periksa apakah buku sudah dipinjam oleh pengguna
                    string checkQuery = "SELECT COUNT(*) FROM Borrowings WHERE user_id = @user_id AND book_id = @book_id AND returned_at IS NULL";
                    using (var checkCommand = new MySqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@user_id", selectedUserId);
                        checkCommand.Parameters.AddWithValue("@book_id", bookId);
                        int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Buku Sudah Dipinjam");
                            continue;
                        }
                    }

                    // Update status buku menjadi borrowed
                    string updateQuery = "UPDATE Books SET status = 'borrowed' WHERE book_id = @book_id";
                    using (var command = new MySqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@book_id", bookId);
                        command.ExecuteNonQuery();
                    }

                    // Insert peminjaman ke tabel Borrowings
                    string insertQuery = "INSERT INTO Borrowings (user_id, book_id, borrowed_at, due_date, returned_at) VALUES (@user_id, @book_id, @borrowed_at, @due_date, NULL)";
                    using (var command = new MySqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@user_id", selectedUserId);
                        command.Parameters.AddWithValue("@book_id", bookId);
                        command.Parameters.AddWithValue("@borrowed_at", DateTime.Now);
                        command.Parameters.AddWithValue("@due_date", DateTime.Now.AddDays(7)); 
                        command.ExecuteNonQuery();
                    }
                }
            }

            // Clear the list and reload books
            listBoxKoleksi.Items.Clear();
            LoadBooks();

            // Load borrowed books
            LoadBorrowedBooks();
        }


        private void LoadBorrowedBooks()
{
    using (var connection = new MySqlConnection(connectionString))
    {
        connection.Open();
        string query = "SELECT b.book_id, b.title AS 'Judul Buku', u.username AS 'Peminjam', br.borrowed_at AS 'Tanggal Pinjam', br.due_date AS 'Tanggal Jatuh Tempo', br.returned_at AS 'Tanggal Pengembalian' " +
                       "FROM Borrowings br " +
                       "JOIN Users u ON br.user_id = u.user_id " +
                       "JOIN Books b ON br.book_id = b.book_id " +
                       "WHERE br.returned_at IS NULL"; // Menampilkan semua buku yang sedang dipinjam

        using (var command = new MySqlCommand(query, connection))
        {
            using (var adapter = new MySqlDataAdapter(command))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewBorrowed.DataSource = dataTable;    
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

        private void iconButtonLogout_Click(object sender, EventArgs e)
        {
            // Kembali ke FormLogin
            this.Hide();
            FormLogin loginForm = new FormLogin();
            loginForm.Show();
        }

        private void iconButtonkoleksi_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmin adminForm = new FormAdmin();
            adminForm.Show();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            if (dataGridViewBorrowed.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to return.");
                return;
            }

            int selectedBookId = Convert.ToInt32(dataGridViewBorrowed.SelectedRows[0].Cells["book_id"].Value);
            int selectedUserId = GetSelectedUserIdFromGrid(); // Metode untuk mendapatkan user_id dari DataGridView

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Update status buku menjadi available
                string updateBookQuery = "UPDATE Books SET status = 'available' WHERE book_id = @book_id";
                using (var command = new MySqlCommand(updateBookQuery, connection))
                {
                    command.Parameters.AddWithValue("@book_id", selectedBookId);
                    command.ExecuteNonQuery();
                }

                // Update tanggal pengembalian di tabel Borrowings
                string updateReturnQuery = "UPDATE Borrowings SET returned_at = @returned_at WHERE book_id = @book_id AND user_id = @user_id AND returned_at IS NULL";
                using (var command = new MySqlCommand(updateReturnQuery, connection))
                {
                    command.Parameters.AddWithValue("@returned_at", DateTime.Now); // Menyimpan tanggal saat ini
                    command.Parameters.AddWithValue("@book_id", selectedBookId);
                    command.Parameters.AddWithValue("@user_id", selectedUserId);
                    command.ExecuteNonQuery();
                }
            }

            // Reload borrowed books
            LoadBorrowedBooks();
        }




    }
}
