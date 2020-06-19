using Bottom_Class;

using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace 订餐系统
{
    public partial class Manage_Order_Form : Form
    {
        private Merchant currentMerchant;
        public Manage_Order_Form(Merchant merchant)
        {
            this.currentMerchant = merchant;
            bindingSource1 = new BindingSource();
            InitializeComponent();
            bindingSource1.DataSource = Order_Service.GetOrderList(currentMerchant);
            //typeBindingSource.DataSource = currentMerchant.CuisineTypes;
            bindingSource1.ResetBindings(false);
            
            //orderList = Order_Service.GetOrderList();

        }
        
        private List<Order> orderList;
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GetOrderForm_Load(object sender, EventArgs e)
        {

        }
        /*
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            orderItemBindingSource.DataSource = Order_Service.GetOrderList()[dataGridView1.CurrentCell.RowIndex];
            
            orderItemBindingSource.ResetBindings(false);
        }
        */
        private void Manage_Order_Form_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void acceptOrder_Click(object sender, EventArgs e)
        {
            Merchant_Service.takeAnOrder(Order_Service.GetOrderList(currentMerchant)[dataGridView3.CurrentCell.RowIndex]);
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_MouseClick(object sender, MouseEventArgs e)
        {
            bindingSource2.DataSource = Order_Service.GetOrderList(currentMerchant)[dataGridView3.CurrentCell.RowIndex].OrderItems;
            bindingSource2.ResetBindings(false);
        }

        private void bindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
