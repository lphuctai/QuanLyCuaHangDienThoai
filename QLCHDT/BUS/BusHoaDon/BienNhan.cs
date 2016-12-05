using BUS.BusSanPham;
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

		public BienNhan(HOA_DON hd)
			:base(hd)
		{
			ThongTinKhachHang = hd.THONG_TIN_KHACH_HANG;
		}

		public static int TaoBienNhan()
		{
			HOA_DON tmp = new HOA_DON();
			tmp.MA_HOA_DON = 0;
			tmp.TONG_CONG = 0;
			tmp.LOAI_HOA_DON = 3;
			tmp.TONG_CONG = 0;
			tmp.THOI_GIAN = DateTime.Now;
			tmp.MSNV_THUC_HIEN = Init.nhanVien.MSNV;
			HOA_DON.insert(tmp);
			return tmp.MA_HOA_DON;
		}

		private static bool GuiBaoHanh(int maHoaDon, SanPham sp, ChiTietHoaDon cthd)
		{
			//wrong
			HOA_DON tmp;
			try
			{
				tmp = HOA_DON.select(" where MA_HOA_DON = " + maHoaDon)[0];
			}
			catch(Exception)
			{
				return false;
			}
			cthd.MaHoaDon = tmp.MA_HOA_DON;
			ChiTietHoaDon.NhapHang(cthd);
			HOA_DON.update(tmp);
			return true;
		}

		private static bool NhanBaoHanh(int maHoaDon)
		{//wrong
			HOA_DON tmp;
			try
			{
				tmp = HOA_DON.select(" where MA_HOA_DON = " + maHoaDon)[0];
			}
			catch (Exception)
			{
				return false;
			}
			tmp.MA_HOA_DON = 4;
			HOA_DON.update(tmp);
			return true;
		}


		//	Get/Set accessor
		public string ThongTinKhachHang
		{
			get; set;
		}

	}
}

