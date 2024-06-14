namespace ISIK_Group
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblAgency;
        private System.Windows.Forms.ComboBox cmbAgency;
        private System.Windows.Forms.PictureBox isikreisenloginpicturebox;
        private System.Windows.Forms.Label lblLoginTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblUsername = new Label();
            lblPassword = new Label();
            lblAgency = new Label();
            cmbAgency = new ComboBox();
            isikreisenloginpicturebox = new PictureBox();
            lblLoginTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)isikreisenloginpicturebox).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(122, 123);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 23);
            txtUsername.TabIndex = 0;
            txtUsername.KeyDown += TxtUsername_KeyDown;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(122, 152);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 23);
            txtPassword.TabIndex = 1;
            txtPassword.KeyDown += TxtPassword_KeyDown;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(122, 181);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 30);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += BtnLogin_Click;
            btnLogin.KeyDown += BtnLogin_KeyDown;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(32, 123);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(83, 15);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Benutzername";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(32, 152);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(54, 15);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Passwort";
            // 
            // lblAgency
            // 
            lblAgency.AutoSize = true;
            lblAgency.Location = new Point(32, 94);
            lblAgency.Name = "lblAgency";
            lblAgency.Size = new Size(59, 15);
            lblAgency.TabIndex = 5;
            lblAgency.Text = "Reisebüro";
            // 
            // cmbAgency
            // 
            cmbAgency.FormattingEnabled = true;
            cmbAgency.Location = new Point(122, 94);
            cmbAgency.Name = "cmbAgency";
            cmbAgency.Size = new Size(200, 23);
            cmbAgency.TabIndex = 6;
            // 
            // isikreisenloginpicturebox
            // 
            isikreisenloginpicturebox.Image = Properties.Resources.Isik_Logo_klein;
            isikreisenloginpicturebox.Location = new Point(350, 50);
            isikreisenloginpicturebox.Name = "isikreisenloginpicturebox";
            isikreisenloginpicturebox.Size = new Size(200, 200);
            isikreisenloginpicturebox.SizeMode = PictureBoxSizeMode.Zoom;
            isikreisenloginpicturebox.TabIndex = 7;
            isikreisenloginpicturebox.TabStop = false;
            // 
            // lblLoginTitle
            // 
            lblLoginTitle.AutoSize = true;
            lblLoginTitle.Font = new Font("Arial", 24F, FontStyle.Bold);
            lblLoginTitle.Location = new Point(32, 34);
            lblLoginTitle.Name = "lblLoginTitle";
            lblLoginTitle.Size = new Size(116, 37);
            lblLoginTitle.TabIndex = 8;
            lblLoginTitle.Text = "LOGIN";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 300);
            Controls.Add(lblLoginTitle);
            Controls.Add(isikreisenloginpicturebox);
            Controls.Add(cmbAgency);
            Controls.Add(lblAgency);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "LoginForm";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)isikreisenloginpicturebox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
