namespace SportsPro_UserInterface
{
    partial class FrmMantainRegistration
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
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.cBoxCustName = new System.Windows.Forms.ComboBox();
            this.cBoxProduct = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(426, 113);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(68, 20);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Product:";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(129, 113);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(128, 20);
            this.lblCustName.TabIndex = 1;
            this.lblCustName.Text = "Customer Name:";
            // 
            // cBoxCustName
            // 
            this.cBoxCustName.FormattingEnabled = true;
            this.cBoxCustName.Location = new System.Drawing.Point(133, 198);
            this.cBoxCustName.Name = "cBoxCustName";
            this.cBoxCustName.Size = new System.Drawing.Size(240, 28);
            this.cBoxCustName.TabIndex = 2;
            // 
            // cBoxProduct
            // 
            this.cBoxProduct.FormattingEnabled = true;
            this.cBoxProduct.Location = new System.Drawing.Point(430, 198);
            this.cBoxProduct.Name = "cBoxProduct";
            this.cBoxProduct.Size = new System.Drawing.Size(225, 28);
            this.cBoxProduct.TabIndex = 3;
       
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(133, 305);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(107, 41);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(551, 304);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 42);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmMantainRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 443);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.cBoxProduct);
            this.Controls.Add(this.cBoxCustName);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.lblProduct);
            this.Name = "FrmMantainRegistration";
            this.Text = "FrmMantainRegistration";
            this.Load += new System.EventHandler(this.FrmMantainRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.ComboBox cBoxCustName;
        private System.Windows.Forms.ComboBox cBoxProduct;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnExit;
    }
}