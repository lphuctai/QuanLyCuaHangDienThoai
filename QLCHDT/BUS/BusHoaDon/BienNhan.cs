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

		public BienNhan()
			:base()
		{
		}

		public static HOA_DON TaoBienNhan(string thongTinKhachHang)
		{
			HOA_DON tmp = new HOA_DON();
			tmp.MA_HOA_DON = 0;
			tmp.TONG_CONG = 0;
			tmp.LOAI_HOA_DON = 3;
			tmp.TONG_CONG = 0;
			tmp.THOI_GIAN = DateTime.Now;
			tmp.MA_DOI_TAC = null;
			tmp.MSNV_THUC_HIEN = Init.nhanVien.MSNV;
			tmp.THONG_TIN_KHACH_HANG = thongTinKhachHang;
			return tmp;
		}

		public static int GuiBaoHanh(string imei, string thongTinKhachHang)
		{
			HOA_DON hd = TaoBienNhan(thongTinKhachHang);
			int maHoaDon = HOA_DON.insert(hd);
			SanPham.GuiBaoHanh(imei);
			return maHoaDon;
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
	}
}

