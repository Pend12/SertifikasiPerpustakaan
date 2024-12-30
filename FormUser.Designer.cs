    namespace SertifikasiPerpustakaan
{
    partial class FormUser
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
            this.iconButtonMuser = new FontAwesome.Sharp.IconButton();
            this.iconButtonkoleksi = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.dataGridViewKoleksiUser = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonNoPinjam = new System.Windows.Forms.RadioButton();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKoleksiUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.iconButtonLogout);
            this.panel1.Controls.Add(this.iconButtonMuser);
            this.panel1.Controls.Add(this.iconButtonkoleksi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 2;
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
            this.iconButtonMuser.Text = "History Pinjam";
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
            // dataGridViewKoleksiUser
            // 
            this.dataGridViewKoleksiUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKoleksiUser.Location = new System.Drawing.Point(207, 29);
            this.dataGridViewKoleksiUser.Name = "dataGridViewKoleksiUser";
            this.dataGridViewKoleksiUser.RowTemplate.Height = 25;
            this.dataGridViewKoleksiUser.Size = new System.Drawing.Size(590, 416);
            this.dataGridViewKoleksiUser.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(207, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Koleksi : ";
            // 
            // radioButtonNoPinjam
            // 
            this.radioButtonNoPinjam.AutoSize = true;
            this.radioButtonNoPinjam.Location = new System.Drawing.Point(607, 4);
            this.radioButtonNoPinjam.Name = "radioButtonNoPinjam";
            this.radioButtonNoPinjam.Size = new System.Drawing.Size(114, 19);
            this.radioButtonNoPinjam.TabIndex = 5;
            this.radioButtonNoPinjam.Text = "Belum Terpinjam";
            this.radioButtonNoPinjam.UseVisualStyleBackColor = true;
            this.radioButtonNoPinjam.CheckedChanged += new System.EventHandler(this.radioButtonNoPinjam_CheckedChanged);
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Location = new System.Drawing.Point(727, 4);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(61, 19);
            this.radioButtonAll.TabIndex = 6;
            this.radioButtonAll.Text = "Semua";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            this.radioButtonAll.CheckedChanged += new System.EventHandler(this.radioButtonAll_CheckedChanged);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButtonAll);
            this.Controls.Add(this.radioButtonNoPinjam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewKoleksiUser);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKoleksiUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButtonLogout;
        private FontAwesome.Sharp.IconButton iconButtonMuser;
        private FontAwesome.Sharp.IconButton iconButtonkoleksi;
        private Label label2;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private DataGridView dataGridViewKoleksiUser;
        private Label label3;
        private RadioButton radioButtonNoPinjam;
        private RadioButton radioButtonAll;
    }
}