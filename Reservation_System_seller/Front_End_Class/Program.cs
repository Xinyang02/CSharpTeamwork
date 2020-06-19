using Front_End_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front_End_Class
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Login_Form lf = new Login_Form();
            lf.FormBorderStyle = FormBorderStyle.FixedSingle;
            Application.Run(lf);
        }
    }
}
