using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Bottom_Class;
using Bottom_Class1.Controller_Class;

namespace Front_End_Class

{
    public partial class Cuisine_Control : UserControl
    {
        public Cuisine cuisine;
        public int Price = 0;  //价格
        public byte[] Image;  //图片
        public int Amount= 0; //菜品份数
        public Order order;
        public Cuisine_Control(Image image)
        {
            InitializeComponent();
            pictureBox1.Image = image;
        }

        private void button2_Click(object sender, EventArgs e)    //"-"号事件
        {
            int n = int.Parse(label3.Text);
            if (n <= 0)
            {
                n = 0;
            }
            else
            {
                n--;
            }
            label3.Text = "" + n;
            Amount = n;
        }
         
        private void button3_Click(object sender, EventArgs e)  //“+”号事件
        {
            int n = int.Parse(label3.Text);
            n++;
            label3.Text = "" + n;
            Amount = n;
        }

        private void button1_Click(object sender, EventArgs e)    //图片点击事件
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            label2.Text = "价格：" + Price;
            label1.Text = cuisine.Name;
        }


        private void label3_TextChanged(object sender, EventArgs e)
        {
            OrderItem orderItem1 = null; ;
            foreach (OrderItem orderItem in order.OrderItems)
            {
                if (orderItem.CuisineId == cuisine.Id)
                { orderItem1 = orderItem; }
            }

            if (label3.Text == "0")
            {
                order.OrderItems.Remove(orderItem1);

            }

            else if (orderItem1 == null)
            {
                orderItem1 = new OrderItem();
                orderItem1.CuisineId = cuisine.Id;
                orderItem1.Amount = 1;
                orderItem1.OrderId = order.Id;
                orderItem1.Cuisine = cuisine;
                order.OrderItems.Add(orderItem1);

            }
            else { orderItem1.Amount = int.Parse(label3.Text); }
        }

        private void Cuisine_Control_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
