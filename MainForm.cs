using System;
using System.Windows.Forms;

namespace ISIK_Group
{
    public partial class MainForm : Form
    {
        private readonly string _username;

        public MainForm(string username)
        {
            InitializeComponent();
            _username = username;
            if (username == "admin")
            {
                adminToolStripMenuItem.Visible = true;
            }
            else
            {
                adminToolStripMenuItem.Visible = false;
            }
        }

        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Platzhalter für Datei-Menüaktionen
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Platzhalter für Hilfe-Menüaktionen
        }

        private void RollenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Platzhalter für Rollen-Menüaktionen
        }

        private void NeueBuchungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookingManagementForm bookingManagementForm = new();
            bookingManagementForm.ShowDialog();
        }

        private void NeuerKundeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCustomerForm newCustomerForm = new();
            newCustomerForm.ShowDialog();
        }

        private void ReisebürosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TravelAgencyManagementForm travelAgencyManagementForm = new();
            travelAgencyManagementForm.ShowDialog();
        }
    }
}
