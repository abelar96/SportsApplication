namespace SportsPro_UserInterface
{
    partial class FrmTechnicianIncidents
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
            this.dgrIncidentByTech = new System.Windows.Forms.DataGridView();
            this.labelTechName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxTechID = new System.Windows.Forms.TextBox();
            this.btnGetIncidents = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrIncidentByTech)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrIncidentByTech
            // 
            this.dgrIncidentByTech.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrIncidentByTech.Location = new System.Drawing.Point(12, 72);
            this.dgrIncidentByTech.Name = "dgrIncidentByTech";
            this.dgrIncidentByTech.RowTemplate.Height = 28;
            this.dgrIncidentByTech.Size = new System.Drawing.Size(938, 366);
            this.dgrIncidentByTech.TabIndex = 0;
            this.dgrIncidentByTech.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrIncidentByTech_CellContentClick);
            // 
            // labelTechName
            // 
            this.labelTechName.AutoSize = true;
            this.labelTechName.Location = new System.Drawing.Point(43, 25);
            this.labelTechName.Name = "labelTechName";
            this.labelTechName.Size = new System.Drawing.Size(114, 20);
            this.labelTechName.TabIndex = 1;
            this.labelTechName.Text = "Technician ID: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(468, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxTechID
            // 
            this.textBoxTechID.Location = new System.Drawing.Point(201, 25);
            this.textBoxTechID.Name = "textBoxTechID";
            this.textBoxTechID.Size = new System.Drawing.Size(137, 26);
            this.textBoxTechID.TabIndex = 2;
            // 
            // btnGetIncidents
            // 
            this.btnGetIncidents.Location = new System.Drawing.Point(396, 23);
            this.btnGetIncidents.Name = "btnGetIncidents";
            this.btnGetIncidents.Size = new System.Drawing.Size(159, 37);
            this.btnGetIncidents.TabIndex = 3;
            this.btnGetIncidents.Text = "Get Incidents";
            this.btnGetIncidents.UseVisualStyleBackColor = true;
            this.btnGetIncidents.Click += new System.EventHandler(this.btnGetIncidents_Click);
            // 
            // FrmTechnicianIncidents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 450);
            this.Controls.Add(this.btnGetIncidents);
            this.Controls.Add(this.textBoxTechID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTechName);
            this.Controls.Add(this.dgrIncidentByTech);
            this.Name = "FrmTechnicianIncidents";
            this.Text = "Open Incidents by Technician";
            this.Load += new System.EventHandler(this.FrmTechnicianIncidents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrIncidentByTech)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrIncidentByTech;
        private System.Windows.Forms.Label labelTechName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxTechID;
        private System.Windows.Forms.Button btnGetIncidents;
    }
}