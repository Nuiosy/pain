namespace ISIK_Group
{
    partial class BookingForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtBookingNumber;
        private System.Windows.Forms.DateTimePicker dtpBookingDate;
        private System.Windows.Forms.TextBox txtParticipants;
        private System.Windows.Forms.TextBox txtOrganizer;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtOpenPrice;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtCustomerNumber;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.CheckBox chkIsBlocked;
        private System.Windows.Forms.Button btnSave;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtBookingNumber = new System.Windows.Forms.TextBox();
            this.dtpBookingDate = new System.Windows.Forms.DateTimePicker();
            this.txtParticipants = new System.Windows.Forms.TextBox();
            this.txtOrganizer = new System.Windows.Forms.TextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtOpenPrice = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtCustomerNumber = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.chkIsBlocked = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBookingNumber
            // 
            this.txtBookingNumber.Location = new System.Drawing.Point(12, 12);
            this.txtBookingNumber.Name = "txtBookingNumber";
            this.txtBookingNumber.Size = new System.Drawing.Size(200, 23);
            this.txtBookingNumber.TabIndex = 0;
            // 
            // dtpBookingDate
            // 
            this.dtpBookingDate.Location = new System.Drawing.Point(12, 41);
            this.dtpBookingDate.Name = "dtpBookingDate";
            this.dtpBookingDate.Size = new System.Drawing.Size(200, 23);
            this.dtpBookingDate.TabIndex = 1;
            // 
            // txtParticipants
            // 
            this.txtParticipants.Location = new System.Drawing.Point(12, 70);
            this.txtParticipants.Name = "txtParticipants";
            this.txtParticipants.Size = new System.Drawing.Size(200, 23);
            this.txtParticipants.TabIndex = 2;
            // 
            // txtOrganizer
            // 
            this.txtOrganizer.Location = new System.Drawing.Point(12, 99);
            this.txtOrganizer.Name = "txtOrganizer";
            this.txtOrganizer.Size = new System.Drawing.Size(200, 23);
            this.txtOrganizer.TabIndex = 3;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(12, 128);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(200, 23);
            this.txtTotalPrice.TabIndex = 4;
            // 
            // txtOpenPrice
            // 
            this.txtOpenPrice.Location = new System.Drawing.Point(12, 157);
            this.txtOpenPrice.Name = "txtOpenPrice";
            this.txtOpenPrice.Size = new System.Drawing.Size(200, 23);
            this.txtOpenPrice.TabIndex = 5;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(12, 186);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(200, 23);
            this.txtCustomerID.TabIndex = 6;
            // 
            // txtCustomerNumber
            // 
            this.txtCustomerNumber.Location = new System.Drawing.Point(12, 215);
            this.txtCustomerNumber.Name = "txtCustomerNumber";
            this.txtCustomerNumber.ReadOnly = true;
            this.txtCustomerNumber.Size = new System.Drawing.Size(200, 23);
            this.txtCustomerNumber.TabIndex = 7;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(12, 244);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(200, 23);
            this.txtCustomerName.TabIndex = 8;
            // 
            // chkIsBlocked
            // 
            this.chkIsBlocked.AutoSize = true;
            this.chkIsBlocked.Location = new System.Drawing.Point(12, 273);
            this.chkIsBlocked.Name = "chkIsBlocked";
            this.chkIsBlocked.Size = new System.Drawing.Size(88, 19);
            this.chkIsBlocked.TabIndex = 9;
            this.chkIsBlocked.Text = "Gesperrt";
            this.chkIsBlocked.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 298);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 30);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 341);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkIsBlocked);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtCustomerNumber);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.txtOpenPrice);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.txtOrganizer);
            this.Controls.Add(this.txtParticipants);
            this.Controls.Add(this.dtpBookingDate);
            this.Controls.Add(this.txtBookingNumber);
            this.Name = "BookingForm";
            this.Text = "Buchung";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
