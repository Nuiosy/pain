using System;
using System.Windows.Forms;

namespace ISIK_Group
{
    public partial class NewCustomerForm : Form
    {
        public NewCustomerForm()
        {
            InitializeComponent();
            GenerateCustomerNumber();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                string customerNumber = lblCustomerNumber.Text;
                bool isBlocked = chkIsBlocked.Checked;

                DatabaseHelper.AddCustomer(firstName, lastName, customerNumber, isBlocked);
                MessageBox.Show("Kunde erfolgreich hinzugefügt");
                this.Close();
            }
            else
            {
                MessageBox.Show("Bitte füllen Sie alle erforderlichen Felder aus.");
            }
        }

        private bool ValidateFields()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                txtFirstName.BackColor = System.Drawing.Color.Red;
                isValid = false;
            }
            else
            {
                txtFirstName.BackColor = System.Drawing.Color.White;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                txtLastName.BackColor = System.Drawing.Color.Red;
                isValid = false;
            }
            else
            {
                txtLastName.BackColor = System.Drawing.Color.White;
            }

            return isValid;
        }

        private void TxtFirstName_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                txtFirstName.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                txtFirstName.BackColor = System.Drawing.Color.White;
            }
        }

        private void TxtLastName_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                txtLastName.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                txtLastName.BackColor = System.Drawing.Color.White;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenerateCustomerNumber()
        {
            lblCustomerNumber.Text = "CN" + DateTime.Now.Ticks.ToString().Substring(0, 10);
        }
    }
}
