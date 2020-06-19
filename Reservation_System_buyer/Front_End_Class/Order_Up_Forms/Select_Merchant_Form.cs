using Bottom_Class;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;
using Bottom_Class1.Controller_Class;

namespace Front_End_Class
{
    public partial class Select_Merchant_Form : Form
    {
        
        Customer customer;
        List<Merchant> merchants=new List<Merchant>();
  
        
        public Select_Merchant_Form(Customer customer,Form form,Form mainForm)
        {
            InitializeComponent();

            this.customer = customer;
            /*Merchant merchant1 = new Merchant();
            merchant1.Name = "KFC";
            merchant1.Info = "嫩牛五方限时折扣";

            Cuisine cuisine = new Cuisine();
            cuisine.Id = 1;
            cuisine.Name = "香辣鸡腿堡";
            cuisine.UnitPrice=7;

            Cuisine cuisine1 = new Cuisine();
            cuisine1.Id = 2;
            cuisine1.Name = "新奥尔良鸡腿堡";
            cuisine1.UnitPrice = 8;

            Cuisine cuisine2 = new Cuisine();
            cuisine1.Id = 3;
            cuisine1.Name = "牛肉堡";
            cuisine1.UnitPrice = 7;

            Cuisine cuisine3 = new Cuisine();
            cuisine1.Id = 4;
            cuisine1.Name = "双层牛肉堡";
            cuisine1.UnitPrice = 10;

            Cuisine cuisine4 = new Cuisine();
            cuisine1.Id = 5;
            cuisine1.Name = "双层鸡腿堡";
            cuisine1.UnitPrice = 11;

            Cuisine cuisine5 = new Cuisine();
            cuisine1.Id = 6;
            cuisine1.Name = "菌菇堡";
            cuisine1.UnitPrice = 6;

            CuisineType cuisineType=new CuisineType();
            cuisineType.TypeName = "汉堡";
            cuisineType.Cuisines.Add(cuisine1);
            cuisineType.Cuisines.Add(cuisine);

            merchant1.CuisineTypes.Add(cuisineType);

            CuisineType cuisineType1 = new CuisineType();
            cuisineType.TypeName = "鸡肉卷";

            CuisineType cuisineType2 = new CuisineType();
            cuisineType.TypeName = "薯条";
            CuisineType cuisineType3 = new CuisineType();
            cuisineType.TypeName = "饮料";
            CuisineType cuisineType4 = new CuisineType();
            cuisineType.TypeName = "小吃";
            merchant1.CuisineTypes.Add(cuisineType1);
            merchant1.CuisineTypes.Add(cuisineType2); 
            merchant1.CuisineTypes.Add(cuisineType3);
            merchant1.CuisineTypes.Add(cuisineType4);




            Merchant merchant2 = new Merchant();
            merchant2.Name = "沙县小吃";
            merchant2.Info = "风味独特、经济实惠";


            Merchant merchant3 = new Merchant();
            merchant3.Name = "星巴克";
            merchant3.Info = "全球著名的咖啡连锁店";

            Merchant merchant4 = new Merchant();
            merchant3.Name = "撤硕";
            merchant3.Info = "老八蜜汁";

            Merchant merchant5 = new Merchant();
            merchant3.Name = "汉堡王";
            merchant3.Info = "最正宗的美式汉堡";

            Merchant merchant6 = new Merchant();
            merchant3.Name = "烤肉之家";
            merchant3.Info = "尽情享受烤肉之旅";

            Merchant merchant7 = new Merchant();
            merchant3.Name = "农家餐厅";
            merchant3.Info = "农家炒菜";

            merchants.Add(merchant1);
            merchants.Add(merchant2);
            merchants.Add(merchant3);
            merchants.Add(merchant4);
            merchants.Add(merchant5);
            merchants.Add(merchant6); 
            merchants.Add(merchant7);*/
            merchants = Customer_Service.GetAllMerchants();

            int i = 0;
        
            foreach (Merchant merchant in merchants)
            {
                Image image = ImageToByte.BytesToImage(merchant.Picture);
                Merchant_Control control = new Merchant_Control(form, mainForm,image);
                control.Merchant_Name = merchant.Name;
                control.Detail = merchant.Info;
                control.merchant = merchant;
                control.customer = customer;
                control.Location = new Point(20, 90 * i + 10);
                pnlMerchant.Controls.Add(control);
                
                i++;
            }
     
            
            
      
        }




        private void ShopForm_Load(object sender, EventArgs e)
        {
            pnlMerchant.BackgroundImage = Image.FromFile(@"素材\灰背景.jpg");
        }

        private void pnlMerchant_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
