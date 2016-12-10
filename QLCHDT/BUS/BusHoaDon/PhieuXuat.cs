using BUS.BusSanPham;
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

		public PhieuXuat()
			:base()
		{
		}

		public static HOA_DON TaoPhieuXuat(string thonTinKhachHang)
		{
			HOA_DON tmp = new HOA_DON();
			tmp.MA_HOA_DON = 0;
			tmp.TONG_CONG = 0;
			tmp.LOAI_HOA_DON = 2;
			tmp.TONG_CONG = 0;
			tmp.THOI_GIAN = DateTime.Now;
			tmp.MSNV_THUC_HIEN = Init.nhanVien.MSNV;
			tmp.THONG_TIN_KHACH_HANG = thonTinKhachHang;
			return tmp;
		}

		public static int ThanhToan(string thongTinKhachHang, List<SAN_PHAM> imei)
		{
			List<SAN_PHAM> xacThuc = new List<SAN_PHAM>();
			int tongCong = SanPham.LayTongCong(imei);
			HOA_DON hd = TaoPhieuXuat(thongTinKhachHang);
			hd.TONG_CONG = tongCong;
			int maHoaDon = HOA_DON.insert(hd);
			for(int i = 0; i < imei.Count; i ++)
			{
				SAN_PHAM sp = KhoHang.XuatKho(imei[i]);
				ChiTietHoaDon.XuatHang(maHoaDon, sp);
			}
			return maHoaDon;
		}
	}
}
