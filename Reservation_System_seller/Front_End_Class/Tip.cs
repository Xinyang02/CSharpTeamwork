using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front_End_Class
{
    public partial class Tip : Form
    {
        public Tip(string tip)
        {
            
            InitializeComponent();
            lblTip.Text = tip;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
