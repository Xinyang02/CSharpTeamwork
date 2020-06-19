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
            this.pnlCuisineType = new System.Windows.Forms.Panel();
            this.btnShowMerchantInfo = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnOpenShoppingBasket = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChangingPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.ReturnToMainForm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCuisineType
            // 
            this.pnlCuisineType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCuisineType.AutoScroll = true;
            this.pnlCuisineType.BackColor = System.Drawing.Color.White;
            this.pnlCuisineType.Location = new System.Drawing.Point(20, 20);
            this.pnlCuisineType.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCuisineType.Name = "pnlCuisineType";
            this.pnlCuisineType.Size = new System.Drawing.Size(200, 670);
            this.pnlCuisineType.TabIndex = 0;
            this.pnlCuisineType.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnShowMerchantInfo
            // 
            this.btnShowMerchantInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShowMerchantInfo.BackColor = System.Drawing.Color.Black;
            this.btnShowMerchantInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowMerchantInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowMerchantInfo.Location = new System.Drawing.Point(615, 20);
            this.btnShowMerchantInfo.Name = "btnShowMerchantInfo";
            this.btnShowMerchantInfo.Size = new System.Drawing.Size(70, 70);
            this.btnShowMerchantInfo.TabIndex = 2;
            this.btnShowMerchantInfo.UseVisualStyleBackColor = false;
            this.btnShowMerchantInfo.Click += new System.EventHandler(this.btnShowMerchantInfo_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.BackColor = System.Drawing.Color.Black;
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Location = new System.Drawing.Point(745, 20);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(70, 70);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmitFormShow);
            // 
            // btnOpenShoppingBasket
            // 
            this.btnOpenShoppingBasket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpenShoppingBasket.BackColor = System.Drawing.Color.Black;
            this.btnOpenShoppingBasket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpenShoppingBasket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenShoppingBasket.Location = new System.Drawing.Point(485, 20);
            this.btnOpenShoppingBasket.Name = "btnOpenShoppingBasket";
            this.btnOpenShoppingBasket.Size = new System.Drawing.Size(70, 70);
            this.btnOpenShoppingBasket.TabIndex = 0;
            this.btnOpenShoppingBasket.UseVisualStyleBackColor = false;
            this.btnOpenShoppingBasket.Click += new System.EventHandler(this.btnOpenShoppingBasketForm);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.pnlCuisineType);
            this.panel1.Controls.Add(this.ChangingPanel);
            this.panel1.Location = new System.Drawing.Point(20, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 710);
            this.panel1.TabIndex = 3;
            // 
            // ChangingPanel
            // 
            this.ChangingPanel.BackColor = System.Drawing.Color.White;
            this.ChangingPanel.Location = new System.Drawing.Point(240, 20);
            this.ChangingPanel.Name = "ChangingPanel";
            this.ChangingPanel.Size = new System.Drawing.Size(1000, 670);
            this.ChangingPanel.TabIndex = 0;
            this.ChangingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ChangingPanel_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnSubmit);
            this.panel2.Controls.Add(this.btnShowMerchantInfo);
            this.panel2.Controls.Add(this.ReturnToMainForm);
            this.panel2.Controls.Add(this.btnOpenShoppingBasket);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1300, 820);
            this.panel2.TabIndex = 4;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.Location = new System.Drawing.Point(1220, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 35);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "╳";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ReturnToMainForm
            // 
            this.ReturnToMainForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReturnToMainForm.BackColor = System.Drawing.Color.Black;
            this.ReturnToMainForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ReturnToMainForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReturnToMainForm.Location = new System.Drawing.Point(40, 35);
            this.ReturnToMainForm.Name = "ReturnToMainForm";
            this.ReturnToMainForm.Size = new System.Drawing.Size(40, 40);
            this.ReturnToMainForm.TabIndex = 3;
            this.ReturnToMainForm.UseVisualStyleBackColor = false;
            this.ReturnToMainForm.Click += new System.EventHandler(this.btnReturnMainForm);
            // 
            // Shoping_Form
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1300, 820);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Shoping_Form";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCuisineType;
        private System.Windows.Forms.Button btnOpenShoppingBasket;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnShowMerchantInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel ChangingPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button ReturnToMainForm;
    }
}