using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusHoaDon
{
	public class BienNhan : HoaDon
	{
		private string thongTinKhachHang;

		public BienNhan(HOA_DON hd)
			:base(hd)
		{
			thongTinKhachHang = hd.THONG_TIN_KHACH_HANG;
		}

		//	Get/Set accessor
		public string ThongTinKhachHang
		{
			get { return thongTinKhachHang; }
			set { thongTinKhachHang = value; }
		}
	}
}
