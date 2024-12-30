namespace SertifikasiPerpustakaan
{
    partial class FormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButtonLogout = new FontAwesome.Sharp.IconButton();
            this.iconButtonPeminjaman = new FontAwesome.Sharp.IconButton();
            this.iconButtonMuser = new FontAwesome.Sharp.IconButton();
            this.iconButtonkoleksi = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewKoleksi = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxPublish = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKoleksi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.iconButtonLogout);
            this.panel1.Controls.Add(this.iconButtonPeminjaman);
            this.panel1.Controls.Add(this.iconButtonMuser);
            this.panel1.Controls.Add(this.iconButtonkoleksi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // iconButtonLogout
            // 
            this.iconButtonLogout.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.iconButtonLogout.IconColor = System.Drawing.Color.IndianRed;
            this.iconButtonLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonLogout.IconSize = 30;
            this.iconButtonLogout.Location = new System.Drawing.Point(159, 409);
            this.iconButtonLogout.Name = "iconButtonLogout";
            this.iconButtonLogout.Size = new System.Drawing.Size(33, 35);
            this.iconButtonLogout.TabIndex = 6;
            this.iconButtonLogout.UseVisualStyleBackColor = true;
            this.iconButtonLogout.Click += new System.EventHandler(this.iconButtonLogout_Click);
            // 
            // iconButtonPeminjaman
            // 
            this.iconButtonPeminjaman.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButtonPeminjaman.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.iconButtonPeminjaman.IconColor = System.Drawing.Color.Black;
            this.iconButtonPeminjaman.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonPeminjaman.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.iconButtonPeminjaman.Location = new System.Drawing.Point(3, 256);
            this.iconButtonPeminjaman.Name = "iconButtonPeminjaman";
            this.iconButtonPeminjaman.Size = new System.Drawing.Size(194, 52);
            this.iconButtonPeminjaman.TabIndex = 5;
            this.iconButtonPeminjaman.Text = "Peminjaman";
            this.iconButtonPeminjaman.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonPeminjaman.UseVisualStyleBackColor = true;
            this.iconButtonPeminjaman.Click += new System.EventHandler(this.iconButtonPeminjaman_Click);
            // 
            // iconButtonMuser
            // 
            this.iconButtonMuser.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButtonMuser.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.iconButtonMuser.IconColor = System.Drawing.Color.Black;
            this.iconButtonMuser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMuser.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.iconButtonMuser.Location = new System.Drawing.Point(3, 196);
            this.iconButtonMuser.Name = "iconButtonMuser";
            this.iconButtonMuser.Size = new System.Drawing.Size(194, 54);
            this.iconButtonMuser.TabIndex = 4;
            this.iconButtonMuser.Text = "Manajemen User";
            this.iconButtonMuser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMuser.UseVisualStyleBackColor = true;
            this.iconButtonMuser.Click += new System.EventHandler(this.iconButtonMuser_Click);
            // 
            // iconButtonkoleksi
            // 
            this.iconButtonkoleksi.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButtonkoleksi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButtonkoleksi.IconChar = FontAwesome.Sharp.IconChar.Barcode;
            this.iconButtonkoleksi.IconColor = System.Drawing.Color.Black;
            this.iconButtonkoleksi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonkoleksi.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.iconButtonkoleksi.Location = new System.Drawing.Point(3, 136);
            this.iconButtonkoleksi.Name = "iconButtonkoleksi";
            this.iconButtonkoleksi.Size = new System.Drawing.Size(194, 54);
            this.iconButtonkoleksi.TabIndex = 3;
            this.iconButtonkoleksi.Text = "Koleksi";
            this.iconButtonkoleksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonkoleksi.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(60, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Perpustakaan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aplikasi";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 49;
            this.iconPictureBox1.Location = new System.Drawing.Point(3, 3);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(51, 49);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(198, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 42);
            this.label3.TabIndex = 1;
            this.label3.Text = "Koleksi";
            // 
            // dataGridViewKoleksi
            // 
            this.dataGridViewKoleksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKoleksi.Location = new System.Drawing.Point(206, 72);
            this.dataGridViewKoleksi.Name = "dataGridViewKoleksi";
            this.dataGridViewKoleksi.RowTemplate.Height = 25;
            this.dataGridViewKoleksi.Size = new System.Drawing.Size(591, 325);
            this.dataGridViewKoleksi.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(705, 403);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(92, 47);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Tambah Koleksi";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(206, 45);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(486, 23);
            this.textBoxSearch.TabIndex = 4;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(698, 45);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(90, 23);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(263, 403);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(177, 23);
            this.textBoxTitle.TabIndex = 6;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(263, 426);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(177, 23);
            this.textBoxAuthor.TabIndex = 7;
            // 
            // textBoxPublish
            // 
            this.textBoxPublish.Location = new System.Drawing.Point(529, 403);
            this.textBoxPublish.Name = "textBoxPublish";
            this.textBoxPublish.Size = new System.Drawing.Size(145, 23);
            this.textBoxPublish.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Title : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Author :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(446, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Publish Year :";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPublish);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewKoleksi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKoleksi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton iconButtonkoleksi;
        private Label label3;
        private DataGridView dataGridViewKoleksi;
        private Button buttonAdd;
        private FontAwesome.Sharp.IconButton iconButtonPeminjaman;
        private FontAwesome.Sharp.IconButton iconButtonMuser;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private FontAwesome.Sharp.IconButton iconButtonLogout;
        private TextBox textBoxTitle;
        private TextBox textBoxAuthor;
        private TextBox textBoxPublish;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}