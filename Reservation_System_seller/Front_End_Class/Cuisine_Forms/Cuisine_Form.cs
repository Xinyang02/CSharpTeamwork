using Bottom_Class;
using System;
using System.Windows.Forms;

namespace Front_End_Class
{
    public partial class Cuisine_Form : Form
    { 




        public Cuisine_Form(CuisineType cuisineType,Order order)
        {
            int i=0;
            foreach (Cuisine cuisine in cuisineType.Cuisines)
            {
                Cuisine_Control control = new Cuisine_Control();
                control.DataBindings.Add("Name", cuisine, "Name");
                control.DataBindings.Add("Image", cuisine, "Picture");
                control.DataBindings.Add("Price", cuisine, "UnitPrice");
                pnlShowCuisine.Controls.Add(control);
                control.SetBounds(0, i * 75, 267, 75);
                i++;
            }//显示所有的商家图片并进行动态绑定；





            InitializeComponent();
            
        }

        private void CuisineForm_Load(object sender, EventArgs e)
        {
          
            
        }



    }
}
