using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    static class Program
    {
        public static ApplicationContext ac = new ApplicationContext();
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormLogin startForm = new FormLogin(); //동적으로 폼을 열수 있도록 함.
            ac.MainForm = startForm;
            Application.Run(ac);
        }
    }
}
