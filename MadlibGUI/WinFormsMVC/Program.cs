using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsMVC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            UserInput input = new UserInput();

            var f1 = new FirstForm();
            f1.UserInput = input;
            f1.ShowDialog();

            var f2 = new View.SecondForm();
            f2.UserInput = input;
            f2.ShowDialog();

            //Application.Run();
        }
    }
}
