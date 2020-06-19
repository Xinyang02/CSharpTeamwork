namespace Front_End_Class
{
    partial class Customer_Form
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
            this.radMy = new System.Windows.Forms.RadioButton();
            this.radMenu = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radOrderList = new System.Windows.Forms.RadioButton();
            this.ChangingPanel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radMy
            // 
            this.radMy.Appearance = System.Windows.Forms.Appearance.Button;
            this.radMy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radMy.Location = new System.Drawing.Point(1, 148);
            this.radMy.Margin = new System.Windows.Forms.Padding(0);
            this.radMy.Name = "radMy";
            this.radMy.Size = new System.Drawing.Size(79, 129);
            this.radMy.TabIndex = 0;
            this.radMy.TabStop = true;
            this.radMy.Text = "我的";
            this.radMy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radMy.UseVisualStyleBackColor = true;
            this.radMy.CheckedChanged += new System.EventHandler(this.btnInfo_Form_Show);
            // 
            // radMenu
            // 
            this.radMenu.Appearance = System.Windows.Forms.Appearance.Button;
            this.radMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radMenu.Location = new System.Drawing.Point(1, 0);
            this.radMenu.Margin = new System.Windows.Forms.Padding(0);
            this.radMenu.Name = "radMenu";
            this.radMenu.Size = new System.Drawing.Size(79, 148);
            this.radMenu.TabIndex = 1;
            this.radMenu.TabStop = true;
            this.radMenu.Text = "首页";
            this.radMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radMenu.UseVisualStyleBackColor = true;
            this.radMenu.CheckedChanged += new System.EventHandler(this.btnMenu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radOrderList);
            this.panel1.Controls.Add(this.radMenu);
            this.panel1.Controls.Add(this.radMy);
            this.panel1.Location = new System.Drawing.Point(9, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 424);
            this.panel1.TabIndex = 2;
            // 
            // radOrderList
            // 
            this.radOrderList.Appearance = System.Windows.Forms.Appearance.Button;
            this.radOrderList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radOrderList.Location = new System.Drawing.Point(0, 277);
            this.radOrderList.Margin = new System.Windows.Forms.Padding(0);
            this.radOrderList.Name = "radOrderList";
            this.radOrderList.Size = new System.Drawing.Size(80, 143);
            this.radOrderList.TabIndex = 0;
            this.radOrderList.TabStop = true;
            this.radOrderList.Text = "订单";
            this.radOrderList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radOrderList.UseVisualStyleBackColor = true;
            this.radOrderList.CheckedChanged += new System.EventHandler(this.radOrderList_Click);
            // 
            // ChangingPanel
            // 
            this.ChangingPanel.Location = new System.Drawing.Point(95, 45);
            this.ChangingPanel.Name = "ChangingPanel";
            this.ChangingPanel.Size = new System.Drawing.Size(620, 420);
            this.ChangingPanel.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(652, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 38);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(592, 7);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(60, 37);
            this.btnHide.TabIndex = 5;
            this.btnHide.Text = "—";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // Customer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 474);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ChangingPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer_Form";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radMy;
        private System.Windows.Forms.RadioButton radMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel ChangingPanel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.RadioButton radOrderList;
    }
}