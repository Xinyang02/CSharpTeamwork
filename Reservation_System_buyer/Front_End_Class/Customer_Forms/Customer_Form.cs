using Bottom_Class;

using System;
using System.Drawing;
using System.Windows.Forms;


namespace Front_End_Class
{
    public partial class Customer_Form : Form
    {
        Form form;
        public Customer customer;
        bool IsDragging = false;    //当前拖拽状态
        Point p = new Point(0, 0);  //记录鼠标按下去的坐标
        Point offset = new Point(0, 0); //记录动了多少距离
        public Customer_Form(Customer customer,Form form)
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.customer = customer;
            this.form = form;
           
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
                Select_Merchant_Form select_Merchant_Form = new Select_Merchant_Form(customer,this,form);
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



   



      
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            //加载图片
            panel3.BackgroundImage = Image.FromFile(@"素材\黑背景.jpg");
            ChangingPanel.BackgroundImage = Image.FromFile(@"素材\灰背景.jpg");
            radMenu.BackgroundImage = Image.FromFile(@"素材\主页.png");
            radMy.BackgroundImage = Image.FromFile(@"素材\我的.png");
            radOrderList.BackgroundImage = Image.FromFile(@"素材\订单.png");

        }

        private void ChangingPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            //当前为拖曳状态
            IsDragging = true;
            p.X = e.X;  //记录坐标X，Y
            p.Y = e.Y; 
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            IsDragging = false;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
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

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.Close();
        }
    }
}
