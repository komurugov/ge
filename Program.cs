﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace geApp
{
    static class Program    // векторный графический редактор
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
