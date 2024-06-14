using System;
using System.Windows.Forms;

namespace ISIK_Group
{
    public partial class BookingManagementForm : Form
    {
        public BookingManagementForm()
        {
            InitializeComponent();
            LoadBookings();
        }

        private void LoadBookings()
        {
            dgvFlights.Rows.Clear();
            var bookings = DatabaseHelper.GetBookings();
            while (bookings.Read())
            {
                dgvFlights.Rows.Add(
                    bookings["BookingID"],
                    bookings["BookingNumber"],
                    bookings["StartDate"],
                    bookings["CustomerNumber"],
                    bookings["FullName"],
                    bookings["Participants"],
                    bookings["Organizer"],
                    bookings["TotalPrice"],
                    bookings["OpenPrice"],
                    bookings["IsBlocked"]
                );
            }
        }

        private void BtnAddBooking_Click(object sender, EventArgs e)
        {
            string bookingNumber = txtBookingNumber.Text;
            DateTime date = dtpBookingDate.Value;
            int customerId = Convert.ToInt32(cmbCustomer.SelectedValue);
            string participants = txtParticipants.Text;
            string organizer = txtOrganizer.Text;
            decimal totalPrice = Convert.ToDecimal(txtTotalPrice.Text);
            decimal openPrice = Convert.ToDecimal(txtOpenPrice.Text);

            DatabaseHelper.AddBooking(bookingNumber, date, customerId, participants, organizer, totalPrice, openPrice);
            LoadBookings();
        }

        private void BtnDeleteBooking_Click(object sender, EventArgs e)
        {
            if (dgvFlights.SelectedRows.Count > 0)
            {
                int bookingId = Convert.ToInt32(dgvFlights.SelectedRows[0].Cells["BookingID"].Value);
                DatabaseHelper.DeleteBooking(bookingId);
                LoadBookings();
            }
        }

        private void dgvFlights_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
