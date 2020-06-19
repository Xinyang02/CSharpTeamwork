using Bottom_Class;
using System;
using System.IO;
using System.Windows.Forms;


namespace Front_End_Class
{
    public partial class Merchant_Info_Form : Form
    {
        
        public Merchant_Info_Form(string address,string name,string phone,string time,string path)
        {
            InitializeComponent();
            this.Address.Text = address;
            this.Name.Text = name;
            this.Phone.Text = phone;
            this.Time.Text = time;
            this.pictureBox1.Load(path);
            


        }

        private void MerchantForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
