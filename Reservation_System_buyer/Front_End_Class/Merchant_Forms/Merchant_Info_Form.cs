using Bottom_Class;
using Bottom_Class1.Controller_Class;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace Front_End_Class
{
    public partial class Merchant_Info_Form : Form
    {
        Merchant merchant = new Merchant();
        bool IsDragging = false;    //当前拖拽状态
        Point p = new Point(0, 0);  //记录鼠标按下去的坐标
        Point offset = new Point(0, 0); //记录动了多少距离
        public Merchant_Info_Form(Merchant merchant)
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Merchant_Name.Text = merchant.Name;
            this.Address.Text = merchant.Address;
            this.BusinessHours.Text = merchant.BusinessHours;
            //picMerchant.Image = ImageToByte.BytesToImage(merchant.Picture);


        }

        private void MerchantForm_Load(object sender, EventArgs e)
        {
            panel3.BackgroundImage = Image.FromFile(@"素材\黑背景.jpg");
            panel2.BackgroundImage = Image.FromFile(@"素材\灰背景.jpg");
            panel1.BackgroundImage = Image.FromFile(@"素材\白背景.jpg");
        }



        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            //当前为拖曳状态
            IsDragging = true;
            p.X = e.X;  //记录坐标X，Y
            p.Y = e.Y;

        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDragging)
            {
                //距离计算：移动的坐标-鼠标按下记录的坐标
                offset.X = e.X - p.X;
                offset.Y = e.Y - p.Y;
                //控件位置
                Location = PointToScreen(offset);
            }
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            //当前为不拖曳状态
            IsDragging = false;

        }
    }
}
