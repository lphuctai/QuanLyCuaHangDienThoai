using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusSanPham
{
	public class SanPham
	{

		public SanPham()
		{
		}

		public static SAN_PHAM TimSanPham(string imei)
		{
			try
			{
				return SAN_PHAM.select(" where IMEI = '" + imei + "' ")[0];
			}
			catch(Exception)
			{
				return null;
			}
		}

		public static SAN_PHAM ThanhToan(SAN_PHAM sp)
		{
			CHI_TIET_SAN_PHAM ctsp = ChiTietSanPham.LayChiTietSanPham(sp.MA_CHI_TIET_SAN_PHAM);
			sp.GIA_BAN = ctsp.GIA_BAN;
			sp.NGAY_BAT_DAU_BAO_HANH = DateTime.Now;
			sp.NGAY_KET_THUC_BAO_HANH = DateTime.Now.AddMonths(Convert.ToInt32(ctsp.THOI_GIAN_BAO_HANH));
			sp.TRANG_THAI = 1;
			SAN_PHAM.update(sp);
			return sp;
        }

		public static bool KiemTraDanhSachSanPham(List<string> imei)
		{
			bool result = true;
			for (int i = 0; i < imei.Count; i++)
				result &= (LaySanPham(imei[i]) == null);
			return result;
		}

		public static bool ThemSanPham(SAN_PHAM sp)
		{
			SAN_PHAM.insert(sp);
			LichSuSanPham.ThemSanPham(sp, sp.GHI_CHU);
			return true;
		}

		public static bool GuiBaoHanh(string imei)
		{
			SAN_PHAM sp = LaySanPham(imei);
			sp.TRANG_THAI = 2;
			LichSuSanPham.GuiBaoHanh(sp);
			SAN_PHAM.update(sp);
			return true;
		}

		public static bool NhanBaoHanh(string imei)
		{
			SAN_PHAM sp = LaySanPham(imei);
			sp.TRANG_THAI = 1;
			LichSuSanPham.NhanBaoHanh(sp);
			SAN_PHAM.update(sp);
			return true;
		}

		public static SAN_PHAM LaySanPham(string imei)
		{
			try
			{
				return SAN_PHAM.select(" where IMEI = " + imei)[0];
			}
			catch(Exception)
			{
				return null;
			}
		}
		public static int LayTongCong(List<SAN_PHAM> imei)
		{
			int tongCong = 0;
			for(int i = 0; i < imei.Count; i ++)
			{
				SAN_PHAM tmp = imei[i];
				tongCong += ChiTietSanPham.LayChiTietSanPham(tmp.MA_CHI_TIET_SAN_PHAM).GIA_BAN;
			}
			return tongCong;
		}
		public static int LayTongCong(SAN_PHAM imei)
		{
			return ChiTietSanPham.LayChiTietSanPham(imei.MA_CHI_TIET_SAN_PHAM).GIA_BAN;
		}
	}
}
