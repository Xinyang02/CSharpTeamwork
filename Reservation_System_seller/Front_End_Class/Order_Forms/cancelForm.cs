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
    public partial class cancelForm : Form
    {
        private Merchant currentMerchant;
        public cancelForm(Merchant merchant)
        {
            this.currentMerchant = merchant;
            bindingSource1 = new BindingSource();
            InitializeComponent();
            bindingSource1.DataSource = Order_Service.GetWaitCancelOrderList(currentMerchant);
            //typeBindingSource.DataSource = currentMerchant.CuisineTypes;
            bindingSource1.ResetBindings(false);
            bindingSource2.DataSource = bindingSource1.Current;
            //orderList = Order_Service.GetOrderList();
        }

        private void cancelForm_Load(object sender, EventArgs e)
        {

        }
    }
}
