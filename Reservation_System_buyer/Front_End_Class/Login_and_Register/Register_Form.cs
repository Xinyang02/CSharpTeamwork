using Bottom_Class;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Front_End_Class
{
    public partial class Register_Form : Form
    {
        bool IsDragging = false;    //当前拖拽状态
        Point p = new Point(0, 0);  //记录鼠标按下去的坐标
        Point offset = new Point(0, 0); //记录动了多少距离
        public Register_Form()
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
                if (int.TryParse(txtId.Text, out int id))
                {
                    Customer receivedcustomer = Customer_Service.Register(id, txtPassword.Text);
                    if (receivedcustomer == null)
                    {
                        new Tip("注册失败").ShowDialog();
                    }
                    new Tip("注册成功").ShowDialog();
                }
                else
                {
                    //判断为五位的数字
                    new Tip("账号需为5位的数字").ShowDialog();
                }
      
         
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            panel2.BackgroundImage = Image.FromFile(@"素材\黑背景.jpg");
            panel1.BackgroundImage = Image.FromFile(@"素材\灰背景.jpg");
        }

        private void CustomerRegister_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            //当前为拖曳状态
            IsDragging = true;
            p.X = e.X;  //记录坐标X，Y
            p.Y = e.Y;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
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

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            IsDragging = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
