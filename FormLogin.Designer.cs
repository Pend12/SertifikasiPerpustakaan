namespace SertifikasiPerpustakaan
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButtonLogin = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.labelApk = new System.Windows.Forms.Label();
            this.iconButtonQuit = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(281, 147);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(257, 23);
            this.textBoxUsername.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.iconButtonQuit);
            this.panel1.Controls.Add(this.iconButtonLogin);
            this.panel1.Controls.Add(this.iconPictureBox2);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.labelApk);
            this.panel1.Controls.Add(this.textBoxUsername);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 1;
            // 
            // iconButtonLogin
            // 
            this.iconButtonLogin.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButtonLogin.IconChar = FontAwesome.Sharp.IconChar.ArrowRightLong;
            this.iconButtonLogin.IconColor = System.Drawing.Color.Black;
            this.iconButtonLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonLogin.IconSize = 30;
            this.iconButtonLogin.Location = new System.Drawing.Point(347, 241);
            this.iconButtonLogin.Name = "iconButtonLogin";
            this.iconButtonLogin.Size = new System.Drawing.Size(111, 44);
            this.iconButtonLogin.TabIndex = 5;
            this.iconButtonLogin.Text = "Login";
            this.iconButtonLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButtonLogin.UseVisualStyleBackColor = true;
            this.iconButtonLogin.Click += new System.EventHandler(this.iconButtonLogin_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.Location = new System.Drawing.Point(219, 188);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox2.TabIndex = 4;
            this.iconPictureBox2.TabStop = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(281, 197);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(257, 23);
            this.textBoxPassword.TabIndex = 3;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(219, 138);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // labelApk
            // 
            this.labelApk.AutoSize = true;
            this.labelApk.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelApk.Location = new System.Drawing.Point(69, 41);
            this.labelApk.Name = "labelApk";
            this.labelApk.Size = new System.Drawing.Size(644, 57);
            this.labelApk.TabIndex = 1;
            this.labelApk.Text = "Aplikasi perpustakaan";
            // 
            // iconButtonQuit
            // 
            this.iconButtonQuit.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButtonQuit.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.iconButtonQuit.IconColor = System.Drawing.Color.IndianRed;
            this.iconButtonQuit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonQuit.IconSize = 30;
            this.iconButtonQuit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButtonQuit.Location = new System.Drawing.Point(726, 375);
            this.iconButtonQuit.Name = "iconButtonQuit";
            this.iconButtonQuit.Size = new System.Drawing.Size(47, 48);
            this.iconButtonQuit.TabIndex = 6;
            this.iconButtonQuit.Text = "quit";
            this.iconButtonQuit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonQuit.UseVisualStyleBackColor = true;
            this.iconButtonQuit.Click += new System.EventHandler(this.iconButtonQuit_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox textBoxUsername;
        private BindingSource bindingSource1;
        private Panel panel1;
        private Label labelApk;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton iconButtonLogin;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private TextBox textBoxPassword;
        private FontAwesome.Sharp.IconButton iconButtonQuit;
    }
}