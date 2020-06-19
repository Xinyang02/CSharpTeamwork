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

namespace Front_End_Class

{
    public partial class Cuisine_Control : UserControl
    {
        public string CuisineName = "菜名"; //菜名
        public int Price = 0;  //价格
        public byte[] Image;  //图片
        public int Amount= 1; //菜品份数
        public Cuisine_Control()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 将byte[]输出为图片
        /// </summary>
        /// <param name="path">输出图片的路径及名称</param>
        /// <param name="picByte">byte[]数组存放的图片数据</param>
        public void Write(string path, byte[] picByte)    //把byte数组重新转换为图片文件
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            //开始写入
            bw.Write(picByte, 0, picByte.Length);
            //关闭流
            bw.Close();
            fs.Close();
        }
        private void button2_Click(object sender, EventArgs e)    //"-"号事件
        {
            int n = int.Parse(textBox1.Text);
            if (n <= 0)
            {
                n = 0;
            }
            else
            {
                n--;
            }
            textBox1.Text = "" + n;
            Amount = n;
        }
         
        private void button3_Click(object sender, EventArgs e)  //“+”号事件
        {
            int n = int.Parse(textBox1.Text);
            n++;
            textBox1.Text = "" + n;
            Amount = n;
        }

        private void button1_Click(object sender, EventArgs e)    //图片点击事件
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            label2.Text = "价格：" + Price;
            label1.Text = Name;
        }
    }
}
