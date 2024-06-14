namespace ISIK_Group
{
    partial class BookingManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabFlights;
        private System.Windows.Forms.TabPage tabHotels;
        private System.Windows.Forms.TabPage tabExtras;
        private System.Windows.Forms.TabPage tabParticipants;
        private System.Windows.Forms.TabPage tabPayments;
        private System.Windows.Forms.TabPage tabBookingData;
        private System.Windows.Forms.TabPage tabFinances;
        private System.Windows.Forms.TabPage tabTasks;
        private System.Windows.Forms.TabPage tabHistory;
        private System.Windows.Forms.TabPage tabControlling;

        private System.Windows.Forms.Label lblBookingNumber;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCustomerNumber;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblBookingNumberValue;
        private System.Windows.Forms.Label lblDateValue;
        private System.Windows.Forms.Label lblCustomerNumberValue;
        private System.Windows.Forms.Label lblCustomerNameValue;
        private System.Windows.Forms.Label lblPhoneValue;
        private System.Windows.Forms.Label lblMobileValue;
        private System.Windows.Forms.Label lblStatusValue;

        private System.Windows.Forms.DataGridView dgvFlights;
        private System.Windows.Forms.DataGridView dgvHotels;
        private System.Windows.Forms.DataGridView dgvExtras;
        private System.Windows.Forms.DataGridView dgvParticipants;
        private System.Windows.Forms.DataGridView dgvPayments;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnClose;

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
            tabControl = new TabControl();
            tabFlights = new TabPage();
            dgvFlights = new DataGridView();
            tabHotels = new TabPage();
            dgvHotels = new DataGridView();
            tabExtras = new TabPage();
            dgvExtras = new DataGridView();
            tabParticipants = new TabPage();
            dgvParticipants = new DataGridView();
            tabPayments = new TabPage();
            dgvPayments = new DataGridView();
            tabBookingData = new TabPage();
            tabFinances = new TabPage();
            tabTasks = new TabPage();
            tabHistory = new TabPage();
            tabControlling = new TabPage();
            lblBookingNumber = new Label();
            lblDate = new Label();
            lblCustomerNumber = new Label();
            lblCustomerName = new Label();
            lblPhone = new Label();
            lblMobile = new Label();
            lblStatus = new Label();
            lblBookingNumberValue = new Label();
            lblDateValue = new Label();
            lblCustomerNumberValue = new Label();
            lblCustomerNameValue = new Label();
            lblPhoneValue = new Label();
            lblMobileValue = new Label();
            lblStatusValue = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            btnPrint = new Button();
            btnCopy = new Button();
            btnClose = new Button();
            tabControl.SuspendLayout();
            tabFlights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFlights).BeginInit();
            tabHotels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHotels).BeginInit();
            tabExtras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExtras).BeginInit();
            tabParticipants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvParticipants).BeginInit();
            tabPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabFlights);
            tabControl.Controls.Add(tabHotels);
            tabControl.Controls.Add(tabExtras);
            tabControl.Controls.Add(tabParticipants);
            tabControl.Controls.Add(tabPayments);
            tabControl.Controls.Add(tabBookingData);
            tabControl.Controls.Add(tabFinances);
            tabControl.Controls.Add(tabTasks);
            tabControl.Controls.Add(tabHistory);
            tabControl.Controls.Add(tabControlling);
            tabControl.Location = new Point(12, 80);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1000, 333);
            tabControl.TabIndex = 0;
            // 
            // tabFlights
            // 
            tabFlights.Controls.Add(dgvFlights);
            tabFlights.Location = new Point(4, 24);
            tabFlights.Name = "tabFlights";
            tabFlights.Size = new Size(992, 305);
            tabFlights.TabIndex = 0;
            tabFlights.Text = "Flüge";
            tabFlights.UseVisualStyleBackColor = true;
            // 
            // dgvFlights
            // 
            dgvFlights.Dock = DockStyle.Fill;
            dgvFlights.Location = new Point(0, 0);
            dgvFlights.Name = "dgvFlights";
            dgvFlights.Size = new Size(992, 305);
            dgvFlights.TabIndex = 0;
            // 
            // tabHotels
            // 
            tabHotels.Controls.Add(dgvHotels);
            tabHotels.Location = new Point(4, 24);
            tabHotels.Name = "tabHotels";
            tabHotels.Size = new Size(992, 305);
            tabHotels.TabIndex = 1;
            tabHotels.Text = "Hotels";
            tabHotels.UseVisualStyleBackColor = true;
            // 
            // dgvHotels
            // 
            dgvHotels.Dock = DockStyle.Fill;
            dgvHotels.Location = new Point(0, 0);
            dgvHotels.Name = "dgvHotels";
            dgvHotels.Size = new Size(992, 305);
            dgvHotels.TabIndex = 0;
            // 
            // tabExtras
            // 
            tabExtras.Controls.Add(dgvExtras);
            tabExtras.Location = new Point(4, 24);
            tabExtras.Name = "tabExtras";
            tabExtras.Size = new Size(992, 305);
            tabExtras.TabIndex = 2;
            tabExtras.Text = "Zusatzleistungen";
            tabExtras.UseVisualStyleBackColor = true;
            // 
            // dgvExtras
            // 
            dgvExtras.Dock = DockStyle.Fill;
            dgvExtras.Location = new Point(0, 0);
            dgvExtras.Name = "dgvExtras";
            dgvExtras.Size = new Size(992, 305);
            dgvExtras.TabIndex = 0;
            // 
            // tabParticipants
            // 
            tabParticipants.Controls.Add(dgvParticipants);
            tabParticipants.Location = new Point(4, 24);
            tabParticipants.Name = "tabParticipants";
            tabParticipants.Size = new Size(992, 305);
            tabParticipants.TabIndex = 3;
            tabParticipants.Text = "Teilnehmer";
            tabParticipants.UseVisualStyleBackColor = true;
            // 
            // dgvParticipants
            // 
            dgvParticipants.Dock = DockStyle.Fill;
            dgvParticipants.Location = new Point(0, 0);
            dgvParticipants.Name = "dgvParticipants";
            dgvParticipants.Size = new Size(992, 305);
            dgvParticipants.TabIndex = 0;
            // 
            // tabPayments
            // 
            tabPayments.Controls.Add(dgvPayments);
            tabPayments.Location = new Point(4, 24);
            tabPayments.Name = "tabPayments";
            tabPayments.Size = new Size(992, 305);
            tabPayments.TabIndex = 4;
            tabPayments.Text = "Zahlungen";
            tabPayments.UseVisualStyleBackColor = true;
            // 
            // dgvPayments
            // 
            dgvPayments.Dock = DockStyle.Fill;
            dgvPayments.Location = new Point(0, 0);
            dgvPayments.Name = "dgvPayments";
            dgvPayments.Size = new Size(992, 305);
            dgvPayments.TabIndex = 0;
            // 
            // tabBookingData
            // 
            tabBookingData.Location = new Point(4, 24);
            tabBookingData.Name = "tabBookingData";
            tabBookingData.Size = new Size(992, 305);
            tabBookingData.TabIndex = 5;
            tabBookingData.Text = "Buchungsdaten";
            tabBookingData.UseVisualStyleBackColor = true;
            // 
            // tabFinances
            // 
            tabFinances.Location = new Point(4, 24);
            tabFinances.Name = "tabFinances";
            tabFinances.Size = new Size(992, 305);
            tabFinances.TabIndex = 6;
            tabFinances.Text = "Finanzen";
            tabFinances.UseVisualStyleBackColor = true;
            // 
            // tabTasks
            // 
            tabTasks.Location = new Point(4, 24);
            tabTasks.Name = "tabTasks";
            tabTasks.Size = new Size(992, 305);
            tabTasks.TabIndex = 7;
            tabTasks.Text = "Aufgaben";
            tabTasks.UseVisualStyleBackColor = true;
            // 
            // tabHistory
            // 
            tabHistory.Location = new Point(4, 24);
            tabHistory.Name = "tabHistory";
            tabHistory.Size = new Size(992, 305);
            tabHistory.TabIndex = 8;
            tabHistory.Text = "History";
            tabHistory.UseVisualStyleBackColor = true;
            // 
            // tabControlling
            // 
            tabControlling.Location = new Point(4, 24);
            tabControlling.Name = "tabControlling";
            tabControlling.Size = new Size(992, 305);
            tabControlling.TabIndex = 9;
            tabControlling.Text = "Controlling";
            tabControlling.UseVisualStyleBackColor = true;
            // 
            // lblBookingNumber
            // 
            lblBookingNumber.Location = new Point(12, 10);
            lblBookingNumber.Name = "lblBookingNumber";
            lblBookingNumber.Size = new Size(114, 20);
            lblBookingNumber.TabIndex = 1;
            lblBookingNumber.Text = "Buchungsnummer:";
            // 
            // lblDate
            // 
            lblDate.Location = new Point(12, 30);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(100, 23);
            lblDate.TabIndex = 3;
            lblDate.Text = "Datum:";
            // 
            // lblCustomerNumber
            // 
            lblCustomerNumber.Location = new Point(250, 10);
            lblCustomerNumber.Name = "lblCustomerNumber";
            lblCustomerNumber.Size = new Size(100, 23);
            lblCustomerNumber.TabIndex = 5;
            lblCustomerNumber.Text = "Kundennummer:";
            // 
            // lblCustomerName
            // 
            lblCustomerName.Location = new Point(250, 30);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(100, 23);
            lblCustomerName.TabIndex = 7;
            lblCustomerName.Text = "Kundenname:";
            // 
            // lblPhone
            // 
            lblPhone.Location = new Point(500, 10);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(100, 23);
            lblPhone.TabIndex = 9;
            lblPhone.Text = "Telefon:";
            // 
            // lblMobile
            // 
            lblMobile.Location = new Point(500, 30);
            lblMobile.Name = "lblMobile";
            lblMobile.Size = new Size(100, 23);
            lblMobile.TabIndex = 11;
            lblMobile.Text = "Mobiltelefon:";
            // 
            // lblStatus
            // 
            lblStatus.Location = new Point(700, 10);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(100, 23);
            lblStatus.TabIndex = 13;
            lblStatus.Text = "Status:";
            // 
            // lblBookingNumberValue
            // 
            lblBookingNumberValue.Location = new Point(120, 10);
            lblBookingNumberValue.Name = "lblBookingNumberValue";
            lblBookingNumberValue.Size = new Size(100, 23);
            lblBookingNumberValue.TabIndex = 2;
            // 
            // lblDateValue
            // 
            lblDateValue.Location = new Point(120, 30);
            lblDateValue.Name = "lblDateValue";
            lblDateValue.Size = new Size(100, 23);
            lblDateValue.TabIndex = 4;
            // 
            // lblCustomerNumberValue
            // 
            lblCustomerNumberValue.Location = new Point(360, 10);
            lblCustomerNumberValue.Name = "lblCustomerNumberValue";
            lblCustomerNumberValue.Size = new Size(100, 23);
            lblCustomerNumberValue.TabIndex = 6;
            // 
            // lblCustomerNameValue
            // 
            lblCustomerNameValue.Location = new Point(360, 30);
            lblCustomerNameValue.Name = "lblCustomerNameValue";
            lblCustomerNameValue.Size = new Size(100, 23);
            lblCustomerNameValue.TabIndex = 8;
            // 
            // lblPhoneValue
            // 
            lblPhoneValue.Location = new Point(570, 10);
            lblPhoneValue.Name = "lblPhoneValue";
            lblPhoneValue.Size = new Size(100, 23);
            lblPhoneValue.TabIndex = 10;
            // 
            // lblMobileValue
            // 
            lblMobileValue.Location = new Point(570, 30);
            lblMobileValue.Name = "lblMobileValue";
            lblMobileValue.Size = new Size(100, 23);
            lblMobileValue.TabIndex = 12;
            // 
            // lblStatusValue
            // 
            lblStatusValue.ForeColor = Color.Red;
            lblStatusValue.Location = new Point(750, 10);
            lblStatusValue.Name = "lblStatusValue";
            lblStatusValue.Size = new Size(100, 23);
            lblStatusValue.TabIndex = 14;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1018, 104);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Neu";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(1018, 144);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "Bearbeiten";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1018, 184);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Löschen";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1018, 224);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 18;
            btnSave.Text = "Speichern";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(1018, 264);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Abbrechen";
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(1018, 304);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 23);
            btnPrint.TabIndex = 20;
            btnPrint.Text = "Druck";
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(1018, 344);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(75, 23);
            btnCopy.TabIndex = 21;
            btnCopy.Text = "Kopieren";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1018, 384);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 22;
            btnClose.Text = "Schließen";
            // 
            // BookingManagementForm
            // 
            ClientSize = new Size(1187, 673);
            Controls.Add(tabControl);
            Controls.Add(lblBookingNumber);
            Controls.Add(lblBookingNumberValue);
            Controls.Add(lblDate);
            Controls.Add(lblDateValue);
            Controls.Add(lblCustomerNumber);
            Controls.Add(lblCustomerNumberValue);
            Controls.Add(lblCustomerName);
            Controls.Add(lblCustomerNameValue);
            Controls.Add(lblPhone);
            Controls.Add(lblPhoneValue);
            Controls.Add(lblMobile);
            Controls.Add(lblMobileValue);
            Controls.Add(lblStatus);
            Controls.Add(lblStatusValue);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(btnPrint);
            Controls.Add(btnCopy);
            Controls.Add(btnClose);
            Name = "BookingManagementForm";
            Text = "Buchungsverwaltung";
            tabControl.ResumeLayout(false);
            tabFlights.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFlights).EndInit();
            tabHotels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHotels).EndInit();
            tabExtras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvExtras).EndInit();
            tabParticipants.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvParticipants).EndInit();
            tabPayments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPayments).EndInit();
            ResumeLayout(false);
        }
    }
}
