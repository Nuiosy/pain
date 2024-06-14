namespace ISIK_Group
{
    partial class AdminPanelForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnManageLogins;
        private System.Windows.Forms.Button btnManageRoles;
        private System.Windows.Forms.Button btnManageTravelAgencies;
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
            this.btnManageLogins = new System.Windows.Forms.Button();
            this.btnManageRoles = new System.Windows.Forms.Button();
            this.btnManageTravelAgencies = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageLogins
            // 
            this.btnManageLogins.Location = new System.Drawing.Point(12, 12);
            this.btnManageLogins.Name = "btnManageLogins";
            this.btnManageLogins.Size = new System.Drawing.Size(160, 40);
            this.btnManageLogins.TabIndex = 0;
            this.btnManageLogins.Text = "Logins verwalten";
            this.btnManageLogins.UseVisualStyleBackColor = true;
            this.btnManageLogins.Click += new System.EventHandler(this.BtnManageLogins_Click);
            // 
            // btnManageRoles
            // 
            this.btnManageRoles.Location = new System.Drawing.Point(12, 58);
            this.btnManageRoles.Name = "btnManageRoles";
            this.btnManageRoles.Size = new System.Drawing.Size(160, 40);
            this.btnManageRoles.TabIndex = 1;
            this.btnManageRoles.Text = "Rollen verwalten";
            this.btnManageRoles.UseVisualStyleBackColor = true;
            this.btnManageRoles.Click += new System.EventHandler(this.BtnManageRoles_Click);
            // 
            // btnManageTravelAgencies
            // 
            this.btnManageTravelAgencies.Location = new System.Drawing.Point(12, 104);
            this.btnManageTravelAgencies.Name = "btnManageTravelAgencies";
            this.btnManageTravelAgencies.Size = new System.Drawing.Size(160, 40);
            this.btnManageTravelAgencies.TabIndex = 2;
            this.btnManageTravelAgencies.Text = "Reisebüros verwalten";
            this.btnManageTravelAgencies.UseVisualStyleBackColor = true;
            this.btnManageTravelAgencies.Click += new System.EventHandler(this.BtnManageTravelAgencies_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 150);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 40);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Schließen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 201);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnManageTravelAgencies);
            this.Controls.Add(this.btnManageRoles);
            this.Controls.Add(this.btnManageLogins);
            this.Name = "AdminPanelForm";
            this.Text = "Admin Panel";
            this.ResumeLayout(false);
        }
    }
}
