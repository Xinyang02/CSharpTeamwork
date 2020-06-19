namespace Front_End_Class
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.pnlOperate = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.pnlOperate.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOperate
            // 
            this.pnlOperate.Controls.Add(this.btnRegister);
            this.pnlOperate.Controls.Add(this.btnLogin);
            this.pnlOperate.Controls.Add(this.txtPassword);
            this.pnlOperate.Controls.Add(this.lblPassword);
            this.pnlOperate.Controls.Add(this.txtId);
            this.pnlOperate.Controls.Add(this.lblId);
            this.pnlOperate.Location = new System.Drawing.Point(12, 109);
            this.pnlOperate.Name = "pnlOperate";
            this.pnlOperate.Size = new System.Drawing.Size(455, 250);
            this.pnlOperate.TabIndex = 0;
            this.pnlOperate.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOperate_Paint);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(275, 195);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(88, 36);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "注册";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(63, 195);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(89, 36);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(123, 125);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(240, 25);
            this.txtPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(60, 128);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(37, 15);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "密码";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(123, 64);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(240, 25);
            this.txtId.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(60, 67);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(37, 15);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "账号";
            // 
            // pnlImage
            // 
            this.pnlImage.Location = new System.Drawing.Point(12, 2);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(455, 101);
            this.pnlImage.TabIndex = 1;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 371);
            this.Controls.Add(this.pnlImage);
            this.Controls.Add(this.pnlOperate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "订餐系统";
            this.pnlOperate.ResumeLayout(false);
            this.pnlOperate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOperate;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Panel pnlImage;
    }
}