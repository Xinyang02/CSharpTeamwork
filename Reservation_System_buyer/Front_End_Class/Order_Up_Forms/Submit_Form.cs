using Bottom_Class;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace Front_End_Class
{
    public partial class Submit_Form : Form
    {
        Order order;
        bool IsDragging = false;    //当前拖拽状态
        Point p = new Point(0, 0);  //记录鼠标按下去的坐标
        Point offset = new Point(0, 0); //记录动了多少距离

        public Submit_Form(Order order )
        {
           
            this.order = order;
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            order.TotalPrice = 0;
            foreach (OrderItem orderItem1 in order.OrderItems)
            {
                order.TotalPrice += orderItem1.Amount * orderItem1.Cuisine.UnitPrice;
            }
            order.OrderTime = DateTime.Now.ToString();


            lblTotalPrice.Text = order.TotalPrice.ToString();
            OrderTime.Text = order.OrderTime;
            Customer_Name.Text = order.Customer.Name;
            Address.Text = order.Customer.Address;
            PhoneNumber.Text = order.Customer.PhoneNum;



        }


            private void btnSubmit(object sender, EventArgs e)
        {
            new Tip(Customer_Service.AddOrder(order).Result).ShowDialog();
            Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnShoppingBasket_Click(object sender, EventArgs e)
        {
            new Shopping_Basket_Form(order).ShowDialog();
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
            //当前为不拖曳状态
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Form_Load(object sender, EventArgs e)
        {
            panel2.BackgroundImage = Image.FromFile(@"素材\黑背景.jpg");
            panel1.BackgroundImage = Image.FromFile(@"素材\灰背景.jpg");
            panel3.BackgroundImage = Image.FromFile(@"素材\白背景.jpg");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

