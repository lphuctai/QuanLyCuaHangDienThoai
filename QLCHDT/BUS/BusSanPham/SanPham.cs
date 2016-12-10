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

		public static bool ThanhToan(SAN_PHAM sp, string ghiChu)
		{
			if (sp.TRANG_THAI == 1)
				return false;
			CHI_TIET_SAN_PHAM ctsp;
            try
			{
				ctsp = CHI_TIET_SAN_PHAM.select(" where MA_CHI_TIET_SAN_PHAM = " + sp.MA_CHI_TIET_SAN_PHAM)[0];
			}
			catch(Exception)
			{
				return false;
			}
			SAN_PHAM tmp = sp;
			// Doing
			tmp.TRANG_THAI = 1;
			tmp.GHI_CHU = ghiChu;
			tmp.GIA_BAN = ctsp.GIA_BAN;
			tmp.GIA_BAN = ctsp.GIA_BAN;
			tmp.NGAY_BAT_DAU_BAO_HANH = DateTime.Now;
			tmp.NGAY_KET_THUC_BAO_HANH = new DateTime(DateTime.Now.AddMonths(Convert.ToInt32(ctsp.THOI_GIAN_BAO_HANH)).Year
				, DateTime.Now.AddMonths(Convert.ToInt32(ctsp.THOI_GIAN_BAO_HANH)).Month, DateTime.Now.Day);

			LichSuSanPham.ThanhToan(sp, tmp);
			if (ChiTietSanPham.ThanhToan(ctsp.MA_CHI_TIET_SAN_PHAM) == false)
			{
				LichSuSanPham.ThanhToan(tmp, sp);
				return false;
			}
			SAN_PHAM.update(tmp);
			return true;
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
			if (sp == null || sp.TRANG_THAI == 0 || sp.TRANG_THAI == 2)
				return false;
			sp.TRANG_THAI = 2;
			LichSuSanPham.GuiBaoHanh(sp);
			SAN_PHAM.update(sp);
			return true;
		}

		public static bool NhanBaoHanh(SAN_PHAM sp)
		{
			if (sp.TRANG_THAI == 0 || sp.TRANG_THAI == 1)
				return false;
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
	}
}
