namespace Front_End_Class.Order_Forms
{
    partial class Order_Detail_Form
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
            this.lblOrderId = new System.Windows.Forms.Label();
            this.lblOrder_Id = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTotal_Price = new System.Windows.Forms.Label();
            this.lblOrderState = new System.Windows.Forms.Label();
            this.lblOrder_State = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(8, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 246);
            this.panel1.TabIndex = 0;
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(107, 264);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(52, 15);
            this.lblOrderId.TabIndex = 1;
            this.lblOrderId.Text = "订单号";
            // 
            // lblOrder_Id
            // 
            this.lblOrder_Id.AutoSize = true;
            this.lblOrder_Id.Location = new System.Drawing.Point(295, 264);
            this.lblOrder_Id.Name = "lblOrder_Id";
            this.lblOrder_Id.Size = new System.Drawing.Size(55, 15);
            this.lblOrder_Id.TabIndex = 2;
            this.lblOrder_Id.Text = "label2";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(107, 297);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(37, 15);
            this.lblTotalPrice.TabIndex = 3;
            this.lblTotalPrice.Text = "总价";
            // 
            // lblTotal_Price
            // 
            this.lblTotal_Price.AutoSize = true;
            this.lblTotal_Price.Location = new System.Drawing.Point(295, 297);
            this.lblTotal_Price.Name = "lblTotal_Price";
            this.lblTotal_Price.Size = new System.Drawing.Size(55, 15);
            this.lblTotal_Price.TabIndex = 4;
            this.lblTotal_Price.Text = "label4";
            // 
            // lblOrderState
            // 
            this.lblOrderState.AutoSize = true;
            this.lblOrderState.Location = new System.Drawing.Point(107, 325);
            this.lblOrderState.Name = "lblOrderState";
            this.lblOrderState.Size = new System.Drawing.Size(67, 15);
            this.lblOrderState.TabIndex = 5;
            this.lblOrderState.Text = "订单状态";
            // 
            // lblOrder_State
            // 
            this.lblOrder_State.AutoSize = true;
            this.lblOrder_State.Location = new System.Drawing.Point(295, 325);
            this.lblOrder_State.Name = "lblOrder_State";
            this.lblOrder_State.Size = new System.Drawing.Size(55, 15);
            this.lblOrder_State.TabIndex = 6;
            this.lblOrder_State.Text = "label6";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(163, 373);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(121, 40);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // Order_Detail_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 439);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblOrder_State);
            this.Controls.Add(this.lblOrderState);
            this.Controls.Add(this.lblTotal_Price);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblOrder_Id);
            this.Controls.Add(this.lblOrderId);
            this.Controls.Add(this.panel1);
            this.Name = "Order_Detail_Form";
            this.Text = "Order_Detail_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Label lblOrder_Id;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTotal_Price;
        private System.Windows.Forms.Label lblOrderState;
        private System.Windows.Forms.Label lblOrder_State;
        private System.Windows.Forms.Button btnReturn;
    }
}