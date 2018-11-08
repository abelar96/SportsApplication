namespace SportsPro_UserInterface
{
    partial class FrmOpenIncidents
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
            this.dgrOpenIncidents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgrOpenIncidents)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrOpenIncidents
            // 
            this.dgrOpenIncidents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrOpenIncidents.Location = new System.Drawing.Point(12, 67);
            this.dgrOpenIncidents.Name = "dgrOpenIncidents";
            this.dgrOpenIncidents.RowHeadersWidth = 38;
            this.dgrOpenIncidents.RowTemplate.Height = 28;
            this.dgrOpenIncidents.Size = new System.Drawing.Size(866, 486);
            this.dgrOpenIncidents.TabIndex = 0;
            this.dgrOpenIncidents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrOpenIncidents_CellContentClick);
            // 
            // FrmOpenIncidents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(890, 586);
            this.Controls.Add(this.dgrOpenIncidents);
            this.Name = "FrmOpenIncidents";
            this.Text = "Open Incidents";
            this.Load += new System.EventHandler(this.FrmOpenIncidents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrOpenIncidents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrOpenIncidents;
    }
}