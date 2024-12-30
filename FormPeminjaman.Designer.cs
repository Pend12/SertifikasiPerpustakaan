namespace SertifikasiPerpustakaan
{
    partial class FormPeminjaman
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
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.listBoxKoleksi = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonPinjam = new System.Windows.Forms.Button();
            this.dataGridViewBorrowed = new System.Windows.Forms.DataGridView();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrowed)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 1;
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
            this.iconButtonkoleksi.Click += new System.EventHandler(this.iconButtonkoleksi_Click_1);
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
            this.label3.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(207, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Peminjaman : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(207, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "User : ";
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(261, 26);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(145, 23);
            this.comboBoxUser.TabIndex = 4;
            // 
            // listBoxKoleksi
            // 
            this.listBoxKoleksi.FormattingEnabled = true;
            this.listBoxKoleksi.ItemHeight = 15;
            this.listBoxKoleksi.Location = new System.Drawing.Point(204, 73);
            this.listBoxKoleksi.Name = "listBoxKoleksi";
            this.listBoxKoleksi.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxKoleksi.Size = new System.Drawing.Size(581, 139);
            this.listBoxKoleksi.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(207, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Pilih Buku : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(207, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Buku yang Terpinjam :";
            // 
            // buttonPinjam
            // 
            this.buttonPinjam.Location = new System.Drawing.Point(710, 45);
            this.buttonPinjam.Name = "buttonPinjam";
            this.buttonPinjam.Size = new System.Drawing.Size(75, 23);
            this.buttonPinjam.TabIndex = 8;
            this.buttonPinjam.Text = "Pinjam";
            this.buttonPinjam.UseVisualStyleBackColor = true;
            this.buttonPinjam.Click += new System.EventHandler(this.buttonPinjam_Click);
            // 
            // dataGridViewBorrowed
            // 
            this.dataGridViewBorrowed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBorrowed.Location = new System.Drawing.Point(207, 242);
            this.dataGridViewBorrowed.Name = "dataGridViewBorrowed";
            this.dataGridViewBorrowed.RowTemplate.Height = 25;
            this.dataGridViewBorrowed.Size = new System.Drawing.Size(581, 203);
            this.dataGridViewBorrowed.TabIndex = 9;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(698, 218);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(87, 23);
            this.buttonReturn.TabIndex = 10;
            this.buttonReturn.Text = "Kembalikan";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // FormPeminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.dataGridViewBorrowed);
            this.Controls.Add(this.buttonPinjam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxKoleksi);
            this.Controls.Add(this.comboBoxUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPeminjaman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPeminjaman";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrowed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButtonLogout;
        private FontAwesome.Sharp.IconButton iconButtonPeminjaman;
        private FontAwesome.Sharp.IconButton iconButtonMuser;
        private FontAwesome.Sharp.IconButton iconButtonkoleksi;
        private Label label2;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxUser;
        private ListBox listBoxKoleksi;
        private Label label5;
        private Label label6;
        private Button buttonPinjam;
        private DataGridView dataGridViewBorrowed;
        private Button buttonReturn;
    }
}