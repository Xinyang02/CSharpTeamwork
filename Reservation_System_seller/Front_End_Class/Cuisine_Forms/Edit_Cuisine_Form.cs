using Bottom_Class;
//using Front_End_Class.Cuisine_Forms;
using System;
using System.Windows.Forms;

namespace Front_End_Class
{
    public partial class Edit_Cuisine_Form : Form
    {
        
        public Edit_Cuisine_Form(Merchant merchant)
        {

            this.currentMerchant = merchant;
            typeBindingSource = new BindingSource();
            InitializeComponent();
            
            typeBindingSource.DataSource = Merchant_Service.getAllCuisineTypes(merchant);
            //typeBindingSource.DataSource = currentMerchant.CuisineTypes;
            typeBindingSource.ResetBindings(false);
            
            //cuisineBindingSource.DataSource = Merchant_Service.getAllCuisineTypes(merchant)[0];
            //cuisineBindingSource.DataSource = Merchant_Service.getAllCuisines(cuisineType);
            //cuisineBindingSource.DataSource = type.Cuisines;
            cuisineBindingSource.ResetBindings(false);
        }
        

        private Merchant currentMerchant;

        private void AddFoodForm_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cuisineBindingSource.DataSource = Merchant_Service.getAllCuisineTypes(currentMerchant)[dataGridView1.CurrentCell.RowIndex].Cuisines;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //Cuisine cuisine = new Cuisine(int.Parse(Food_ID.Text), FoodName.Text, Food_Des.Text, 
              //  int.Parse(Food_Price.Text), Food_Class.Text, Food_image.Text,currentMerchant);
            //CuisineService.AddCuisine(cuisine);

            //以所有的textbox中的内容创建一个新的Food对象到指定Cuisine中
        }

        private void Food_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CuisineType newType = new CuisineType(nameBox.Text,currentMerchant.Id);
            //currentMerchant.CuisineTypes.Add(newType);
            Merchant_Service.addCuisineType(newType);
            typeBindingSource.DataSource = Merchant_Service.getAllCuisineTypes(currentMerchant);
            //typeBindingSource.DataSource = currentMerchant.CuisineTypes;
            typeBindingSource.ResetBindings(false);
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //CuisineType selectType = Merchant_Service.getAllCuisineTypes(currentMerchant)[dataGridView1.CurrentCell.RowIndex];
            //CuisineType selectType = currentMerchant.CuisineTypes[dataGridView1.CurrentCell.RowIndex];
            //Add_Form add_Form = new Add_Form(selectType);
            //add_Form.ShowDialog();
            
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if(Merchant_Service.getAllCuisineTypes(currentMerchant)!=null)
            {
                cuisineBindingSource.DataSource = Merchant_Service.getAllCuisineTypes(currentMerchant)[dataGridView1.CurrentCell.RowIndex].Cuisines;
                //cuisineBindingSource.DataSource = currentMerchant.CuisineTypes[dataGridView1.CurrentCell.RowIndex].Cuisines;
                cuisineBindingSource.ResetBindings(false);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cuisine cuisine = new Cuisine( Name2.Text, Des2.Text, int.Parse(Price2.Text), Merchant_Service.getAllCuisineTypes(currentMerchant)[dataGridView1.CurrentCell.RowIndex].Id,path.Text);
            Merchant_Service.addCuisine(cuisine);
            cuisineBindingSource.DataSource = Merchant_Service.getAllCuisineTypes(currentMerchant)[dataGridView1.CurrentCell.RowIndex].Cuisines;
            cuisineBindingSource.ResetBindings(false);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(dataGridView2.CurrentCell.RowIndex>=0)
            {
                Merchant_Service.deleteCuisine(Merchant_Service.getAllCuisineTypes(currentMerchant)[dataGridView1.CurrentCell.RowIndex].Cuisines[dataGridView2.CurrentCell.RowIndex]);
                cuisineBindingSource.DataSource = Merchant_Service.getAllCuisineTypes(currentMerchant)[dataGridView1.CurrentCell.RowIndex].Cuisines;
                cuisineBindingSource.ResetBindings(false);
                
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
               
            of.Filter = "PNG文件|*.png|JPG文件|*.jpg.*";        
            of.RestoreDirectory = false;    //若为false，则打开对话框后为上次的目录。若为true，则为初始目录        
            if (of.ShowDialog() == DialogResult.OK)
            {
                path.Text = System.IO.Path.GetFullPath(of.FileName);
            }
             

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
