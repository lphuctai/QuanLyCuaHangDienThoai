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

		public static int TaoPhieuXuat()
		{
			HOA_DON tmp = new HOA_DON();
			tmp.MA_HOA_DON = 0;
			tmp.TONG_CONG = 0;
			tmp.LOAI_HOA_DON = 2;
			tmp.TONG_CONG = 0;
			tmp.THOI_GIAN = DateTime.Now;
			tmp.MSNV_THUC_HIEN = Init.nhanVien.MSNV;
			return HOA_DON.insert(tmp);
		}

		public static bool XuatHang(int maHoaDon, List<SAN_PHAM> sps, List<CHI_TIET_HOA_DON> cthds)
		{
			HOA_DON tmp;
			try
			{
				tmp = HOA_DON.select(" where MA_HOA_DON = " + maHoaDon)[0];
			}
			catch (Exception)
			{
				return false;
			}
			int tongCong = 0;
			for (int i = 0; i < sps.Count; i++)
			{
				SanPham.ThanhToan(sps[i], "");
				cthds[i].MA_HOA_DON = tmp.MA_HOA_DON;
				ChiTietHoaDon.XuatHang(cthds[i]);
				ChiTietSanPham.ThanhToan(sps[i].MA_CHI_TIET_SAN_PHAM);
				tongCong += Convert.ToInt32(cthds[i].GIA);
			}
			HOA_DON.update(tmp);
			return true;
		}
	}
}
