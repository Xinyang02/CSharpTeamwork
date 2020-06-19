using Bottom_Class;
using System;
using System.Drawing;
using System.Windows.Forms;
using Bottom_Class1.Controller_Class;

namespace Front_End_Class
{
    public partial class Cuisine_Form : Form
    { 




        public Cuisine_Form(CuisineType cuisineType,Order order)
        {

            InitializeComponent();
            int i=0;
            foreach (Cuisine cuisine in cuisineType.Cuisines)
            {
                Image image = ImageToByte.BytesToImage(cuisine.Picture);
                Cuisine_Control control = new Cuisine_Control(image);
                control.order = order;
                control.cuisine = cuisine;
                control.Price=cuisine.UnitPrice;
                pnlShowCuisine.Controls.Add(control);
                control.Location = new Point(10, i * 95 + 10);
                i++;
            }//显示所有的商家图片并进行动态绑定；





           
            
        }

        private void CuisineForm_Load(object sender, EventArgs e)
        {

            pnlShowCuisine.BackgroundImage = Image.FromFile(@"素材\灰背景.jpg");
        }

        private void pnlShowCuisine_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
