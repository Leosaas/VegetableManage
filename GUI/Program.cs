﻿using BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			if (ServerConfigBUS.ReadConfigFile() != null)
			{
				Application.Run(new FlashForm());
				return;
			}
			Application.Run(new ServerConfigForm());
		}
	}
}
