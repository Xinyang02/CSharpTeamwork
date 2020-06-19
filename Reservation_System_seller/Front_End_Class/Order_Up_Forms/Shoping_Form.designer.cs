namespace Front_End_Class
{
    partial class Shoping_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ChangingPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ReturnToMainForm = new System.Windows.Forms.Button();
            this.btnShowMerchantInfo = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnOpenShoppingBasket = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.ChangingPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 458);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.ChangingPanel);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(789, 543);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // ChangingPanel
            // 
            this.ChangingPanel.AllowDrop = true;
            this.ChangingPanel.BackColor = System.Drawing.Color.Transparent;
            this.ChangingPanel.Controls.Add(this.panel2);
            this.ChangingPanel.Controls.Add(this.vScrollBar1);
            this.ChangingPanel.Location = new System.Drawing.Point(175, 0);
            this.ChangingPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ChangingPanel.Name = "ChangingPanel";
            this.ChangingPanel.Size = new System.Drawing.Size(608, 461);
            this.ChangingPanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 461);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(0, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(34, 50);
            this.vScrollBar1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ReturnToMainForm);
            this.panel3.Controls.Add(this.btnShowMerchantInfo);
            this.panel3.Controls.Add(this.btnSubmit);
            this.panel3.Controls.Add(this.btnOpenShoppingBasket);
            this.panel3.Location = new System.Drawing.Point(3, 467);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(780, 66);
            this.panel3.TabIndex = 2;
            // 
            // ReturnToMainForm
            // 
            this.ReturnToMainForm.Location = new System.Drawing.Point(666, 5);
            this.ReturnToMainForm.Name = "ReturnToMainForm";
            this.ReturnToMainForm.Size = new System.Drawing.Size(114, 61);
            this.ReturnToMainForm.TabIndex = 3;
            this.ReturnToMainForm.Text = "返回主界面";
            this.ReturnToMainForm.UseVisualStyleBackColor = true;
            this.ReturnToMainForm.Click += new System.EventHandler(this.btnReturnMainForm);
            // 
            // btnShowMerchantInfo
            // 
            this.btnShowMerchantInfo.Location = new System.Drawing.Point(439, 3);
            this.btnShowMerchantInfo.Name = "btnShowMerchantInfo";
            this.btnShowMerchantInfo.Size = new System.Drawing.Size(120, 62);
            this.btnShowMerchantInfo.TabIndex = 2;
            this.btnShowMerchantInfo.Text = "商家信息";
            this.btnShowMerchantInfo.UseVisualStyleBackColor = true;
            
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(225, 0);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(119, 63);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "提交订单";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmitFormShow);
            // 
            // btnOpenShoppingBasket
            // 
            this.btnOpenShoppingBasket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOpenShoppingBasket.Location = new System.Drawing.Point(4, 3);
            this.btnOpenShoppingBasket.Name = "btnOpenShoppingBasket";
            this.btnOpenShoppingBasket.Size = new System.Drawing.Size(105, 60);
            this.btnOpenShoppingBasket.TabIndex = 0;
            this.btnOpenShoppingBasket.Text = "购物篮";
            this.btnOpenShoppingBasket.UseVisualStyleBackColor = true;
            this.btnOpenShoppingBasket.Click += new System.EventHandler(this.btnOpenShoppingBasketForm);
            // 
            // Shoping_Form
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(789, 553);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Shoping_Form";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ChangingPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel ChangingPanel;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnOpenShoppingBasket;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnShowMerchantInfo;
        private System.Windows.Forms.Button ReturnToMainForm;
    }
}