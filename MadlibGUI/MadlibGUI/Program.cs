/*
  * Rhona Jessica Filgueras
  * December 14, 2020
  *
  * code derived from https://www.linkedin.com/learning/object-oriented-programming-with-c-sharp/windows-forms-mvc?u=2243042
  *
  */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadlibGUI
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
            Application.Run(new MyForm());
        }
    }
}
