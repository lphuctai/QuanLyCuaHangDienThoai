using BUS;
using BUS.BusNhanVien;
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

namespace QLCHDT.User
{
	public partial class FormSaThai : Form
	{
		public FormSaThai()
		{
			InitializeComponent();
		}

		public static Bitmap getIcon()
		{
			return Properties.Resources.btnRemoveAccount;
		}

		private void FormSaThai_Load(object sender, EventArgs e)
		{
			BindingList<NHAN_VIEN> nv = new BindingList<NHAN_VIEN>(NhanVien.LayNhanVien());
			dgvNhanVien.DataSource = nv;
		}

		private void button1_Click(object sender, EventArgs e)
		{
            int msnv = ((NHAN_VIEN)dgvNhanVien.SelectedRows[0].DataBoundItem).MSNV;
			if(QuanLy.SaThaiNhanVien(msnv, ""))
			{
				MessageBox.Show("Xoá Nhân Viên Thành Công!");
				dgvNhanVien.Rows.RemoveAt(dgvNhanVien.CurrentRow.Index);
			}
			else
			{
				MessageBox.Show("Xoá Nhân Viên Thất Bại!");
			}
		}
	}
}
