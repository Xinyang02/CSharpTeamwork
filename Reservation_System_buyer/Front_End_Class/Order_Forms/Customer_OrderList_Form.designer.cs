namespace Front_End_Class
{
    partial class Customer_OrderList_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_OrderList_Form));
            this.pnlOrders = new System.Windows.Forms.Panel();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReceiveOrder = new System.Windows.Forms.Button();
            this.btnDisplayOrder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOrders
            // 
            this.pnlOrders.AutoScroll = true;
            this.pnlOrders.BackColor = System.Drawing.Color.White;
            this.pnlOrders.Location = new System.Drawing.Point(20, 20);
            this.pnlOrders.Margin = new System.Windows.Forms.Padding(0);
            this.pnlOrders.Name = "pnlOrders";
            this.pnlOrders.Size = new System.Drawing.Size(1100, 650);
            this.pnlOrders.TabIndex = 0;
            this.pnlOrders.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteOrder.BackColor = System.Drawing.Color.White;
            this.btnDeleteOrder.FlatAppearance.BorderSize = 0;
            this.btnDeleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteOrder.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDeleteOrder.Location = new System.Drawing.Point(0, 215);
            this.btnDeleteOrder.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(96, 215);
            this.btnDeleteOrder.TabIndex = 1;
            this.btnDeleteOrder.Text = " 取消   订单";
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btnReceiveOrder);
            this.panel1.Controls.Add(this.btnDisplayOrder);
            this.panel1.Controls.Add(this.btnDeleteOrder);
            this.panel1.Location = new System.Drawing.Point(1142, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 650);
            this.panel1.TabIndex = 2;
            // 
            // btnReceiveOrder
            // 
            this.btnReceiveOrder.BackColor = System.Drawing.Color.White;
            this.btnReceiveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReceiveOrder.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReceiveOrder.Location = new System.Drawing.Point(0, 430);
            this.btnReceiveOrder.Name = "btnReceiveOrder";
            this.btnReceiveOrder.Size = new System.Drawing.Size(96, 220);
            this.btnReceiveOrder.TabIndex = 3;
            this.btnReceiveOrder.Text = " 确认   收货";
            this.btnReceiveOrder.UseVisualStyleBackColor = false;
            this.btnReceiveOrder.Click += new System.EventHandler(this.btnReceiveOrder_Click);
            // 
            // btnDisplayOrder
            // 
            this.btnDisplayOrder.BackColor = System.Drawing.Color.White;
            this.btnDisplayOrder.FlatAppearance.BorderSize = 0;
            this.btnDisplayOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDisplayOrder.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDisplayOrder.Location = new System.Drawing.Point(0, 0);
            this.btnDisplayOrder.Margin = new System.Windows.Forms.Padding(0);
            this.btnDisplayOrder.Name = "btnDisplayOrder";
            this.btnDisplayOrder.Size = new System.Drawing.Size(96, 215);
            this.btnDisplayOrder.TabIndex = 2;
            this.btnDisplayOrder.Text = " 查看   订单";
            this.btnDisplayOrder.UseVisualStyleBackColor = false;
            this.btnDisplayOrder.Click += new System.EventHandler(this.btnDisplayOrder_Click);
            // 
            // Customer_OrderList_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1250, 690);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlOrders);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer_OrderList_Form";
            this.Text = "OrderListForm";
            this.Load += new System.EventHandler(this.Customer_OrderList_Form_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOrders;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDisplayOrder;
        private System.Windows.Forms.Button btnReceiveOrder;
    }
}