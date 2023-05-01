using BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
	public class Log
	{
		public static void Write(string msg)
		{
			LogBUS.WriteLog(MainForm.User.Username, msg);	
		} 
	}
}
