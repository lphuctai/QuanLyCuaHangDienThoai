using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusSanPham
{
	public class LichSuSanPham
	{

		public LichSuSanPham()
		{
		}

		public static bool ThemSanPham(SAN_PHAM sp, string ghiChu)
		{
			LICH_SU_SAN_PHAM lssp = new LICH_SU_SAN_PHAM(sp, Init.nhanVien.MSNV, 0, "Add Product " + ghiChu);
			LICH_SU_SAN_PHAM.insert(lssp);
			return true;
		}

		public static bool ThanhToan(SAN_PHAM cu, SAN_PHAM moi)
		{
			List<LICH_SU_SAN_PHAM> log = new List<LICH_SU_SAN_PHAM>();
			if (cu.MA_CHI_TIET_SAN_PHAM != moi.MA_CHI_TIET_SAN_PHAM)
				log.Add(new LICH_SU_SAN_PHAM(cu, Init.nhanVien.MSNV, 2, cu.MA_CHI_TIET_SAN_PHAM + " -> " + moi.MA_CHI_TIET_SAN_PHAM));
			if (cu.NGAY_BAT_DAU_BAO_HANH != moi.NGAY_BAT_DAU_BAO_HANH)
				log.Add(new LICH_SU_SAN_PHAM(cu, Init.nhanVien.MSNV, 3, (cu.NGAY_BAT_DAU_BAO_HANH != null? cu.NGAY_BAT_DAU_BAO_HANH.ToString():"") + " -> " + moi.NGAY_BAT_DAU_BAO_HANH));
			if (cu.NGAY_KET_THUC_BAO_HANH != moi.NGAY_KET_THUC_BAO_HANH)
				log.Add(new LICH_SU_SAN_PHAM(cu, Init.nhanVien.MSNV, 4, (cu.NGAY_KET_THUC_BAO_HANH != null ? cu.NGAY_KET_THUC_BAO_HANH.ToString() : "") + " -> " + moi.NGAY_KET_THUC_BAO_HANH));
			if (cu.TRANG_THAI != moi.TRANG_THAI)
				log.Add(new LICH_SU_SAN_PHAM(cu, Init.nhanVien.MSNV, 5, cu.TRANG_THAI + " -> " + moi.TRANG_THAI));
			if (cu.GIA_MUA != moi.GIA_MUA)
				log.Add(new LICH_SU_SAN_PHAM(cu, Init.nhanVien.MSNV, 6, cu.GIA_MUA + " -> " + moi.GIA_MUA));
			if (cu.GIA_BAN != moi.GIA_BAN)
				log.Add(new LICH_SU_SAN_PHAM(cu, Init.nhanVien.MSNV, 7, cu.GIA_BAN + " -> " + moi.GIA_BAN));
			if (cu.GHI_CHU != moi.GHI_CHU)
				log.Add(new LICH_SU_SAN_PHAM(cu, Init.nhanVien.MSNV, 8, cu.GHI_CHU + " -> " + moi.GHI_CHU));
			moi.IMEI = cu.IMEI;
			try
			{
				for (int i = 0; i < log.Count; i++)
				{
					LICH_SU_SAN_PHAM.insert(log[i]);
				}
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public static bool GuiBaoHanh(SAN_PHAM sp)
		{
			if (sp.TRANG_THAI == 2)
				return false;
			LICH_SU_SAN_PHAM lssp = new LICH_SU_SAN_PHAM(sp, Init.nhanVien.MSNV, 5, sp.TRANG_THAI + " -> 2");
			LICH_SU_SAN_PHAM.insert(lssp);
			return true;
		}

		public static bool NhanBaoHanh(SAN_PHAM sp)
		{
			if (sp.TRANG_THAI == 1 || sp.TRANG_THAI == 0)
				return false;
			LICH_SU_SAN_PHAM lssp = new LICH_SU_SAN_PHAM(sp, Init.nhanVien.MSNV, 5, sp.TRANG_THAI + " -> 1");
			LICH_SU_SAN_PHAM.insert(lssp);
			return true;
		}
	}
}
