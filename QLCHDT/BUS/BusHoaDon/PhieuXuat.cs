using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusHoaDon
{
	public class PhieuXuat : HoaDon
	{
		private int tongCong = 0;
		private string thongTinKhachHang;

		public PhieuXuat(HOA_DON hd)
			:base(hd)
		{
			tongCong = Convert.ToInt32(hd.TONG_CONG);
			thongTinKhachHang = hd.THONG_TIN_KHACH_HANG;
		}

		//	Get/Set accessor
		public int TongCong
		{
			get { return tongCong; }
			set { tongCong = value; }
		}

		public string ThongTinKhachHang
		{
			get { return thongTinKhachHang; }
			set { thongTinKhachHang = value; }
		}
	}
}
