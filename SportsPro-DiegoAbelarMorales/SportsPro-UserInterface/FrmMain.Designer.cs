namespace SportsPro_UserInterface
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantainRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayOpenIncidentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayOpenIncidentsByTechnicianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tooStripName = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.maintanceToolStripMenuItem,
            this.registrationToolStripMenuItem,
            this.incidentsToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1178, 33);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // maintanceToolStripMenuItem
            // 
            this.maintanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantainRegistrationToolStripMenuItem});
            this.maintanceToolStripMenuItem.Name = "maintanceToolStripMenuItem";
            this.maintanceToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.maintanceToolStripMenuItem.Text = "Maintance";
            // 
            // mantainRegistrationToolStripMenuItem
            // 
            this.mantainRegistrationToolStripMenuItem.Name = "mantainRegistrationToolStripMenuItem";
            this.mantainRegistrationToolStripMenuItem.Size = new System.Drawing.Size(267, 30);
            this.mantainRegistrationToolStripMenuItem.Text = "Mantain Registrations";
            this.mantainRegistrationToolStripMenuItem.Click += new System.EventHandler(this.mantainRegistrationToolStripMenuItem_Click);
            // 
            // registrationToolStripMenuItem
            // 
            this.registrationToolStripMenuItem.Name = "registrationToolStripMenuItem";
            this.registrationToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.registrationToolStripMenuItem.Text = "Registration";
            // 
            // incidentsToolStripMenuItem
            // 
            this.incidentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayOpenIncidentsToolStripMenuItem,
            this.displayOpenIncidentsByTechnicianToolStripMenuItem});
            this.incidentsToolStripMenuItem.Name = "incidentsToolStripMenuItem";
            this.incidentsToolStripMenuItem.Size = new System.Drawing.Size(95, 29);
            this.incidentsToolStripMenuItem.Text = "Incidents";
            // 
            // displayOpenIncidentsToolStripMenuItem
            // 
            this.displayOpenIncidentsToolStripMenuItem.Name = "displayOpenIncidentsToolStripMenuItem";
            this.displayOpenIncidentsToolStripMenuItem.Size = new System.Drawing.Size(387, 30);
            this.displayOpenIncidentsToolStripMenuItem.Text = "Display Open Incidents";
            this.displayOpenIncidentsToolStripMenuItem.Click += new System.EventHandler(this.displayOpenIncidentsToolStripMenuItem_Click_1);
            // 
            // displayOpenIncidentsByTechnicianToolStripMenuItem
            // 
            this.displayOpenIncidentsByTechnicianToolStripMenuItem.Name = "displayOpenIncidentsByTechnicianToolStripMenuItem";
            this.displayOpenIncidentsByTechnicianToolStripMenuItem.Size = new System.Drawing.Size(387, 30);
            this.displayOpenIncidentsByTechnicianToolStripMenuItem.Text = "Display Open Incidents By Technician";
            this.displayOpenIncidentsByTechnicianToolStripMenuItem.Click += new System.EventHandler(this.displayOpenIncidentsByTechnicianToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tooStripName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 570);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1178, 30);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tooStripName
            // 
            this.tooStripName.Name = "tooStripName";
            this.tooStripName.Size = new System.Drawing.Size(184, 25);
            this.tooStripName.Text = "Diego Abelar Morales";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 600);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStripMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SportsPro System";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrationToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tooStripName;
        private System.Windows.Forms.ToolStripMenuItem incidentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayOpenIncidentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayOpenIncidentsByTechnicianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantainRegistrationToolStripMenuItem;
    }
}

