﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinAppForTeamCity
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // Added comment
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
