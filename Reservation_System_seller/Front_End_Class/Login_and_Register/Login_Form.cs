using Bottom_Class;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Front_End_Class
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

    

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register_Form rf = new Register_Form();
            rf.FormBorderStyle = FormBorderStyle.FixedSingle;
            rf.StartPosition = FormStartPosition.CenterScreen;
            rf.ShowDialog();//打开注册界面
        }//注册

        private void btnLogin_Click(object sender, EventArgs e)//点击登录按钮
        {
           
                Merchant merchant;//当前即将登陆的商家


                if (int.TryParse(txtId.Text, out int id))
                {
                    merchant = Merchant_Service.Login(id, txtPassword.Text);

                    if (merchant == null)
                    {
                        new Tip("登陆失败").ShowDialog();
                        return;
                    }

                    new Merchant_Form(merchant).Show();//打开商家界面
                    this.Hide();

                }
                else
                {
                    //判断为五位还没写
                    new Tip("账号应为5位的数字").ShowDialog();
                    return;
                }

            
        }

        private void pnlOperate_Paint(object sender, PaintEventArgs e)
        {

        }
    }//登录
}
