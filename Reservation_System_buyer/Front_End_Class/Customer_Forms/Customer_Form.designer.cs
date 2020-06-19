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
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.radMy = new System.Windows.Forms.RadioButton();
            this.radMenu = new System.Windows.Forms.RadioButton();
            this.radOrderList = new System.Windows.Forms.RadioButton();
            this.ChangingPanel = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.radMy);
            this.panel3.Controls.Add(this.radMenu);
            this.panel3.Controls.Add(this.radOrderList);
            this.panel3.Controls.Add(this.ChangingPanel);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1300, 810);
            this.panel3.TabIndex = 7;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(1215, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "╳";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radMy
            // 
            this.radMy.Appearance = System.Windows.Forms.Appearance.Button;
            this.radMy.BackColor = System.Drawing.Color.Black;
            this.radMy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.radMy.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radMy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radMy.Location = new System.Drawing.Point(745, 20);
            this.radMy.Margin = new System.Windows.Forms.Padding(0);
            this.radMy.Name = "radMy";
            this.radMy.Size = new System.Drawing.Size(70, 70);
            this.radMy.TabIndex = 0;
            this.radMy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radMy.UseVisualStyleBackColor = false;
            this.radMy.CheckedChanged += new System.EventHandler(this.btnInfo_Form_Show);
            // 
            // radMenu
            // 
            this.radMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radMenu.Appearance = System.Windows.Forms.Appearance.Button;
            this.radMenu.BackColor = System.Drawing.Color.Black;
            this.radMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.radMenu.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radMenu.Location = new System.Drawing.Point(485, 20);
            this.radMenu.Margin = new System.Windows.Forms.Padding(0);
            this.radMenu.Name = "radMenu";
            this.radMenu.Size = new System.Drawing.Size(70, 70);
            this.radMenu.TabIndex = 1;
            this.radMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radMenu.UseVisualStyleBackColor = false;
            this.radMenu.CheckedChanged += new System.EventHandler(this.btnMenu_Click);
            // 
            // radOrderList
            // 
            this.radOrderList.Appearance = System.Windows.Forms.Appearance.Button;
            this.radOrderList.BackColor = System.Drawing.Color.Black;
            this.radOrderList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.radOrderList.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radOrderList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radOrderList.Location = new System.Drawing.Point(615, 20);
            this.radOrderList.Margin = new System.Windows.Forms.Padding(0);
            this.radOrderList.Name = "radOrderList";
            this.radOrderList.Size = new System.Drawing.Size(70, 70);
            this.radOrderList.TabIndex = 0;
            this.radOrderList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radOrderList.UseVisualStyleBackColor = false;
            this.radOrderList.CheckedChanged += new System.EventHandler(this.radOrderList_Click);
            // 
            // ChangingPanel
            // 
            this.ChangingPanel.BackColor = System.Drawing.Color.Silver;
            this.ChangingPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ChangingPanel.Location = new System.Drawing.Point(25, 90);
            this.ChangingPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ChangingPanel.Name = "ChangingPanel";
            this.ChangingPanel.Size = new System.Drawing.Size(1250, 690);
            this.ChangingPanel.TabIndex = 3;
            this.ChangingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ChangingPanel_Paint);
            // 
            // Customer_Form
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1300, 810);
            this.Controls.Add(this.panel3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer_Form";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radMy;
        private System.Windows.Forms.RadioButton radMenu;
        private System.Windows.Forms.RadioButton radOrderList;
        private System.Windows.Forms.Panel ChangingPanel;
        private System.Windows.Forms.Button button1;
    }
}