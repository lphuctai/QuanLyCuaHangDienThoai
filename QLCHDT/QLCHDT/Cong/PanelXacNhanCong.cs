using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS.BusPhanCa;
using DAO;

namespace QLCHDT.Cong
{
	public partial class PanelCong : UserControl
	{
		PHAN_CA pc;
		public PanelCong(PHAN_CA pc)
		{
			InitializeComponent();
			this.pc = pc;
			lbCong.Text = "Ca " + pc.CA;
			if(pc.CHAM_CONG == 1)
			{
				KhoaTrangThai();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			PhanCa.ChamCongHangNgay(pc);
			KhoaTrangThai();
        }

		private void KhoaTrangThai()
		{
			btnCong.Enabled = false;
			btnCong.Text = "Đã Chấm";
			this.BackColor = Color.Gray;
		}
	}
}
