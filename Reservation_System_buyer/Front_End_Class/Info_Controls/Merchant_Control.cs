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
using Front_End_Class;
using Bottom_Class1.Controller_Class;

namespace Front_End_Class
{
    public partial class Merchant_Control : UserControl
    {
        public string Merchant_Name; //店名
        public string Detail ;//店家详细信息
        public byte[] Picture;      //图片 
        public Merchant merchant;
        public Customer customer;
        public Form form;
        public Form mainForm;
        public Merchant_Control(Form form,Form mainForm,Image image)
        {
            InitializeComponent();
            pictureBox1.Image = image;
            this.form = form;
            this.mainForm = mainForm;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            form.Hide();
            new Shoping_Form(customer, merchant,mainForm).ShowDialog();
            form.Show();
        }

        private void Merchant_Control_Load(object sender, EventArgs e)
        {
            label1.Text = Merchant_Name;
            label2.Text = Detail;
            this.BackgroundImage = Image.FromFile(@"素材\白背景.jpg");
        }
    }
}
