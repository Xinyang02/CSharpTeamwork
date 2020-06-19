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


namespace Front_End_Class
{
    public partial class Merchant_Control : UserControl
    {
        public string Merchant_Name = ""; //店名
        public string Detail = "";//店家详细信息
        public byte[] Image;      //图片 
        public Merchant merchant;
        public Customer customer;
        public Merchant_Control()
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
       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            label1.Text = Name;
            label2.Text = Detail;
            //label3.Image=
        }
     

        private void btnEnter_Merchant_Click(object sender, EventArgs e)
        {
            new Shoping_Form(customer, merchant).ShowDialog();
        }
    }
}
