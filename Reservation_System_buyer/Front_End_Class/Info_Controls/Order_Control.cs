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
using Bottom_Class1.Controller_Class;

namespace Front_End_Class

{
    public partial class Order_Control : UserControl
    {
        public bool Checked = false;
        public byte[] Picture;
        public int totalPrice = 0;
        public string State = "";
        public string Time = "";
        public Order_Control(Image image)
        {
            InitializeComponent();
            pictureBox1.Image = image;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            label2.Text = "下单时间：" + Time;
            label3.Text = "总价：" + totalPrice;
            label4.Text = "状态：" + State;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            radioButton.Checked = this.Checked;
        }

        private void Order_Control_Load(object sender, EventArgs e)
        {
            radioButton1.BackgroundImage = Image.FromFile(@"素材\白背景.jpg");
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
