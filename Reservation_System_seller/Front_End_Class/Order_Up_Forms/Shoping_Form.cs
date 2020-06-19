
using Bottom_Class;
using System;
using System.Windows.Forms;

namespace Front_End_Class
{
    public partial class Shoping_Form : Form
    {
        public Merchant merchant = new Merchant();
        public Order order = new Order();
       
        public Shoping_Form(Customer customer,Merchant merchant)
        {
            order.OrderState = "待支付";
            order.Customer = customer;
            this.merchant = merchant;
            merchant.CuisineTypes = Merchant_Service.getAllCuisineTypes(merchant);
            InitializeComponent();
            int i=0;
            foreach (CuisineType cuisineType in merchant.CuisineTypes)
            {
                RadioButton radioButton = new RadioButton();
                radioButton.Name = cuisineType.TypeName;
                radioButton.Text = cuisineType.TypeName;
                radioButton.Appearance = Appearance.Button;
                radioButton.SetBounds(0,100*i,180,100);
               
                i++;
            }
            
            
            
        }

        private void Cuisine_Form_Show(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked == true)
            {
                CuisineType cuisineType1=null; 
                foreach (CuisineType cuisineType in merchant.CuisineTypes) { if (radioButton.Name == cuisineType.TypeName) cuisineType1 = cuisineType; }
                Cuisine_Form cuisineForm = new Cuisine_Form(cuisineType1, order);
                ChangingPanel.Controls.Clear();
                cuisineForm.FormBorderStyle = FormBorderStyle.None;
                cuisineForm.TopLevel = false;
                this.ChangingPanel.Controls.Add(cuisineForm);
                cuisineForm.Show();
            }
        }//显示菜品界面


        private void CustomerForm_Load(object sender, EventArgs e)
        {
          
        }
       
   
        /*
        private void btnShowMerchantInfo_Click(object sender, EventArgs e)
        {
            Merchant_Info_Form merchantInfoForm = new Merchant_Info_Form();
            merchantInfoForm.ShowDialog();
        }//打开商家信息界面
        */

        private void btnSubmitFormShow(object sender, EventArgs e)
        {
            Submit_Form submitForm = new Submit_Form(order);          
            submitForm.ShowDialog();
        }//打开提交界面

        private void btnOpenShoppingBasketForm(object sender, EventArgs e)
        {

        }//打开购物篮

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReturnMainForm(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
   
}
