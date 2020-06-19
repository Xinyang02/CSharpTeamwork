using Bottom_Class;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Front_End_Class
{
    public partial class Login_Form : Form
    {
        bool IsDragging = false;    //当前拖拽状态
        Point p = new Point(0, 0);  //记录鼠标按下去的坐标
        Point offset = new Point(0, 0); //记录动了多少距离
        public Login_Form()
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

    

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new Register_Form().ShowDialog();//打开注册界面
        }//注册

        private void btnLogin_Click(object sender, EventArgs e)//点击登录按钮
        {
            Customer customer;//当前即将登陆的顾客



            if (int.TryParse(txtId.Text, out int id))
            {
                customer = Customer_Service.Login(id, txtPassword.Text);
                /*Customer customer1 = new Customer();
                customer1.Id = 10009;
                customer1.Name = "黄昌宇";
                customer1.PhoneNum = "123456789";
                customer1.Address = "武汉大学信息学部";
                customer = customer1;*/
                if (customer == null)
                {
                    new Tip("登陆失败").ShowDialog();
                    return;
                }
                customer.Orders = new List<Order>();
                Customer_Form customer_Form = new Customer_Form(customer,this);
                this.Hide();
                customer_Form.ShowDialog();//打开用户界面
                


            }
            else
            {
                //判断为五位还没写
                new Tip("账号应为5位的数字").ShowDialog();
                return;
            }
        





    }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            //当前为拖曳状态
            IsDragging = true;
            p.X = e.X;  //记录坐标X，Y
            p.Y = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            IsDragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
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

        private void Login_Form_Load(object sender, EventArgs e)
        {
            panel1.BackgroundImage = Image.FromFile(@"素材\黑背景.jpg");
            pnlOperate.BackgroundImage = Image.FromFile(@"素材\灰背景.jpg");
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }//登录
}
