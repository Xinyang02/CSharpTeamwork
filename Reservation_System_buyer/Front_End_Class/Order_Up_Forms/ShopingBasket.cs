using Bottom_Class;
using System;
using System.Drawing;
using System.Windows.Forms;
using Bottom_Class1.Controller_Class;

namespace Front_End_Class
{
    public partial class Shopping_Basket_Form : Form
    {
        bool IsDragging = false;    //当前拖拽状态
        Point p = new Point(0, 0);  //记录鼠标按下去的坐标
        Point offset = new Point(0, 0); //记录动了多少距离
        public Shopping_Basket_Form(Order order)
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            int totalprice=0;
            foreach (OrderItem orderItem1 in order.OrderItems)
            {
                totalprice += orderItem1.Amount * orderItem1.Cuisine.UnitPrice;

                
            }
            lblTotalPrice.Text = totalprice.ToString();
            
            int i = 0;
            foreach (OrderItem orderItem in order.OrderItems)
            {
                Image image = ImageToByte.BytesToImage(orderItem.Cuisine.Picture);
                Shopping_Control control = new Shopping_Control(image);
                control.CuisineName = orderItem.Cuisine.Name;
                control.Detail=orderItem.Cuisine.Description;
                control.Amount=orderItem.Amount;
                pnlOrderItemShow.Controls.Add(control);
                control.SetBounds(0, i * 75, 300, 75);
                control.Location = new Point(10, i * 80 + 10);
                i++;
            }
        }



        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
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

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            //当前为不拖曳状态
            IsDragging = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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

        private void Shopping_Basket_Form_Load(object sender, EventArgs e)
        {
            panel2.BackgroundImage = Image.FromFile(@"素材\黑背景.jpg");
            panel1.BackgroundImage = Image.FromFile(@"素材\灰背景.jpg");
            pnlOrderItemShow.BackgroundImage = Image.FromFile(@"素材\白背景.jpg");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pnlOrderItemShow_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
