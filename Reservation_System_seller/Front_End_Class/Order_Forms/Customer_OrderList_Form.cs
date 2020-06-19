using Bottom_Class;
using System;
using System.Windows.Forms;

namespace Front_End_Class
{
    public partial class Customer_OrderList_Form : Form
    {
        Customer customer;
        public Customer_OrderList_Form(Customer customer)
        {
            InitializeComponent();
            int i = 0;
            this.customer = customer;


            //获取顾客的所有订单
            //OrderService.GetOrderList();





            foreach (Order order in customer.Orders)
            {
                Button button = new Button();
                panel1.Controls.Add(button);
                button.SetBounds(0, 100 * i, 200, 100);
                button.Click += new EventHandler(this.OrderDisplay);
                button.Name = order.Id.ToString();
            }
        }
        private void OrderDisplay(object sender, EventArgs e)
        {
            foreach (Order order in customer.Orders)
            {
                Button button = (Button)sender;
                if (button.Name == order.Id.ToString())
                {
                    //new Submit_Form.OrderDisplayForm(order);
                }
            }

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            
        }
    }
}
