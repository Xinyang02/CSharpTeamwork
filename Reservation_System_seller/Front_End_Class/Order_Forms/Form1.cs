using Bottom_Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using 订餐系统;

namespace Front_End_Class.Order_Forms
{
    public partial class Form1 : Form
    {
        private Merchant currentMerchant;
        public Form1(Merchant merchant)
        {
            this.currentMerchant = merchant;
            this.mof = new Manage_Order_Form(merchant);
            this.wcf = new waitCancelForm(merchant);
            this.af = new acceptedForm(merchant);
            //this.cf = new cancelForm(merchant);
            this.df = new deliverForm(merchant);
            this.ff = new finishForm(merchant);
            this.finishOrder1 = Order_Service.GetFinishOrderList(merchant).Count;
            this.waitOrder1 = Order_Service.GetOrderList(merchant).Count;
            this.cancelOrder1 = Order_Service.GetWaitCancelOrderList(merchant).Count;
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 3000; 
            timer1.Tick += new System.EventHandler(timer1_Tick);
            timer1.Start();

            
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            Thread thread1 = new Thread(this.cancelOrder);
            Thread thread2 = new Thread(this.newOrder);
            Thread thread3 = new Thread(()=>this.updateMOF(mof));
            thread1.Start();
            thread2.Start();
            thread3.Start();
            */
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        public void updateMOF(Manage_Order_Form mof)
        {
            mof.bindingSource1.DataSource = Order_Service.GetOrderList(currentMerchant);
            //typeBindingSource.DataSource = currentMerchant.CuisineTypes;
            mof.bindingSource1.ResetBindings(false);
            mof.bindingSource2.DataSource = mof.bindingSource1.Current;
            Thread.Sleep(5000);

        }
        private Manage_Order_Form mof;
        private waitCancelForm wcf;
        //private cancelForm cf;
        private acceptedForm af;
        private deliverForm df;
        private finishForm ff;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                //Manage_Order_Form mof = new Manage_Order_Form(currentMerchant);
                
                panel1.Controls.Clear();
                mof.FormBorderStyle = FormBorderStyle.None;
                mof.TopLevel = false;
                this.panel1.Controls.Add(mof);
                mof.Show();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                

                panel1.Controls.Clear();
                af.FormBorderStyle = FormBorderStyle.None;
                af.TopLevel = false;
                this.panel1.Controls.Add(af);
                af.Show();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {


                panel1.Controls.Clear();
                df.FormBorderStyle = FormBorderStyle.None;
                df.TopLevel = false;
                this.panel1.Controls.Add(df);
                df.Show();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {


                panel1.Controls.Clear();
                ff.FormBorderStyle = FormBorderStyle.None;
                ff.TopLevel = false;
                this.panel1.Controls.Add(ff);
                ff.Show();
            }
        }
        
        private int waitOrder1;
        private int finishOrder1;
        //private int waitOrder2;
        private int cancelOrder1;
        private int cancelOrder2;
        
        public void newOrder()
        {
            int waitOrder2 = Order_Service.GetOrderList(currentMerchant).Count;
            int cancelOrder2= Order_Service.GetWaitCancelOrderList(currentMerchant).Count;
            if (waitOrder2+cancelOrder2>waitOrder1+cancelOrder1)
            {
                textBox1.Text += "您有新的订单啦！\r\n";
            }
            waitOrder1 = waitOrder2;
            cancelOrder1 = waitOrder2;
            Thread.Sleep(5000);
        }

        public void cancelOrder()
        {
            int cancelOrder= Order_Service.GetWaitCancelOrderList(currentMerchant).Count;
            if(cancelOrder>cancelOrder1)
            {
                textBox1.Text += "注意啦！有客户要取消订单！\r\n";
            }
            cancelOrder2 = cancelOrder;
            Thread.Sleep(5000);
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                //Wait_Order_Form mof = new Manage_Order_Form(currentMerchant);

                panel1.Controls.Clear();
                wcf.FormBorderStyle = FormBorderStyle.None;
                wcf.TopLevel = false;
                this.panel1.Controls.Add(wcf);
                wcf.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int waitOrder2 = Order_Service.GetOrderList(currentMerchant).Count;
            int cancelOrder2 = Order_Service.GetWaitCancelOrderList(currentMerchant).Count;
            if (waitOrder2 + cancelOrder2 > waitOrder1 + cancelOrder1)
            {
                textBox1.Text += $"{DateTime.Now.ToLocalTime().ToString()}:您有新的订单啦！\r\n";
            }
            //int cancelOrder = Order_Service.GetWaitCancelOrderList(currentMerchant).Count;
            if (cancelOrder2 > cancelOrder1)
            {
                textBox1.Text += $"{DateTime.Now.ToLocalTime().ToString()}:注意啦！有客户要取消订单！\r\n";
            }
            waitOrder1 = waitOrder2;
            cancelOrder1 = cancelOrder2;

            int finishOrder = Order_Service.GetFinishOrderList(currentMerchant).Count;
            if(finishOrder>finishOrder1)
            {
                textBox1.Text += $"{DateTime.Now.ToLocalTime().ToString()}:订单已完成！\r\n";
            }
            finishOrder1 = finishOrder;
            //更新mof
            mof.bindingSource1.DataSource = Order_Service.GetOrderList(currentMerchant);
            mof.bindingSource1.ResetBindings(false);
            if(mof.dataGridView3.Rows.Count<=1)
            {
                mof.bindingSource2.DataSource = mof.bindingSource1.Current;
            }
            //mof.bindingSource2.DataSource = mof.bindingSource1.Current;
            //更新wcf
            wcf.bindingSource1.DataSource = Order_Service.GetWaitCancelOrderList(currentMerchant);
            wcf.bindingSource1.ResetBindings(false);
            if (wcf.dataGridView1.Rows.Count <= 1)
            {
                wcf.bindingSource2.DataSource = wcf.bindingSource1.Current;
            }
            //wcf.bindingSource2.DataSource = wcf.bindingSource1.Current;

            //更新af
            af.bindingSource1.DataSource = Order_Service.GetAcceptedOrderList(currentMerchant);
            af.bindingSource1.ResetBindings(false);
            if (af.dataGridView1.Rows.Count <= 1)
            {
                af.bindingSource2.DataSource = af.bindingSource1.Current;
            }
            //af.bindingSource2.DataSource = af.bindingSource1.Current;
            //更新df           
            df.bindingSource1.DataSource = Order_Service.GetDeliverOrderList(currentMerchant);
            df.bindingSource1.ResetBindings(false);
            if (df.dataGridView1.Rows.Count <= 1)
            {
                df.bindingSource2.DataSource = df.bindingSource1.Current;
            }
            //df.bindingSource2.DataSource = df.bindingSource1.Current;
            //更新ff
            ff.bindingSource1.DataSource = Order_Service.GetFinishOrderList(currentMerchant);
            ff.bindingSource1.ResetBindings(false);

        }
        /*
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                

                panel1.Controls.Clear();
                cf.FormBorderStyle = FormBorderStyle.None;
                cf.TopLevel = false;
                this.panel1.Controls.Add(cf);
                cf.Show();
            }
        }
        */
    }
}
