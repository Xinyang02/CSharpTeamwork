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
            this.merchantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlMerchant = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.merchantBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // merchantBindingSource
            // 
            this.merchantBindingSource.DataSource = typeof(Bottom_Class.Merchant);
            // 
            // pnlMerchant
            // 
            this.pnlMerchant.AutoScroll = true;
            this.pnlMerchant.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlMerchant.Location = new System.Drawing.Point(0, 0);
            this.pnlMerchant.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMerchant.Name = "pnlMerchant";
            this.pnlMerchant.Size = new System.Drawing.Size(1250, 690);
            this.pnlMerchant.TabIndex = 0;
            this.pnlMerchant.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMerchant_Paint);
            // 
            // Select_Merchant_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 680);
            this.Controls.Add(this.pnlMerchant);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Select_Merchant_Form";
            this.Text = "ShopForm";
            this.Load += new System.EventHandler(this.ShopForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.merchantBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource merchantBindingSource;
        private System.Windows.Forms.Panel pnlMerchant;
    }
}