using Bottom_Class;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace Front_End_Class
{
    public partial class Info_Form : Form
    {
        string name, address, phonenumber;
        Customer customer;
        public Info_Form(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;

            
            


            if (customer.Name != null)
            {
                name=txtName.Text = customer.Name;
            }
            else { name=txtName.Text = ""; }
            if (customer.Address != null)
            {
                address=txtAddress.Text = customer.Address;
            }
            else { address=txtAddress.Text = ""; }
            if (customer.PhoneNum != null)
            {
                phonenumber=txtPhoneNum.Text = customer.PhoneNum;
            }
            else {phonenumber= txtPhoneNum.Text = ""; }
          
                lblBalanceAmount.Text = ":" + customer.Balance;
          
        }

        private void CustomerInfoForm_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"素材\灰背景.jpg");
            panel1.BackgroundImage = Image.FromFile(@"素材\白背景.jpg");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //用正则表达式改成匹配
            char []number = txtPhoneNum.Text.ToCharArray();
            for (int i = 0; i < number.Length; i++)
            {
                string x = number[i].ToString();
                if (!int.TryParse(x, out int j))
                {
                    new Tip("电话号码需要为数字");
                    txtName.Text = name;txtAddress.Text = address;txtPhoneNum.Text = phonenumber;
                    return;
                }
            }
            customer.Name = txtName.Text;
            customer.Address = txtAddress.Text;
            customer.PhoneNum = txtPhoneNum.Text;
            Customer_Service.ModifyCustomer(customer);
            new Tip("保存成功").ShowDialog();





        }
    }
}
