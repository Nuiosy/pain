using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ISIK_Group
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            txtUsername.KeyDown += new KeyEventHandler(TxtUsername_KeyDown);
            txtPassword.KeyDown += new KeyEventHandler(TxtPassword_KeyDown);
            btnLogin.KeyDown += new KeyEventHandler(BtnLogin_KeyDown);
        }

        private void TxtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void BtnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PerformLogin();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            PerformLogin();
        }

        private void PerformLogin()
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string agencyName = cmbAgency.SelectedItem?.ToString();

            if (DatabaseHelper.AuthenticateUser(username, password, agencyName))
            {
                DatabaseHelper.SetAgencyDatabase(agencyName);
                MainForm mainForm = new MainForm(username);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ungültiger Benutzername, Passwort oder Reisebüro.");
            }
        }
    }
}
