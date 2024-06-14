using System;
using System.Windows.Forms;

namespace ISIK_Group
{
    public partial class TravelAgencyManagementForm : Form
    {
        public TravelAgencyManagementForm()
        {
            InitializeComponent();
            LoadAgencies();
        }

        private void LoadAgencies()
        {
            lstAgencies.Items.Clear();
            var agencies = DatabaseHelper.GetAgencies();
            while (agencies.Read())
            {
                lstAgencies.Items.Add(agencies["AgencyName"].ToString());
            }
        }

        private void BtnAddAgency_Click(object sender, EventArgs e)
        {
            string agencyName = txtAgencyName.Text;
            DatabaseHelper.AddAgency(agencyName);
            LoadAgencies();
        }

        private void BtnDeleteAgency_Click(object sender, EventArgs e)
        {
            if (lstAgencies.SelectedItem != null)
            {
                string agencyName = lstAgencies.SelectedItem.ToString();
                DatabaseHelper.DeleteAgency(agencyName);
                LoadAgencies();
            }
        }
    }
}
