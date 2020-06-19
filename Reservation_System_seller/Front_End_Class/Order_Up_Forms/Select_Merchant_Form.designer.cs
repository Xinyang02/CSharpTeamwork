namespace Front_End_Class
{
    partial class Select_Merchant_Form
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
            this.components = new System.ComponentModel.Container();
            this.pnlMerchants = new System.Windows.Forms.Panel();
            this.merchantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.merchantBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMerchants
            // 
            this.pnlMerchants.Location = new System.Drawing.Point(8, 6);
            this.pnlMerchants.Name = "pnlMerchants";
            this.pnlMerchants.Size = new System.Drawing.Size(628, 405);
            this.pnlMerchants.TabIndex = 0;
            this.pnlMerchants.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // merchantBindingSource
            // 
            this.merchantBindingSource.DataSource = typeof(Bottom_Class.Merchant);
            // 
            // Select_Merchant_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 442);
            this.Controls.Add(this.pnlMerchants);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Select_Merchant_Form";
            this.Text = "ShopForm";
            this.Load += new System.EventHandler(this.ShopForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.merchantBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMerchants;
        private System.Windows.Forms.BindingSource merchantBindingSource;
    }
}