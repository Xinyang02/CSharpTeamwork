using Bottom_Class;
using System;
using System.Windows.Forms;
using 订餐系统;

namespace Front_End_Class
{
    public partial class Merchant_Form : Form
    {
        private Merchant currentMerchant;
        public Merchant_Form(Merchant merchant)
        {
            InitializeComponent();
            currentMerchant = merchant;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(changeMsg.Checked==true)
            {
                Edit_Info_Form msgForm = new Edit_Info_Form(currentMerchant);
                panel1.Controls.Clear();
                msgForm.FormBorderStyle = FormBorderStyle.None;
                msgForm.TopLevel = false;
                this.panel1.Controls.Add(msgForm);
                msgForm.Show();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddFood_CheckedChanged(object sender, EventArgs e)
        {
            if (AddFood.Checked == true)
            {
                Edit_Cuisine_Form ecf = new Edit_Cuisine_Form(currentMerchant);
                panel1.Controls.Clear();
                ecf.FormBorderStyle = FormBorderStyle.None;
                ecf.TopLevel = false;
                this.panel1.Controls.Add(ecf);
                ecf.Show();
            }
        }

        private void getOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (GetOrder.Checked == true)
            {
                Order_Forms.Form1 form1 = new Order_Forms.Form1(currentMerchant);
                //Manage_Order_Form mof = new Manage_Order_Form(currentMerchant);
                panel1.Controls.Clear();
                form1.FormBorderStyle = FormBorderStyle.None;
                form1.TopLevel = false;
                this.panel1.Controls.Add(form1);
                form1.Show();
            }
        }
    }
}
