namespace ISIK_Group
{
    partial class TravelAgencyManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtAgencyName;
        private System.Windows.Forms.ListBox lstAgencies;
        private System.Windows.Forms.Button btnAddAgency;
        private System.Windows.Forms.Button btnDeleteAgency;

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
            txtAgencyName = new TextBox();
            lstAgencies = new ListBox();
            btnAddAgency = new Button();
            btnDeleteAgency = new Button();
            SuspendLayout();
            // 
            // txtAgencyName
            // 
            txtAgencyName.Location = new Point(12, 12);
            txtAgencyName.Name = "txtAgencyName";
            txtAgencyName.Size = new Size(200, 23);
            txtAgencyName.TabIndex = 0;
            // 
            // lstAgencies
            // 
            lstAgencies.FormattingEnabled = true;
            lstAgencies.ItemHeight = 15;
            lstAgencies.Location = new Point(12, 41);
            lstAgencies.Name = "lstAgencies";
            lstAgencies.Size = new Size(200, 154);
            lstAgencies.TabIndex = 1;
            // 
            // btnAddAgency
            // 
            btnAddAgency.Location = new Point(218, 12);
            btnAddAgency.Name = "btnAddAgency";
            btnAddAgency.Size = new Size(88, 23);
            btnAddAgency.TabIndex = 2;
            btnAddAgency.Text = "Hinzufügen";
            btnAddAgency.UseVisualStyleBackColor = true;
            btnAddAgency.Click += BtnAddAgency_Click;
            // 
            // btnDeleteAgency
            // 
            btnDeleteAgency.Location = new Point(218, 41);
            btnDeleteAgency.Name = "btnDeleteAgency";
            btnDeleteAgency.Size = new Size(88, 23);
            btnDeleteAgency.TabIndex = 3;
            btnDeleteAgency.Text = "Löschen";
            btnDeleteAgency.UseVisualStyleBackColor = true;
            btnDeleteAgency.Click += BtnDeleteAgency_Click;
            // 
            // TravelAgencyManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 211);
            Controls.Add(btnDeleteAgency);
            Controls.Add(btnAddAgency);
            Controls.Add(lstAgencies);
            Controls.Add(txtAgencyName);
            Name = "TravelAgencyManagementForm";
            Text = "Reisebüros verwalten";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
