
using Bottom_Class;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Front_End_Class
{
    public partial class Shoping_Form : Form
    {
        public Merchant merchant = new Merchant();
        public Order order = new Order();
        Form form;
        
        bool IsDragging = false;    //当前拖拽状态
        Point p = new Point(0, 0);  //记录鼠标按下去的坐标
        Point offset = new Point(0, 0); //记录动了多少距离
        public Shoping_Form(Customer customer,Merchant merchant,Form mainForm)
        {
            form = mainForm;
            order.Customer = customer;
            this.merchant = merchant;
            order.MerchantId = merchant.Id;
            
            merchant.CuisineTypes = Merchant_Service.getAllCuisineTypes(merchant);
            InitializeComponent();
            int i=0;
            foreach (CuisineType cuisineType in merchant.CuisineTypes)
            {
                RadioButton radioButton = new RadioButton();
                radioButton.Name = cuisineType.TypeName;
                radioButton.Text = cuisineType.TypeName;
                radioButton.Appearance = Appearance.Button;
                radioButton.SetBounds(5, 60 * i+5, 120, 60);
                radioButton.Font = new Font("微软雅黑 Light", 12, FontStyle.Regular);
                radioButton.TextAlign = ContentAlignment.MiddleCenter;
                pnlCuisineType.Controls.Add(radioButton);
                radioButton.Click += new EventHandler(Cuisine_Form_Show);
                i++;
            }

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

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
            panel2.BackgroundImage = Image.FromFile(@"素材\黑背景.jpg");
            panel1.BackgroundImage = Image.FromFile(@"素材\灰背景.jpg");
            pnlCuisineType.BackgroundImage = Image.FromFile(@"素材\白背景.jpg");
            ChangingPanel.BackgroundImage = Image.FromFile(@"素材\白背景.jpg");
            btnOpenShoppingBasket.BackgroundImage = Image.FromFile(@"素材\购物车.png");
            btnShowMerchantInfo.BackgroundImage = Image.FromFile(@"素材\店家.png");
            btnSubmit.BackgroundImage = Image.FromFile(@"素材\提交.png");
            ReturnToMainForm.BackgroundImage = Image.FromFile(@"素材\返回.png");
        }
       
   
        private void btnShowMerchantInfo_Click(object sender, EventArgs e)
        {
            Merchant_Info_Form merchantInfoForm = new Merchant_Info_Form(merchant);
            merchantInfoForm.ShowDialog();
        }//打开商家信息界面

        private void btnSubmitFormShow(object sender, EventArgs e)
        {
            Submit_Form submitForm = new Submit_Form(order);          
            submitForm.ShowDialog();
        }//打开提交界面

        private void btnOpenShoppingBasketForm(object sender, EventArgs e)
        {
            new Shopping_Basket_Form(order).ShowDialog();
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

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            //当前为拖曳状态
            IsDragging = true;
            p.X = e.X;  //记录坐标X，Y
            p.Y = e.Y; 
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            IsDragging = false;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDragging)
            {
                //距离计算：移动的坐标-鼠标按下记录的坐标
                offset.X = e.X - p.X;
                offset.Y = e.Y - p.Y;
                //控件位置
                Location = PointToScreen(offset);
            }
        }

        private void ChangingPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            form.Close();
        }
    }
   
}
