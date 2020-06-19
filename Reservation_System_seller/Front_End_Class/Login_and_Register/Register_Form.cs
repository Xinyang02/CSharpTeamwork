using Bottom_Class;
using System;
using System.Windows.Forms;

namespace Front_End_Class
{
    public partial class Register_Form : Form
    {
        public Register_Form()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {


            if (int.TryParse(txtId.Text, out int id))
            {
                Merchant receivedmerchant = Merchant_Service.Register(id, txtPassword.Text);
                if (receivedmerchant == null)
                {
                    new Tip("注册失败，该账号已存在").ShowDialog();
                }
                new Tip("注册成功，我们去挣钱钱啦！").ShowDialog();
                this.Close();
            }
            else
            {
                //判断为五位的数字
                new Tip("账号需为5位的数字").ShowDialog();
            }
            
            
         
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void CustomerRegister_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
