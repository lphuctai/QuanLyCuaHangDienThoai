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
		
		public LichSuNhanVien(LICH_SU_NHAN_VIEN lsnv)
		{
			MSNV = lsnv.MSNV;
			ThoiGian = lsnv.THOI_GIAN;
			MaLichSu = lsnv.MA_LICH_SU;
			MSNVThucHien = Convert.ToInt32(lsnv.MSNV_THUC_HIEN);
			GhiChu = lsnv.GHI_CHU;
		}

		public LichSuNhanVien(NhanVien nv, int maLichSu, string ghiChu)
		{
			MSNV = nv.MSNV;
			ThoiGian = DateTime.Now;
			MaLichSu = maLichSu;
			MSNVThucHien = Init.nhanVien.MSNV;
			GhiChu = ghiChu;
		}

		public static List<LichSuNhanVien> LayLichSuNhanVien(NhanVien nv)
		{
			List<LICH_SU_NHAN_VIEN> lsnvdb = LICH_SU_NHAN_VIEN.select(" where MSNV = " + nv.MSNV);
			List<LichSuNhanVien> lsnv = new List<LichSuNhanVien>();
			foreach (var i in lsnvdb)
				lsnv.Add(new LichSuNhanVien(i));
			return lsnv;
		}

		public static bool ThayDoiThongTin(NhanVien nvCu, NhanVien nvMoi)
		{
			List<LichSuNhanVien> log = new List<LichSuNhanVien>();
			if (nvCu.HoTen != nvMoi.HoTen)
				log.Add(new LichSuNhanVien(nvCu, 2, nvCu.HoTen + " -> " + nvMoi.HoTen));
			if (nvCu.CMND != nvMoi.CMND)
				log.Add(new LichSuNhanVien(nvCu, 3, nvCu.CMND + " -> " + nvMoi.CMND));
			if (nvCu.NgaySinh != nvMoi.NgaySinh)
				log.Add(new LichSuNhanVien(nvCu, 4, nvCu.NgaySinh + " -> " + nvMoi.NgaySinh));
			if (nvCu.SoDienThoai != nvMoi.SoDienThoai)
				log.Add(new LichSuNhanVien(nvCu, 5, nvCu.SoDienThoai + " -> " + nvMoi.SoDienThoai));
			if (nvCu.GetType() != nvMoi.GetType())
				log.Add(new LichSuNhanVien(nvCu, 6, nvCu.GetType().ToString() + " -> " + nvMoi.GetType().ToString()));
			if (nvCu.MatKhau != nvMoi.MatKhau)
				log.Add(new LichSuNhanVien(nvCu, 7, "******** -> ********"));
			if (nvCu.NgayVaoLam != nvMoi.NgayVaoLam)
				log.Add(new LichSuNhanVien(nvCu, 8, nvCu.NgayVaoLam + " -> " + nvMoi.NgayVaoLam));
			nvMoi.MSNV = nvCu.MSNV;
			try
			{
				for (int i = 0; i < log.Count; i++)
				{
					LICH_SU_NHAN_VIEN.insert((LICH_SU_NHAN_VIEN)Util.AdapterObjectToDB(log[i]));
				}
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public static bool ThemNhanVien(NhanVien nv, string ghiChu)
		{
			LichSuNhanVien lsnv = new LichSuNhanVien(nv, 0, "Add Employee " + ghiChu);
			LICH_SU_NHAN_VIEN.insert((LICH_SU_NHAN_VIEN)Util.AdapterObjectToDB(lsnv));
			return true;
		}

		public static bool SaThaiNhanVien(NhanVien nv, string ghiChu)
		{
			LichSuNhanVien lsnv = new LichSuNhanVien(nv, -1, "Leave Out Employee " + ghiChu);
			LICH_SU_NHAN_VIEN.insert((LICH_SU_NHAN_VIEN)Util.AdapterObjectToDB(lsnv));
			return true;
		}

		public bool ThayDoiGhiChu(string ghiChu)
		{
			this.GhiChu = ghiChu;
			LICH_SU_NHAN_VIEN.update((LICH_SU_NHAN_VIEN)Util.AdapterObjectToDB(this));
			return true;
		}

		//	Get/Set accessor
		public int MSNV
		{
			get; set;
		}

		public int MaLichSu
		{
			get; set;
		}

		public int MSNVThucHien
		{
			get; set;
		}

		public DateTime ThoiGian
		{
			get; set;
		}

		public string GhiChu
		{
			get; set;
		}

	}
}
