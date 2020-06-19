using Bottom_Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bottom_Class1.Controller_Class;

namespace Front_End_Class.Order_Forms
{
    public partial class ShoppingBasket : Form
    {
        bool IsDragging = false;    //当前拖拽状态
        Point p = new Point(0, 0);  //记录鼠标按下去的坐标
        Point offset = new Point(0, 0); //记录动了多少距离
        public ShoppingBasket(Order order)
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            lblOrder_Id.Text = order.Id.ToString();
            lblOrder_State.Text = order.OrderState;

            lblTotal_Price.Text = order.TotalPrice.ToString();

            int i = 0;
            foreach (OrderItem orderItem in order.OrderItems)
            {
                Image image = ImageToByte.BytesToImage(orderItem.Cuisine.Picture);
                Shopping_Control control = new Shopping_Control(image);
                control.CuisineName = orderItem.Cuisine.Name;
                control.Detail = orderItem.Cuisine.Description;
                control.Amount = orderItem.Amount;
                pnlOrderItems.Controls.Add(control);
                control.SetBounds(0, i * 75, 300, 75);
                i++;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            //当前为不拖曳状态
            IsDragging = false;
        }

        private void ShoppingBasket_Load(object sender, EventArgs e)
        {
            panel1.BackgroundImage = Image.FromFile(@"素材\黑背景.jpg");
            panel2.BackgroundImage = Image.FromFile(@"素材\灰背景.jpg");
            pnlOrderItems.BackgroundImage = Image.FromFile(@"素材\白背景.jpg");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pnlOrderItems_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
