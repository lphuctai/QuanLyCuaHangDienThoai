using BUS.BusNhanVien;
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
	public partial class FormXacNhanCong : Form
	{
		public FormXacNhanCong()
		{
			InitializeComponent();
		}

		public static Bitmap getIcon()
		{
			return Properties.Resources.btnXacNhanCa;
		}

		private void FormXacNhanCong_Load(object sender, EventArgs e)
		{
			BindingList<NHAN_VIEN> nv = new BindingList<NHAN_VIEN>(NhanVien.LayNhanVien());
			cbbNhanVien.DataSource = nv;
			cbbNhanVien.DisplayMember = "DINH_DANH";
			cbbNhanVien.ValueMember = "MSNV";
			Console.WriteLine(cbbNhanVien.SelectedValue);
			TimCa((int)cbbNhanVien.SelectedValue, dtpTu.Value, dtpDen.Value);
		}

		public void TimCa(int msnv, DateTime tu, DateTime den)
		{
			flowPanel.Controls.Clear();
			List<PHAN_CA> pc = PhanCa.LayCaLamViec(msnv, tu, den);
			for (int i = 0; i < pc.Count; i++)
			{
				flowPanel.Controls.Add(new PanelXacNhanCong(pc[i]));
			}
		}

		private void dtpThoiGian_ValueChanged(object sender, EventArgs e)
		{
			TimCa((int)cbbNhanVien.SelectedValue, dtpTu.Value, dtpDen.Value);
		}

		private void cbbNhanVien_ValueMemberChanged(object sender, EventArgs e)
		{
			TimCa((int)cbbNhanVien.SelectedValue, dtpTu.Value, dtpDen.Value);
		}

		private void cbbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				TimCa((int)cbbNhanVien.SelectedValue, dtpTu.Value, dtpDen.Value);
			}
			catch(Exception)
			{ }
		}
	}
}
