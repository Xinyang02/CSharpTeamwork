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
    public partial class Shopping_Control : UserControl
    {
        public byte[] Picture;  //图片
        public string CuisineName = "菜名"; //菜名
        public string Detail = "详细"; //详细信息
        public int Amount = 1; //菜品份数
        public Shopping_Control(Image image)
        {
            InitializeComponent();
            pictureBox1.Image = image;
        }
     
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            label2.Text = CuisineName;
            label3.Text = "×" + Amount;
        }

        private void Shopping_Control_Load(object sender, EventArgs e)
        {
            panel1.BackgroundImage = Image.FromFile(@"素材\白背景.jpg");
        }
    }
}
