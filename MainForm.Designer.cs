namespace ISIK_Group
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neueBuchungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buchungSuchenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buchungshistorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stornierungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuerKundeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kundenlisteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finanzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zahlungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offeneBuchungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rollenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rollenUndBerechtigungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemeinstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem berichteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buchungsberichteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finanzberichteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem umsatzberichteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stornoberichteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rückerstattungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reisebürosToolStripMenuItem;

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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            neueBuchungToolStripMenuItem = new ToolStripMenuItem();
            buchungSuchenToolStripMenuItem = new ToolStripMenuItem();
            buchungshistorieToolStripMenuItem = new ToolStripMenuItem();
            stornierungenToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            neuerKundeToolStripMenuItem = new ToolStripMenuItem();
            kundenlisteToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            finanzenToolStripMenuItem = new ToolStripMenuItem();
            zahlungenToolStripMenuItem = new ToolStripMenuItem();
            rückerstattungenToolStripMenuItem = new ToolStripMenuItem();
            offeneBuchungenToolStripMenuItem = new ToolStripMenuItem();
            berichteToolStripMenuItem = new ToolStripMenuItem();
            buchungsberichteToolStripMenuItem = new ToolStripMenuItem();
            finanzberichteToolStripMenuItem = new ToolStripMenuItem();
            umsatzberichteToolStripMenuItem = new ToolStripMenuItem();
            stornoberichteToolStripMenuItem = new ToolStripMenuItem();
            einstellungenToolStripMenuItem = new ToolStripMenuItem();
            rollenToolStripMenuItem = new ToolStripMenuItem();
            rollenUndBerechtigungenToolStripMenuItem = new ToolStripMenuItem();
            systemeinstellungenToolStripMenuItem = new ToolStripMenuItem();
            hilfeToolStripMenuItem = new ToolStripMenuItem();
            informationenToolStripMenuItem = new ToolStripMenuItem();
            supportToolStripMenuItem = new ToolStripMenuItem();
            adminToolStripMenuItem = new ToolStripMenuItem();
            reisebürosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem, berichteToolStripMenuItem, einstellungenToolStripMenuItem, hilfeToolStripMenuItem, adminToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1137, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { neueBuchungToolStripMenuItem, buchungSuchenToolStripMenuItem, buchungshistorieToolStripMenuItem, stornierungenToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(80, 20);
            fileToolStripMenuItem.Text = "Buchungen";
            fileToolStripMenuItem.Click += FileToolStripMenuItem_Click;
            // 
            // neueBuchungToolStripMenuItem
            // 
            neueBuchungToolStripMenuItem.Name = "neueBuchungToolStripMenuItem";
            neueBuchungToolStripMenuItem.Size = new Size(166, 22);
            neueBuchungToolStripMenuItem.Text = "Neue Buchung";
            neueBuchungToolStripMenuItem.Click += NeueBuchungToolStripMenuItem_Click;
            // 
            // buchungSuchenToolStripMenuItem
            // 
            buchungSuchenToolStripMenuItem.Name = "buchungSuchenToolStripMenuItem";
            buchungSuchenToolStripMenuItem.Size = new Size(166, 22);
            buchungSuchenToolStripMenuItem.Text = "Buchung suchen";
            // 
            // buchungshistorieToolStripMenuItem
            // 
            buchungshistorieToolStripMenuItem.Name = "buchungshistorieToolStripMenuItem";
            buchungshistorieToolStripMenuItem.Size = new Size(166, 22);
            buchungshistorieToolStripMenuItem.Text = "Buchungshistorie";
            // 
            // stornierungenToolStripMenuItem
            // 
            stornierungenToolStripMenuItem.Name = "stornierungenToolStripMenuItem";
            stornierungenToolStripMenuItem.Size = new Size(166, 22);
            stornierungenToolStripMenuItem.Text = "Stornierungen";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { neuerKundeToolStripMenuItem, kundenlisteToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(119, 20);
            editToolStripMenuItem.Text = "Kundenverwaltung";
            // 
            // neuerKundeToolStripMenuItem
            // 
            neuerKundeToolStripMenuItem.Name = "neuerKundeToolStripMenuItem";
            neuerKundeToolStripMenuItem.Size = new Size(143, 22);
            neuerKundeToolStripMenuItem.Text = "Neuer Kunde";
            neuerKundeToolStripMenuItem.Click += NeuerKundeToolStripMenuItem_Click;
            // 
            // kundenlisteToolStripMenuItem
            // 
            kundenlisteToolStripMenuItem.Name = "kundenlisteToolStripMenuItem";
            kundenlisteToolStripMenuItem.Size = new Size(143, 22);
            kundenlisteToolStripMenuItem.Text = "Kundenliste";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { finanzenToolStripMenuItem, offeneBuchungenToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(87, 20);
            helpToolStripMenuItem.Text = "Buchhaltung";
            helpToolStripMenuItem.Click += HelpToolStripMenuItem_Click;
            // 
            // finanzenToolStripMenuItem
            // 
            finanzenToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zahlungenToolStripMenuItem, rückerstattungenToolStripMenuItem });
            finanzenToolStripMenuItem.Name = "finanzenToolStripMenuItem";
            finanzenToolStripMenuItem.Size = new Size(174, 22);
            finanzenToolStripMenuItem.Text = "Finanzen";
            // 
            // zahlungenToolStripMenuItem
            // 
            zahlungenToolStripMenuItem.Name = "zahlungenToolStripMenuItem";
            zahlungenToolStripMenuItem.Size = new Size(167, 22);
            zahlungenToolStripMenuItem.Text = "Zahlungen";
            // 
            // rückerstattungenToolStripMenuItem
            // 
            rückerstattungenToolStripMenuItem.Name = "rückerstattungenToolStripMenuItem";
            rückerstattungenToolStripMenuItem.Size = new Size(167, 22);
            rückerstattungenToolStripMenuItem.Text = "Rückerstattungen";
            // 
            // offeneBuchungenToolStripMenuItem
            // 
            offeneBuchungenToolStripMenuItem.Name = "offeneBuchungenToolStripMenuItem";
            offeneBuchungenToolStripMenuItem.Size = new Size(174, 22);
            offeneBuchungenToolStripMenuItem.Text = "Offene Buchungen";
            // 
            // berichteToolStripMenuItem
            // 
            berichteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { buchungsberichteToolStripMenuItem, finanzberichteToolStripMenuItem, umsatzberichteToolStripMenuItem, stornoberichteToolStripMenuItem });
            berichteToolStripMenuItem.Name = "berichteToolStripMenuItem";
            berichteToolStripMenuItem.Size = new Size(62, 20);
            berichteToolStripMenuItem.Text = "Berichte";
            // 
            // buchungsberichteToolStripMenuItem
            // 
            buchungsberichteToolStripMenuItem.Name = "buchungsberichteToolStripMenuItem";
            buchungsberichteToolStripMenuItem.Size = new Size(170, 22);
            buchungsberichteToolStripMenuItem.Text = "Buchungsberichte";
            // 
            // finanzberichteToolStripMenuItem
            // 
            finanzberichteToolStripMenuItem.Name = "finanzberichteToolStripMenuItem";
            finanzberichteToolStripMenuItem.Size = new Size(170, 22);
            finanzberichteToolStripMenuItem.Text = "Finanzberichte";
            // 
            // umsatzberichteToolStripMenuItem
            // 
            umsatzberichteToolStripMenuItem.Name = "umsatzberichteToolStripMenuItem";
            umsatzberichteToolStripMenuItem.Size = new Size(170, 22);
            umsatzberichteToolStripMenuItem.Text = "Umsatzberichte";
            // 
            // stornoberichteToolStripMenuItem
            // 
            stornoberichteToolStripMenuItem.Name = "stornoberichteToolStripMenuItem";
            stornoberichteToolStripMenuItem.Size = new Size(170, 22);
            stornoberichteToolStripMenuItem.Text = "Stornoberichte";
            // 
            // einstellungenToolStripMenuItem
            // 
            einstellungenToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rollenToolStripMenuItem, rollenUndBerechtigungenToolStripMenuItem, systemeinstellungenToolStripMenuItem });
            einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            einstellungenToolStripMenuItem.Size = new Size(90, 20);
            einstellungenToolStripMenuItem.Text = "Einstellungen";
            // 
            // rollenToolStripMenuItem
            // 
            rollenToolStripMenuItem.Name = "rollenToolStripMenuItem";
            rollenToolStripMenuItem.Size = new Size(218, 22);
            rollenToolStripMenuItem.Text = "Benutzerverwaltung";
            rollenToolStripMenuItem.Click += RollenToolStripMenuItem_Click;
            // 
            // rollenUndBerechtigungenToolStripMenuItem
            // 
            rollenUndBerechtigungenToolStripMenuItem.Name = "rollenUndBerechtigungenToolStripMenuItem";
            rollenUndBerechtigungenToolStripMenuItem.Size = new Size(218, 22);
            rollenUndBerechtigungenToolStripMenuItem.Text = "Rollen und Berechtigungen";
            // 
            // systemeinstellungenToolStripMenuItem
            // 
            systemeinstellungenToolStripMenuItem.Name = "systemeinstellungenToolStripMenuItem";
            systemeinstellungenToolStripMenuItem.Size = new Size(218, 22);
            systemeinstellungenToolStripMenuItem.Text = "Systemeinstellungen";
            // 
            // hilfeToolStripMenuItem
            // 
            hilfeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { informationenToolStripMenuItem, supportToolStripMenuItem });
            hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            hilfeToolStripMenuItem.Size = new Size(44, 20);
            hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // informationenToolStripMenuItem
            // 
            informationenToolStripMenuItem.Name = "informationenToolStripMenuItem";
            informationenToolStripMenuItem.Size = new Size(150, 22);
            informationenToolStripMenuItem.Text = "Informationen";
            // 
            // supportToolStripMenuItem
            // 
            supportToolStripMenuItem.Name = "supportToolStripMenuItem";
            supportToolStripMenuItem.Size = new Size(150, 22);
            supportToolStripMenuItem.Text = "Support";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reisebürosToolStripMenuItem });
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(55, 20);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Visible = false;
            // 
            // reisebürosToolStripMenuItem
            // 
            reisebürosToolStripMenuItem.Name = "reisebürosToolStripMenuItem";
            reisebürosToolStripMenuItem.Size = new Size(180, 22);
            reisebürosToolStripMenuItem.Text = "Reisebüros";
            reisebürosToolStripMenuItem.Click += ReisebürosToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 632);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "ISIK Group - Version 0.1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
