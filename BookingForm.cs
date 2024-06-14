using System;
using System.Windows.Forms;

namespace ISIK_Group
{
    public partial class BookingForm : Form
    {
        private readonly int customerId;

        public BookingForm(int customerId, string customerNumber, string customerName, bool isBlocked)
        {
            InitializeComponent();
            this.customerId = customerId;
            txtCustomerID.Text = customerId.ToString();
            txtCustomerNumber.Text = customerNumber;
            txtCustomerName.Text = customerName;
            chkIsBlocked.Checked = isBlocked;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string bookingNumber = txtBookingNumber.Text;
            DateTime date = dtpBookingDate.Value;
            string participants = txtParticipants.Text;
            string organizer = txtOrganizer.Text;
            decimal totalPrice = decimal.Parse(txtTotalPrice.Text);
            decimal openPrice = decimal.Parse(txtOpenPrice.Text);

            DatabaseHelper.AddBooking(bookingNumber, date, customerId, participants, organizer, totalPrice, openPrice);
            MessageBox.Show("Buchung erfolgreich hinzugefügt");
            this.Close();
        }
    }
}
