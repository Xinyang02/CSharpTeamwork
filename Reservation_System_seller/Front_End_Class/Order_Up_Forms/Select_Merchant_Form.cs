using Bottom_Class;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Front_End_Class
{
    public partial class Select_Merchant_Form : Form
    {
        
        Customer customer;
        List<Merchant> merchants;
        public Select_Merchant_Form(Customer customer)
        {
            this.customer = customer;
            Merchant merchant1 = new Merchant();
            merchant1.Name = "KFC";
            merchant1.Info = "嫩牛五方限时折扣";

            Cuisine cuisine = new Cuisine();
            cuisine.Name = "香辣鸡腿堡";
            cuisine.UnitPrice=2;

            Cuisine cuisine1 = new Cuisine();
            cuisine.Name = "薯条";
            cuisine.UnitPrice = 4;

            CuisineType cuisineType=new CuisineType();

            merchant1.CuisineTypes.Add(cuisineType);
                
            
            Merchant merchant2 = new Merchant();
            merchant2.Name = "沙县小吃";
            merchant2.Info = "风味独特、经济实惠";


            Merchant merchant3 = new Merchant();
            merchant3.Name = "星巴克";
            merchant3.Info = "全球著名的咖啡连锁店";


            //merchants = Customer_Service.GetAllMerchants();
            //商家图片转
            int i = 0;
            foreach (Merchant merchant in merchants)
            {
                Merchant_Control control= new Merchant_Control();
                control.DataBindings.Add("Merchant_Name", merchant, "Name");
                //control.DataBindings.Add("Image", merchant, "Picture");
                control.DataBindings.Add("Detail", merchant, "Info");
                control.merchant = merchant;
                pnlMerchants.Controls.Add(control);
                control.SetBounds(0, i * 75, 267, 75);
                i++;
            }//显示所有的商家图片并进行动态绑定；
     
            
            InitializeComponent();
      
        }




        private void ShopForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

 
        private void MerchantList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
