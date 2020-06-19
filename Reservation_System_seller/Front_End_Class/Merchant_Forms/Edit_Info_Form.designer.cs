namespace Front_End_Class
{
    partial class Edit_Info_Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Info_Form));
			this.button1 = new System.Windows.Forms.Button();
			this.MerchantName = new System.Windows.Forms.TextBox();
			this.MerchantAddress = new System.Windows.Forms.TextBox();
			this.BusinessHours = new System.Windows.Forms.TextBox();
			this.MerchantPhone = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.path = new System.Windows.Forms.TextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(320, 448);
			this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(235, 34);
			this.button1.TabIndex = 4;
			this.button1.Text = "确认修改";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// MerchantName
			// 
			this.MerchantName.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.MerchantName.Location = new System.Drawing.Point(387, 78);
			this.MerchantName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.MerchantName.Name = "MerchantName";
			this.MerchantName.Size = new System.Drawing.Size(308, 41);
			this.MerchantName.TabIndex = 5;
			// 
			// MerchantAddress
			// 
			this.MerchantAddress.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.MerchantAddress.Location = new System.Drawing.Point(387, 157);
			this.MerchantAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.MerchantAddress.Name = "MerchantAddress";
			this.MerchantAddress.Size = new System.Drawing.Size(308, 41);
			this.MerchantAddress.TabIndex = 6;
			// 
			// BusinessHours
			// 
			this.BusinessHours.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.BusinessHours.Location = new System.Drawing.Point(387, 239);
			this.BusinessHours.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.BusinessHours.Name = "BusinessHours";
			this.BusinessHours.Size = new System.Drawing.Size(308, 41);
			this.BusinessHours.TabIndex = 7;
			// 
			// MerchantPhone
			// 
			this.MerchantPhone.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.MerchantPhone.Location = new System.Drawing.Point(387, 310);
			this.MerchantPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.MerchantPhone.Name = "MerchantPhone";
			this.MerchantPhone.Size = new System.Drawing.Size(308, 41);
			this.MerchantPhone.TabIndex = 8;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(744, 404);
			this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(26, 18);
			this.button2.TabIndex = 12;
			this.button2.Text = "...";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// path
			// 
			this.path.Location = new System.Drawing.Point(387, 401);
			this.path.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.path.Name = "path";
			this.path.Size = new System.Drawing.Size(308, 21);
			this.path.TabIndex = 13;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// Edit_Info_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(913, 502);
			this.Controls.Add(this.path);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.MerchantPhone);
			this.Controls.Add(this.BusinessHours);
			this.Controls.Add(this.MerchantAddress);
			this.Controls.Add(this.MerchantName);
			this.Controls.Add(this.button1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Edit_Info_Form";
			this.Text = "MsgForm";
			this.Load += new System.EventHandler(this.ChangeMsgForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox MerchantName;
        private System.Windows.Forms.TextBox MerchantAddress;
        private System.Windows.Forms.TextBox BusinessHours;
        private System.Windows.Forms.TextBox MerchantPhone;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}