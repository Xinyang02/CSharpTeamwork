using Reservation_system;
using System;
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
           
        }//注册

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (radCustomer.Checked == true)//当选择顾客登陆时
            {
                Customer customer = new Customer();//当前即将登陆的顾客


                if (int.TryParse(txtId.Text, out int id))
                {
                    customer = CustomerService.Login(id, txtPassword.Text);

                    if (customer == null)
                    {
                        new Tip("登陆失败").ShowDialog();
                        return;
                    }

                    new Customer_Form(customer);
                    this.Hide();

                    Close();
                }
                else
                {
                    new Tip("账号应为5位的数字").ShowDialog();
                    return;
                }
            }

            else
            { }//打开商户界面
            Close();
        }
    }//登录
}
