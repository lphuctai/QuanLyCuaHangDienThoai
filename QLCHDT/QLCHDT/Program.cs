using BUS;
using BUS.BusNhanVien;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHDT
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{

			NhanVien tmp = NhanVien.NhanVienFactory((from nv in (new QLDT().NHAN_VIEN) where nv.MSNV == 1 select nv).FirstOrDefault<NHAN_VIEN>());
			Console.WriteLine(tmp.GetType());
			/*
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			MainForm mainForm = new MainForm();
			mainForm.AddButton("Chấm Công", Properties.Resources.btnChamCong);
			mainForm.AddButton("Chấm Công", Properties.Resources.btnChamCong);
			mainForm.AddButton("Chấm Công", Properties.Resources.btnChamCong);
			mainForm.AddButton("Chấm Công", Properties.Resources.btnChamCong);
			mainForm.AddButton("Chấm Công", Properties.Resources.btnChamCong);
			//mainForm.Invalidate();
			Application.Run(mainForm);
			*/
		}
	}
}
