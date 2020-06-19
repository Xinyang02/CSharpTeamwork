using Bottom_Class;
using System;
using System.IO;
using System.Windows.Forms;
namespace Front_End_Class
{
    public partial class Edit_Info_Form : Form
    {
        private Merchant currentMerchant;
        public Edit_Info_Form(Merchant merchant)
        {
            this.currentMerchant = merchant;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentMerchant.Name = MerchantName.Text;
            currentMerchant.Address = MerchantAddress.Text;
            currentMerchant.BusinessHours = BusinessHours.Text;
            currentMerchant.PhoneNum = MerchantPhone.Text;
            currentMerchant.Picture= File.ReadAllBytes(path.Text);
            Merchant_Service.ModifyMerchant(currentMerchant);
            Merchant_Info_Form mif = new Merchant_Info_Form(MerchantAddress.Text, MerchantName.Text, MerchantPhone.Text, BusinessHours.Text,path.Text);
            
            mif.ShowDialog();
            
        }

    private void ChangeMsgForm_Load(object sender, EventArgs e)
    {

    }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();

            of.Filter = "PNG文件|*.png|JPG文件|*.jpg.*";
            of.RestoreDirectory = false;    //若为false，则打开对话框后为上次的目录。若为true，则为初始目录        
            if (of.ShowDialog() == DialogResult.OK)
            {
                path.Text = System.IO.Path.GetFullPath(of.FileName);
            }
        }
    }
}
