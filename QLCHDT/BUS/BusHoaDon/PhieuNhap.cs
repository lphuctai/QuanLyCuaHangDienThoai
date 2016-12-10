using BUS.BusSanPham;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusHoaDon
{
	public class PhieuNhap : HoaDon
	{

		public PhieuNhap()
			:base()
		{
		}

		public static HOA_DON TaoPhieuNhap(int maDoiTac, int tongCong)
		{
			HOA_DON tmp = new HOA_DON();
			tmp.MA_HOA_DON = 0;
			tmp.TONG_CONG = 0;
			tmp.LOAI_HOA_DON = 1;
			tmp.TONG_CONG = tongCong;
			tmp.THOI_GIAN = DateTime.Now;
			tmp.MSNV_THUC_HIEN = Init.nhanVien.MSNV;
			tmp.MA_DOI_TAC = maDoiTac;
			return tmp;
        }

		public static int NhapHang(KHO_HANG kh, List<string>imei)
		{
			if (SanPham.KiemTraDanhSachSanPham(imei) == false)
				return 0;
			HOA_DON hd = TaoPhieuNhap(kh.MA_DOI_TAC, kh.SO_LUONG * kh.GIA_MUA);
			int maHoaDon = HOA_DON.insert(hd);
			KhoHang.LuuKho(kh, imei);
			for (int i = 0; i < imei.Count; i++)
				ChiTietHoaDon.NhapHang(maHoaDon, imei[i], kh.GIA_MUA);
			return maHoaDon;
		}

	}
}
