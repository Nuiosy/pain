using System;
using System.Windows.Forms;

namespace ISIK_Group
{
    public partial class AdminPanelForm : Form
    {
        public AdminPanelForm()
        {
            InitializeComponent();
        }

        private void BtnManageLogins_Click(object sender, EventArgs e)
        {
            // Logins verwalten
        }

        private void BtnManageRoles_Click(object sender, EventArgs e)
        {
            // Rollen verwalten
        }

        private void BtnManageTravelAgencies_Click(object sender, EventArgs e)
        {
            TravelAgencyManagementForm travelAgencyManagementForm = new TravelAgencyManagementForm();
            travelAgencyManagementForm.ShowDialog();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
