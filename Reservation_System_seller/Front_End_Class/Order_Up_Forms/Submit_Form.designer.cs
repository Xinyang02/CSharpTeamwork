namespace Front_End_Class
{
    partial class Submit_Form
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
            this.btnSumbit = new System.Windows.Forms.Button();
            this.pnlOrderItemShow = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.OrderTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Customer_Name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Note = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSumbit
            // 
            this.btnSumbit.Location = new System.Drawing.Point(119, 372);
            this.btnSumbit.Name = "btnSumbit";
            this.btnSumbit.Size = new System.Drawing.Size(96, 49);
            this.btnSumbit.TabIndex = 0;
            this.btnSumbit.Text = "提交";
            this.btnSumbit.UseVisualStyleBackColor = true;
            this.btnSumbit.Click += new System.EventHandler(this.btnSubmit);
            // 
            // pnlOrderItemShow
            // 
            this.pnlOrderItemShow.Location = new System.Drawing.Point(301, 12);
            this.pnlOrderItemShow.Name = "pnlOrderItemShow";
            this.pnlOrderItemShow.Size = new System.Drawing.Size(260, 340);
            this.pnlOrderItemShow.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "总价";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "下单时间";
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSize = true;
            this.TotalPrice.Location = new System.Drawing.Point(208, 28);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(55, 15);
            this.TotalPrice.TabIndex = 5;
            this.TotalPrice.Text = "label3";
            // 
            // OrderTime
            // 
            this.OrderTime.AutoSize = true;
            this.OrderTime.Location = new System.Drawing.Point(208, 64);
            this.OrderTime.Name = "OrderTime";
            this.OrderTime.Size = new System.Drawing.Size(55, 15);
            this.OrderTime.TabIndex = 6;
            this.OrderTime.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "姓名";
            // 
            // Customer_Name
            // 
            this.Customer_Name.AutoSize = true;
            this.Customer_Name.Location = new System.Drawing.Point(189, 100);
            this.Customer_Name.Name = "Customer_Name";
            this.Customer_Name.Size = new System.Drawing.Size(87, 15);
            this.Customer_Name.TabIndex = 8;
            this.Customer_Name.Text = "SubmitForm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "住址";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(208, 135);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(55, 15);
            this.Address.TabIndex = 10;
            this.Address.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "联系方式";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Location = new System.Drawing.Point(208, 171);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(55, 15);
            this.PhoneNumber.TabIndex = 12;
            this.PhoneNumber.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "备注信息";
            // 
            // Note
            // 
            this.Note.Location = new System.Drawing.Point(60, 234);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(108, 25);
            this.Note.TabIndex = 14;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(326, 372);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(96, 49);
            this.btnReturn.TabIndex = 15;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // Submit_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(577, 445);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Customer_Name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OrderTime);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlOrderItemShow);
            this.Controls.Add(this.btnSumbit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Submit_Form";
            this.Text = "SubmitForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSumbit;
        private System.Windows.Forms.Panel pnlOrderItemShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TotalPrice;
        private System.Windows.Forms.Label OrderTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Customer_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Note;
        private System.Windows.Forms.Button btnReturn;
    }
}