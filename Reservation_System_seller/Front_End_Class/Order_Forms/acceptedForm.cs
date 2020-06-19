using Bottom_Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front_End_Class.Order_Forms
{
    public partial class acceptedForm : Form
    {
        private Merchant currentMerchant;
        public acceptedForm(Merchant merchant)
        {
            this.currentMerchant = merchant;
            bindingSource1 = new BindingSource();
            InitializeComponent();
            bindingSource1.DataSource = Order_Service.GetAcceptedOrderList(currentMerchant);
            //typeBindingSource.DataSource = currentMerchant.CuisineTypes;
            bindingSource1.ResetBindings(false);
            bindingSource2.DataSource = bindingSource1.Current;
            //orderList = Order_Service.GetOrderList();
        }

        private void acceptedForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Merchant_Service.finishMake(Order_Service.GetAcceptedOrderList(currentMerchant)[dataGridView1.CurrentCell.RowIndex]);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            bindingSource2.DataSource = Order_Service.GetAcceptedOrderList(currentMerchant)[dataGridView1.CurrentCell.RowIndex].OrderItems;
            bindingSource2.ResetBindings(false);
        }
    }
}
