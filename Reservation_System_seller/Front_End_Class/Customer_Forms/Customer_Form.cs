using Bottom_Class;

using System;
using System.Windows.Forms;


namespace Front_End_Class
{
    public partial class Customer_Form : Form
    {
        public Customer customer;
        public Customer_Form(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
        }

        private void btnInfo_Form_Show(object sender, EventArgs e)
        {
            if (radMy.Checked == true)
            {
                Info_Form customerInfoForm = new Info_Form(customer);
                ChangingPanel.Controls.Clear();
                customerInfoForm.FormBorderStyle = FormBorderStyle.None;
                customerInfoForm.TopLevel = false;
                this.ChangingPanel.Controls.Add(customerInfoForm);
                customerInfoForm.Show();
            }
        }//显示我的信息
    
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (radMenu.Checked == true)
            {
                Select_Merchant_Form select_Merchant_Form = new Select_Merchant_Form(customer);
                ChangingPanel.Controls.Clear();
                select_Merchant_Form.FormBorderStyle = FormBorderStyle.None;
                select_Merchant_Form.TopLevel = false;
                this.ChangingPanel.Controls.Add(select_Merchant_Form);
                select_Merchant_Form.Show();
            }
            
        }//显示店铺

        private void radOrderList_Click(object sender, EventArgs e)
        {
            if (radOrderList.Checked == true)
            {
                Customer_OrderList_Form customer_OrderList_Form = new Customer_OrderList_Form(customer);
                ChangingPanel.Controls.Clear();
                customer_OrderList_Form.FormBorderStyle = FormBorderStyle.None;
                customer_OrderList_Form.TopLevel = false;
                this.ChangingPanel.Controls.Add(customer_OrderList_Form);
                customer_OrderList_Form.Show();
            }
        }



        private void btnHide_Click(object sender, EventArgs e)
        {
            Hide();
        }//隐藏界面

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }//关闭界面

      
        
        private void MainForm_Load(object sender, EventArgs e)
        {

        }




    }
}
