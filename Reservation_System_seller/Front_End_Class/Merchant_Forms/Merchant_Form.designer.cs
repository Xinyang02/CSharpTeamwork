namespace Front_End_Class
{
    partial class Merchant_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Merchant_Form));
            this.changeMsg = new System.Windows.Forms.RadioButton();
            this.AddFood = new System.Windows.Forms.RadioButton();
            this.GetOrder = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // changeMsg
            // 
            this.changeMsg.Appearance = System.Windows.Forms.Appearance.Button;
            this.changeMsg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.changeMsg.Image = ((System.Drawing.Image)(resources.GetObject("changeMsg.Image")));
            this.changeMsg.Location = new System.Drawing.Point(12, 404);
            this.changeMsg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeMsg.Name = "changeMsg";
            this.changeMsg.Size = new System.Drawing.Size(207, 190);
            this.changeMsg.TabIndex = 2;
            this.changeMsg.TabStop = true;
            this.changeMsg.Text = "修改信息";
            this.changeMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.changeMsg.UseVisualStyleBackColor = true;
            this.changeMsg.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // AddFood
            // 
            this.AddFood.Appearance = System.Windows.Forms.Appearance.Button;
            this.AddFood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddFood.BackgroundImage")));
            this.AddFood.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddFood.Location = new System.Drawing.Point(12, 208);
            this.AddFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddFood.Name = "AddFood";
            this.AddFood.Size = new System.Drawing.Size(207, 190);
            this.AddFood.TabIndex = 1;
            this.AddFood.TabStop = true;
            this.AddFood.Text = "修改菜单";
            this.AddFood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddFood.UseVisualStyleBackColor = true;
            this.AddFood.CheckedChanged += new System.EventHandler(this.AddFood_CheckedChanged);
            // 
            // GetOrder
            // 
            this.GetOrder.Appearance = System.Windows.Forms.Appearance.Button;
            this.GetOrder.ForeColor = System.Drawing.Color.White;
            this.GetOrder.Image = ((System.Drawing.Image)(resources.GetObject("GetOrder.Image")));
            this.GetOrder.Location = new System.Drawing.Point(12, 12);
            this.GetOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GetOrder.Name = "GetOrder";
            this.GetOrder.Size = new System.Drawing.Size(207, 190);
            this.GetOrder.TabIndex = 0;
            this.GetOrder.TabStop = true;
            this.GetOrder.Text = "查看订单";
            this.GetOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GetOrder.UseVisualStyleBackColor = true;
            this.GetOrder.CheckedChanged += new System.EventHandler(this.getOrder_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(225, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 608);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Merchant_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1507, 602);
            this.Controls.Add(this.changeMsg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GetOrder);
            this.Controls.Add(this.AddFood);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Merchant_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "订餐系统";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton changeMsg;
        private System.Windows.Forms.RadioButton AddFood;
        private System.Windows.Forms.RadioButton GetOrder;
        private System.Windows.Forms.Panel panel1;
    }
}