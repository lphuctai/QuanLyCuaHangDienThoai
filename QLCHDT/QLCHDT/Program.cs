using BUS;
using BUS.BusNhanVien;
using DAO;
using QLCHDT.Cong;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHDT
{
	static class Program
	{

		public static MainForm mainForm = null;
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			CultureInfo culture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
			culture.DateTimeFormat.ShortDatePattern = "yyyy-MM-dd";
			culture.DateTimeFormat.LongTimePattern = "";
			Thread.CurrentThread.CurrentCulture = culture;

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			FormLogin formLogin = new FormLogin();
			Application.Run(formLogin);
		}
	}
}
