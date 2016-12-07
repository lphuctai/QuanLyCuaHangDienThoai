using BUS;
using BUS.BusPhanCa;
using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHDT.Cong
{
	public partial class FormChamCong : Form
	{

		public FormChamCong()
		{
			InitializeComponent();
			List<PHAN_CA> pcs = PhanCa.LayCaLamViec(Init.nhanVien.MSNV, DateTime.Now);
			Console.WriteLine(pcs.Count);
			for (int i = 0; i < pcs.Count; i++)
				flowLayoutPanel1.Controls.Add(new PanelCong(pcs[i]));
		}

		static public Bitmap getIcon()
		{
			return Properties.Resources.btnChamCong;
		}

		private void FormChamCong_Load(object sender, EventArgs e)
		{
		}
	}
}
