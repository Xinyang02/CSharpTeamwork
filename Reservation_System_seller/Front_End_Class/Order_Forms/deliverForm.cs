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
    public partial class deliverForm : Form
    {
        private Merchant currentMerchant;
        public deliverForm(Merchant merchant)
        {
            this.currentMerchant = merchant;
            bindingSource1 = new BindingSource();
            InitializeComponent();
            bindingSource1.DataSource = Order_Service.GetDeliverOrderList(currentMerchant);
            //typeBindingSource.DataSource = currentMerchant.CuisineTypes;
            bindingSource1.ResetBindings(false);
            bindingSource2.DataSource = bindingSource1.Current;
            //orderList = Order_Service.GetOrderList();
        }

        private void deliverForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentCell.RowIndex>=0)
            {
                Merchant_Service.finishDeliver(Order_Service.GetDeliverOrderList(currentMerchant)[dataGridView1.CurrentCell.RowIndex]);
            }
            
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            bindingSource2.DataSource = Order_Service.GetDeliverOrderList(currentMerchant)[dataGridView1.CurrentCell.RowIndex].OrderItems;
            bindingSource2.ResetBindings(false);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
