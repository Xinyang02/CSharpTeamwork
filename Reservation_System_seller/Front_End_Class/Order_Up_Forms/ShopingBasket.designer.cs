namespace Front_End_Class
{
    partial class Shopping_Basket_Form
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
            this.pnlOrderItemShow = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlOrderItemShow
            // 
            this.pnlOrderItemShow.Location = new System.Drawing.Point(12, 12);
            this.pnlOrderItemShow.Name = "pnlOrderItemShow";
            this.pnlOrderItemShow.Size = new System.Drawing.Size(260, 340);
            this.pnlOrderItemShow.TabIndex = 0;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(94, 372);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(98, 40);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // Shopping_Basket_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 436);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.pnlOrderItemShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Shopping_Basket_Form";
            this.Text = "ShoppingBasketForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOrderItemShow;
        private System.Windows.Forms.Button btnReturn;
    }
}