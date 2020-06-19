using Bottom_Class;
using Front_End_Class.Order_Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bottom_Class1.Controller_Class;
using System.Data;

namespace Front_End_Class
{
    public partial class Customer_OrderList_Form : Form
    {
        Customer customer;
        List<RadioButton> radioButtons = new List<RadioButton>();
        List<Order> orders;
        public Customer_OrderList_Form(Customer customer)
        {
            InitializeComponent();

            this.customer = customer;

        }

        private void Customer_OrderList_Form_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"素材\灰背景.jpg");
            pnlOrders.BackgroundImage = Image.FromFile(@"素材\白背景.jpg");



            //获取顾客的所有订单
            orders = Customer_Service.GetAllOrders(customer.Id);
            /*Order order1 = new Order(); order1.Id = 1; order1.OrderState = "等待"; order1.OrderTime = "14:30"; order1.TotalPrice = 80;
            Cuisine cuisine = new Cuisine(); cuisine.Name = "233"; cuisine.UnitPrice = 20;
            OrderItem orderItem = new OrderItem(); orderItem.Cuisine = cuisine;
            order1.OrderItems.Add(orderItem);
            orders = new List<Order>();
            orders.Add(order1);*/

            int i = 0;
            foreach (Order order in orders)
            {
                Image image = ImageToByte.BytesToImage(order.OrderItems[0].Cuisine.Picture);
                //设置按钮

                RadioButton radioButton = new RadioButton();
                radioButton.Appearance = Appearance.Button;
                radioButton.Size = new Size(780, 100);
                radioButton.FlatStyle = FlatStyle.Flat;
                radioButton.BackgroundImage = Image.FromFile(@"素材\白背景.jpg");
                radioButton.Name = order.Id.ToString();

                //设置图片
                PictureBox pictureBox = new PictureBox();
                pictureBox.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBox.Image = ImageToByte.BytesToImage(order.OrderItems[0].Cuisine.Picture);
                pictureBox.Location = new Point(10, 10);
                pictureBox.Size = new Size(120, 80);

                //设置下单时间
                Label label1 = new Label();
                label1.Size = new Size(500, 27);
                label1.Text = "下单时间：" + order.OrderTime;
                label1.Location = new Point(170, 10);
                label1.Font = new Font("微软雅黑 Light", 10, FontStyle.Regular);

                //设置总价
                Label label2 = new Label();
                label2.Size = new Size(200, 27);
                label2.Text = "总价：" + order.OrderState;
                label2.Location = new Point(170, 60);
                label2.Font = new Font("微软雅黑 Light", 10, FontStyle.Regular);

                //设置状态
                Label label3 = new Label();
                label3.Size = new Size(300, 27);
                label3.Text = "订单状态：" + order.OrderState;
                label3.Location = new Point(460, 60);
                label3.Font = new Font("微软雅黑 Light", 10, FontStyle.Regular);


                radioButton.Controls.Add(pictureBox);
                radioButton.Controls.Add(label1);
                radioButton.Controls.Add(label2);
                radioButton.Controls.Add(label3);
                radioButton.Location = new Point(20, i * 110 + 10);
                pnlOrders.Controls.Add(radioButton);
                radioButtons.Add(radioButton);
                i++;
            }
        }

            private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            int id = 0; Order order1 = null; RadioButton radioButton1 = null;
            foreach (RadioButton radioButton in radioButtons)
            { if (radioButton.Checked == true) { radioButton1 = radioButton; id = int.Parse(radioButton.Name); } }
            foreach (Order order in orders) { if (order.Id == id) order1 = order; }
            if (order1 == null) { new Tip("请选择一个订单").ShowDialog(); return; }
            new Tip(Customer_Service.CancelOrder(order1).Result).ShowDialog();
            pnlOrders.Controls.Clear();
            this.Customer_OrderList_Form_Load(null, null);

        }

        private void btnDisplayOrder_Click(object sender, EventArgs e)
        {

            int id = 0; Order order1 = null; RadioButton radioButton1 = null;
            foreach (RadioButton radioButton in radioButtons)
            { if (radioButton.Checked == true) { radioButton1 = radioButton; id = int.Parse(radioButton.Name); } }
            foreach (Order order in orders) { if (order.Id == id) order1 = order; }
            if (order1 == null) { new Tip("请选择一个订单").ShowDialog(); return; }
            new ShoppingBasket(order1).ShowDialog();
        }

        private void btnReceiveOrder_Click(object sender, EventArgs e)
        {
            int id = 0; Order order1 = null; RadioButton radioButton1 = null;
            foreach (RadioButton radioButton in radioButtons)
            { if (radioButton.Checked == true) { radioButton1 = radioButton; id = int.Parse(radioButton.Name); } }
            foreach (Order order in orders) { if (order.Id == id) order1 = order; }
            if (order1 == null) { new Tip("请选择一个订单").ShowDialog(); return; }
            new Tip(Customer_Service.FinishOrder(order1).Result).ShowDialog();
            pnlOrders.Controls.Clear();
            this.Customer_OrderList_Form_Load(null, null);
        }

       
        }
}

