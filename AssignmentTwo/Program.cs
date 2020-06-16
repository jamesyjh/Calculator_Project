////////////////////////////////////////////////////////////////////////////////////////////////////////
//Project: AssignmentTwo - PROG32356
//Authors : Patrick Ryan, James Hong, Muhammad Nasir, Karam Fasih
//Created On : 2020-06-16
//Description : Windows-style Calculator Project
////////////////////////////////////////////////////////////////////////////////////////////////////////
///


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentTwo
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
            Application.Run(new Form1());
        }
    }
}
