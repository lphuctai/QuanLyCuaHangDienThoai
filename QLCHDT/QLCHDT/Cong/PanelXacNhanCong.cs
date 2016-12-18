using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using BUS.BusPhanCa;

namespace QLCHDT.Cong
{
	public partial class PanelXacNhanCong : UserControl
	{
		PHAN_CA pc;
		public PanelXacNhanCong()
		{
			InitializeComponent();
		}

		private void btnXacNhan_Click(object sender, EventArgs e)
		{
			PhanCa.XacNhanCaLamViec(pc);
			KhoaTrangThai();
		}

		public PanelXacNhanCong(PHAN_CA pc)
		{
			InitializeComponent();
			this.pc = pc;
			lbCong.Text = "Ca " + pc.CA + " " + pc.THOI_GIAN.Date.ToShortDateString();
			if (pc.XAC_NHAN_CONG == 1)
			{
				KhoaTrangThai();
			}
		}

		private void KhoaTrangThai()
		{
			btnXacNhan.Enabled = false;
			btnXacNhan.Text = "Đã Xác Nhận";
			this.BackColor = Color.Gray;
		}
	}
}
