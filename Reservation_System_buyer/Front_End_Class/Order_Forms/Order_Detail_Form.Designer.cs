namespace Front_End_Class.Order_Forms
{
    partial class ShoppingBasket
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
            this.pnlOrderItems = new System.Windows.Forms.Panel();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.lblOrder_Id = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTotal_Price = new System.Windows.Forms.Label();
            this.lblOrderState = new System.Windows.Forms.Label();
            this.lblOrder_State = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOrderItems
            // 
            this.pnlOrderItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlOrderItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlOrderItems.Location = new System.Drawing.Point(20, 10);
            this.pnlOrderItems.Margin = new System.Windows.Forms.Padding(0);
            this.pnlOrderItems.Name = "pnlOrderItems";
            this.pnlOrderItems.Size = new System.Drawing.Size(540, 420);
            this.pnlOrderItems.TabIndex = 0;
            this.pnlOrderItems.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOrderItems_Paint);
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(68, 281);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(52, 15);
            this.lblOrderId.TabIndex = 1;
            this.lblOrderId.Text = "订单号";
            // 
            // lblOrder_Id
            // 
            this.lblOrder_Id.AutoSize = true;
            this.lblOrder_Id.Location = new System.Drawing.Point(320, 281);
            this.lblOrder_Id.Name = "lblOrder_Id";
            this.lblOrder_Id.Size = new System.Drawing.Size(55, 15);
            this.lblOrder_Id.TabIndex = 2;
            this.lblOrder_Id.Text = "label2";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(68, 309);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(37, 15);
            this.lblTotalPrice.TabIndex = 3;
            this.lblTotalPrice.Text = "总价";
            // 
            // lblTotal_Price
            // 
            this.lblTotal_Price.AutoSize = true;
            this.lblTotal_Price.Location = new System.Drawing.Point(320, 309);
            this.lblTotal_Price.Name = "lblTotal_Price";
            this.lblTotal_Price.Size = new System.Drawing.Size(55, 15);
            this.lblTotal_Price.TabIndex = 4;
            this.lblTotal_Price.Text = "label4";
            // 
            // lblOrderState
            // 
            this.lblOrderState.AutoSize = true;
            this.lblOrderState.BackColor = System.Drawing.Color.Silver;
            this.lblOrderState.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOrderState.Location = new System.Drawing.Point(123, 443);
            this.lblOrderState.Name = "lblOrderState";
            this.lblOrderState.Size = new System.Drawing.Size(92, 27);
            this.lblOrderState.TabIndex = 5;
            this.lblOrderState.Text = "订单状态";
            // 
            // lblOrder_State
            // 
            this.lblOrder_State.AutoSize = true;
            this.lblOrder_State.BackColor = System.Drawing.Color.Silver;
            this.lblOrder_State.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOrder_State.Location = new System.Drawing.Point(343, 443);
            this.lblOrder_State.Name = "lblOrder_State";
            this.lblOrder_State.Size = new System.Drawing.Size(65, 27);
            this.lblOrder_State.TabIndex = 6;
            this.lblOrder_State.Text = "label6";
            // 
            // btnReturn
            // 
            this.btnReturn.AllowDrop = true;
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturn.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReturn.Location = new System.Drawing.Point(210, 487);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(121, 40);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.lblOrder_State);
            this.panel2.Controls.Add(this.btnReturn);
            this.panel2.Controls.Add(this.lblOrderState);
            this.panel2.Controls.Add(this.pnlOrderItems);
            this.panel2.Controls.Add(this.lblTotal_Price);
            this.panel2.Controls.Add(this.lblTotalPrice);
            this.panel2.Controls.Add(this.lblOrder_Id);
            this.panel2.Controls.Add(this.lblOrderId);
            this.panel2.Location = new System.Drawing.Point(10, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 550);
            this.panel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 600);
            this.panel1.TabIndex = 9;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.Location = new System.Drawing.Point(530, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 35);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "╳";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ShoppingBasket
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShoppingBasket";
            this.Text = "Order_Detail_Form";
            this.Load += new System.EventHandler(this.ShoppingBasket_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOrderItems;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Label lblOrder_Id;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTotal_Price;
        private System.Windows.Forms.Label lblOrderState;
        private System.Windows.Forms.Label lblOrder_State;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
    }
}