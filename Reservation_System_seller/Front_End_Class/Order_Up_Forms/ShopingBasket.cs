using Bottom_Class;
using System;
using System.Windows.Forms;

namespace Front_End_Class
{
    public partial class Shopping_Basket_Form : Form
    {

        public Shopping_Basket_Form(Order order)
        {
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



        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
