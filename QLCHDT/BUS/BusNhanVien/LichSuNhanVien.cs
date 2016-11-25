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
		private int msnv, maLichSu, msnvThucHien;
		private DateTime thoiGian;
		private string ghiChu;

		public static List<LichSuNhanVien> LayLichSuNhanVien(NhanVien nv)
		{
			var lsnvdb = (from s in EntityConnect.getConnection().LICH_SU_NHAN_VIEN where s.MSNV == nv.MSNV select s).ToList<LICH_SU_NHAN_VIEN>();
			List<LichSuNhanVien> lsnv = new List<LichSuNhanVien>();
			foreach (var i in lsnvdb)
				lsnv.Add(new LichSuNhanVien(i));
			return lsnv;
		}

		public LichSuNhanVien(NhanVien nv, DateTime thoiGian, int maLichSu, NhanVien nvThucHien, string ghiChu)
		{
			this.msnv = nv.MSNV;
			this.thoiGian = thoiGian;
			this.maLichSu = maLichSu;
			this.msnvThucHien = nvThucHien.MSNV;
			this.ghiChu = ghiChu;
		}

		public LichSuNhanVien(LICH_SU_NHAN_VIEN lsnv)
		{
			this.msnv = lsnv.MSNV;
			this.thoiGian = lsnv.THOI_GIAN;
			this.maLichSu = lsnv.MA_LICH_SU;
			this.msnvThucHien = Convert.ToInt32(lsnv.MSNV_THUC_HIEN);
			this.ghiChu = lsnv.GHI_CHU;
		}
		
		public static bool LuuLichSuNhanVien(NhanVien nvCu, NhanVien nvMoi)
		{
			List<LichSuNhanVien> log = new List<LichSuNhanVien>();
			if (nvCu.HoTen != nvMoi.HoTen)
				log.Add(new LichSuNhanVien(nvCu, DateTime.Now, 1, Init.nhanVien, nvCu.HoTen + " -> " + nvMoi.HoTen));
			if (nvCu.CMND != nvMoi.CMND)
				log.Add(new LichSuNhanVien(nvCu, DateTime.Now, 2, Init.nhanVien, nvCu.CMND + " -> " + nvMoi.CMND));
			if (nvCu.NgaySinh != nvMoi.NgaySinh)
				log.Add(new LichSuNhanVien(nvCu, DateTime.Now, 3, Init.nhanVien, nvCu.NgaySinh + " -> " + nvMoi.NgaySinh));
			if (nvCu.SoDienThoai != nvMoi.SoDienThoai)
				log.Add(new LichSuNhanVien(nvCu, DateTime.Now, 4, Init.nhanVien, nvCu.SoDienThoai + " -> " + nvMoi.SoDienThoai));
			if (nvCu.GetType() != nvMoi.GetType())
				log.Add(new LichSuNhanVien(nvCu, DateTime.Now, 5, Init.nhanVien, nvCu.GetType().ToString() + " -> " + nvMoi.GetType().ToString()));
			if (nvCu.MatKhau != nvMoi.MatKhau)
				log.Add(new LichSuNhanVien(nvCu, DateTime.Now, 5, Init.nhanVien, "******** -> ********"));
			if (nvCu.NgayVaoLam != nvMoi.NgayVaoLam)
				log.Add(new LichSuNhanVien(nvCu, DateTime.Now, 6, Init.nhanVien, nvCu.NgayVaoLam + " -> " + nvMoi.NgayVaoLam));
			if (nvCu.TrangThai != nvMoi.TrangThai)
				log.Add(new LichSuNhanVien(nvCu, DateTime.Now, 7, Init.nhanVien, nvCu.TrangThai + " -> " + nvMoi.TrangThai));
			nvMoi.MSNV = nvCu.MSNV;
			try
			{
				for (int i = 0; i < log.Count; i++)
				{
					EntityConnect.getConnection().LICH_SU_NHAN_VIEN.Add((LICH_SU_NHAN_VIEN)Util.AdapterObjectToDB(log[i]));
				}
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public bool ThayDoiGhiChu(string ghiChu)
		{
			this.GhiChu = ghiChu;
			EntityConnect.Update(this);
			return EntityConnect.SaveChange() == 1;
		}

		//	Get/Set accessor
		public int MSNV
		{
			get { return msnv; }
			set { msnv = value; }
		}

		public int MaLichSu
		{
			get { return maLichSu; }
			set { maLichSu = value; }
		}

		public int MSNVThucHien
		{
			get { return msnvThucHien; }
			set { msnvThucHien = value; }
		}

		public DateTime ThoiGian
		{
			get { return thoiGian; }
			set { thoiGian = value; }
		}

		public string GhiChu
		{
			get { return ghiChu; }
			set { ghiChu = value; }
		}

	}
}
