using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
	public class User
	{
		public static string Username { get => MainForm.User.Username; }
		public static bool IsAdmin { get => MainForm.Account.Type == 1; }
		public static bool IsManager { get => MainForm.Account.Type == 2;}
	}
}
