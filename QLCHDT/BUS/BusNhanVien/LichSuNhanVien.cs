using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusNhanVien
{
	public class LichSuNhanVien
	{
		
		public LichSuNhanVien()
		{
		}

		public static List<LICH_SU_NHAN_VIEN> LayLichSuNhanVien(NHAN_VIEN nv)
		{
			return LICH_SU_NHAN_VIEN.select(" where MSNV = " + nv.MSNV);
		}

		public static bool ThayDoiThongTin(NHAN_VIEN nvCu, NHAN_VIEN nvMoi)
		{
			List<LICH_SU_NHAN_VIEN> log = new List<LICH_SU_NHAN_VIEN>();
			if (nvCu.HO_TEN != nvMoi.HO_TEN)
				log.Add(new LICH_SU_NHAN_VIEN(nvCu.MSNV, Init.nhanVien.MSNV, 2, nvCu.HO_TEN + " -> " + nvMoi.HO_TEN));
			if (nvCu.CMND != nvMoi.CMND)
				log.Add(new LICH_SU_NHAN_VIEN(nvCu.MSNV, Init.nhanVien.MSNV, 3, nvCu.CMND + " -> " + nvMoi.CMND));
			if (nvCu.NGAY_SINH != nvMoi.NGAY_SINH)
				log.Add(new LICH_SU_NHAN_VIEN(nvCu.MSNV, Init.nhanVien.MSNV, 4, nvCu.NGAY_SINH + " -> " + nvMoi.NGAY_SINH));
			if (nvCu.SO_DIEN_THOAI != nvMoi.SO_DIEN_THOAI)
				log.Add(new LICH_SU_NHAN_VIEN(nvCu.MSNV, Init.nhanVien.MSNV, 5, nvCu.SO_DIEN_THOAI + " -> " + nvMoi.SO_DIEN_THOAI));
			if (nvCu.GetType() != nvMoi.GetType())
				log.Add(new LICH_SU_NHAN_VIEN(nvCu.MSNV, Init.nhanVien.MSNV, 6, nvCu.GetType().ToString() + " -> " + nvMoi.GetType().ToString()));
			if (nvCu.MAT_KHAU != nvMoi.MAT_KHAU)
				log.Add(new LICH_SU_NHAN_VIEN(nvCu.MSNV, Init.nhanVien.MSNV, 7, "******** -> ********"));
			if (nvCu.NGAY_VAO_LAM != nvMoi.NGAY_VAO_LAM)
				log.Add(new LICH_SU_NHAN_VIEN(nvCu.MSNV, Init.nhanVien.MSNV, 8, nvCu.NGAY_VAO_LAM + " -> " + nvMoi.NGAY_VAO_LAM));
			nvMoi.MSNV = nvCu.MSNV;
			try
			{
				for (int i = 0; i < log.Count; i++)
				{
					LICH_SU_NHAN_VIEN.insert(log[i]);
				}
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public static bool ThemNhanVien(int msnv, string ghiChu)
		{
			LICH_SU_NHAN_VIEN lsnv = new LICH_SU_NHAN_VIEN(msnv, Init.nhanVien.MSNV, 0, "Add Employee " + ghiChu);
			LICH_SU_NHAN_VIEN.insert(lsnv);
			return true;
		}

		public static bool SaThaiNhanVien(int msnv, string ghiChu)
		{
			LICH_SU_NHAN_VIEN lsnv = new LICH_SU_NHAN_VIEN(msnv, Init.nhanVien.MSNV, -1, "Leave Out Employee " + ghiChu);
			LICH_SU_NHAN_VIEN.insert(lsnv);
			return true;
		}

	}
}
