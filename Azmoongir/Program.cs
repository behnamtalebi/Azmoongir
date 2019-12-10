
/****************************** Project Windows Forms ******************************\
*	Module Name:	Program.cs
*	Project:		Azmoongir
*	Copyright (C) 2019 Behnam Talebi, All rights reserved.
*	This software may be modified and distributed under the terms of the MIT license.  See LICENSE file for details.
*
*	Written by Behnam Talebi<Behnam_Talebi@yahoo.com>,  2019, 12, 11, 12:36 AM
*	
***********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;

namespace Azmoongir
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
