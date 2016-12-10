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
using BUS.BusSanPham;

namespace QLCHDT.FormSanPham
{
	public partial class PanelSanPham : UserControl
	{
		int gia = 0;
		SAN_PHAM sp;
		public PanelSanPham(SAN_PHAM sp)
		{
			InitializeComponent();
			this.sp = sp;
			lbIMEI.Text = sp.IMEI;
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		public string getString()
		{
			return sp.IMEI;
		}

		public SAN_PHAM getSanPham()
		{
			return sp;
		}

		public int getGia()
		{
			if(gia == 0)
			{
				gia = ChiTietSanPham.LayChiTietSanPham(sp.MA_CHI_TIET_SAN_PHAM).GIA_BAN;
			}
			return gia;
		}
	}
}
