using Bottom_Class;
using System;
using System.Windows.Forms;


namespace Front_End_Class
{
    public partial class Submit_Form : Form
    {
        Order order;

        public Submit_Form(Order order )
        {
           
            this.order = order;
            InitializeComponent();
            TotalPrice.Text = order.TotalPrice.ToString();
            OrderTime.Text = order.OrderTime;
            int i = 0;
            foreach (OrderItem orderItem in order.OrderItems)
            {
                Shopping_Control control = new Shopping_Control();
                control.DataBindings.Add("CuisineName", orderItem.Cuisine, "Name");
                control.DataBindings.Add("Image", orderItem.Cuisine, "Picture");
                control.DataBindings.Add("Detail", orderItem.Cuisine, "Description");
                control.DataBindings.Add("Amount", orderItem, "Description");
                pnlOrderItemShow.Controls.Add(control);
                control.SetBounds(0, i * 75, 267, 75);
                i++;
            }

        }


            private void btnSubmit(object sender, EventArgs e)
        {

            order.OrderState = "待确认";
            Order_Service.SubmitOrder(order);
            new Tip("订单提交成功").ShowDialog();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

