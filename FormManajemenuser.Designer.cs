namespace SertifikasiPerpustakaan
{
    partial class FormManajemenuser
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
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.buttonAdduser = new System.Windows.Forms.Button();
            this.comboBoxPeminjaman = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewHistory = new System.Windows.Forms.DataGridView();
            this.buttonSearchhistoryuser = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(2, 1);
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
            this.iconButtonLogout.Location = new System.Drawing.Point(164, 412);
            this.iconButtonLogout.Name = "iconButtonLogout";
            this.iconButtonLogout.Size = new System.Drawing.Size(33, 35);
            this.iconButtonLogout.TabIndex = 7;
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
            this.iconButtonkoleksi.Click += new System.EventHandler(this.iconButtonkoleksi_Click);
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
            this.label3.Location = new System.Drawing.Point(208, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tambah User";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(283, 30);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(135, 23);
            this.textBoxUser.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Username : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password : ";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(283, 60);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(135, 23);
            this.textBoxPass.TabIndex = 6;
            // 
            // buttonAdduser
            // 
            this.buttonAdduser.Location = new System.Drawing.Point(424, 30);
            this.buttonAdduser.Name = "buttonAdduser";
            this.buttonAdduser.Size = new System.Drawing.Size(75, 23);
            this.buttonAdduser.TabIndex = 7;
            this.buttonAdduser.Text = "Add";
            this.buttonAdduser.UseVisualStyleBackColor = true;
            this.buttonAdduser.Click += new System.EventHandler(this.buttonAdduser_Click);
            // 
            // comboBoxPeminjaman
            // 
            this.comboBoxPeminjaman.FormattingEnabled = true;
            this.comboBoxPeminjaman.Location = new System.Drawing.Point(253, 124);
            this.comboBoxPeminjaman.Name = "comboBoxPeminjaman";
            this.comboBoxPeminjaman.Size = new System.Drawing.Size(121, 23);
            this.comboBoxPeminjaman.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "User :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(211, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Peminjaman";
            // 
            // dataGridViewHistory
            // 
            this.dataGridViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistory.Location = new System.Drawing.Point(211, 153);
            this.dataGridViewHistory.Name = "dataGridViewHistory";
            this.dataGridViewHistory.RowTemplate.Height = 25;
            this.dataGridViewHistory.Size = new System.Drawing.Size(577, 285);
            this.dataGridViewHistory.TabIndex = 11;
            // 
            // buttonSearchhistoryuser
            // 
            this.buttonSearchhistoryuser.Location = new System.Drawing.Point(380, 124);
            this.buttonSearchhistoryuser.Name = "buttonSearchhistoryuser";
            this.buttonSearchhistoryuser.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchhistoryuser.TabIndex = 12;
            this.buttonSearchhistoryuser.Text = "Search";
            this.buttonSearchhistoryuser.UseVisualStyleBackColor = true;
            this.buttonSearchhistoryuser.Click += new System.EventHandler(this.buttonSearchhistoryuser_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.IndianRed;
            this.buttonDelete.Location = new System.Drawing.Point(461, 124);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // FormManajemenuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSearchhistoryuser);
            this.Controls.Add(this.dataGridViewHistory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxPeminjaman);
            this.Controls.Add(this.buttonAdduser);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormManajemenuser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormManajemenuser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButtonPeminjaman;
        private FontAwesome.Sharp.IconButton iconButtonMuser;
        private FontAwesome.Sharp.IconButton iconButtonkoleksi;
        private Label label2;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label3;
        private TextBox textBoxUser;
        private Label label4;
        private Label label5;
        private TextBox textBoxPass;
        private Button buttonAdduser;
        private ComboBox comboBoxPeminjaman;
        private Label label6;
        private Label label7;
        private DataGridView dataGridViewHistory;
        private Button buttonSearchhistoryuser;
        private FontAwesome.Sharp.IconButton iconButtonLogout;
        private Button buttonDelete;
    }
}