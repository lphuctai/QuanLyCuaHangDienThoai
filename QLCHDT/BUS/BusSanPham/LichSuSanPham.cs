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

		public LichSuSanPham(LICH_SU_SAN_PHAM lssp)
		{
			IMEI = lssp.IMEI;
			GhiChu = lssp.GHI_CHU;
			ThoiGian = lssp.THOI_GIAN;
			MaLichSu = lssp.MA_LICH_SU;
			MSNVThucHien = Convert.ToInt32(lssp.MSNV_THUC_HIEN);
		}

		public LichSuSanPham(SanPham sp, int maLichSu, string ghiChu)
		{
			this.IMEI = sp.IMEI;
			this.MaLichSu = maLichSu;
			this.GhiChu = ghiChu;
			this.ThoiGian = DateTime.Now;
			this.MSNVThucHien = Init.nhanVien.MSNV;
		}

		public static bool ThemSanPham(SanPham sp, string ghiChu)
		{
			LichSuSanPham lssp = new LichSuSanPham(sp, 0, "Add Product " + ghiChu);
			LICH_SU_SAN_PHAM.insert((LICH_SU_SAN_PHAM)Util.AdapterObjectToDB(lssp));
			return true;
		}

		public static bool ThanhToan(SanPham cu, SanPham moi)
		{
			List<LichSuSanPham> log = new List<LichSuSanPham>();
			if (cu.MaChiTietSanPham != moi.MaChiTietSanPham)
				log.Add(new LichSuSanPham(cu, 2, cu.MaChiTietSanPham + " -> " + moi.MaChiTietSanPham));
			if (cu.NgayBatDauBaoHanh != moi.NgayBatDauBaoHanh)
				log.Add(new LichSuSanPham(cu, 3, (cu.NgayBatDauBaoHanh != null? cu.NgayBatDauBaoHanh.ToString():"") + " -> " + moi.NgayBatDauBaoHanh));
			if (cu.NgayKetThucBaoHanh != moi.NgayKetThucBaoHanh)
				log.Add(new LichSuSanPham(cu, 4, (cu.NgayKetThucBaoHanh != null ? cu.NgayKetThucBaoHanh.ToString() : "") + " -> " + moi.NgayKetThucBaoHanh));
			if (cu.TrangThai != moi.TrangThai)
				log.Add(new LichSuSanPham(cu, 5, cu.TrangThai + " -> " + moi.TrangThai));
			if (cu.GiaMua != moi.GiaMua)
				log.Add(new LichSuSanPham(cu, 6, cu.GiaMua + " -> " + moi.GiaMua));
			if (cu.GiaBan != moi.GiaBan)
				log.Add(new LichSuSanPham(cu, 7, cu.GiaBan + " -> " + moi.GiaBan));
			if (cu.GhiChu != moi.GhiChu)
				log.Add(new LichSuSanPham(cu, 8, cu.GhiChu + " -> " + moi.GhiChu));
			moi.IMEI = cu.IMEI;
			try
			{
				for (int i = 0; i < log.Count; i++)
				{
					LICH_SU_SAN_PHAM.insert((LICH_SU_SAN_PHAM)Util.AdapterObjectToDB(moi));
				}
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public static bool GuiBaoHanh(SanPham sp)
		{
			if (sp.TrangThai == 2)
				return false;
			LichSuSanPham lssp = new LichSuSanPham(sp, 5, sp.TrangThai + " -> 2");
			LICH_SU_SAN_PHAM.insert((LICH_SU_SAN_PHAM)Util.AdapterObjectToDB(lssp));
			return true;
		}

		public static bool NhanBaoHanh(SanPham sp)
		{
			if (sp.TrangThai == 1 || sp.TrangThai == 0)
				return false;
			LichSuSanPham lssp = new LichSuSanPham(sp, 5, sp.TrangThai + " -> 1");
			LICH_SU_SAN_PHAM.insert((LICH_SU_SAN_PHAM)Util.AdapterObjectToDB(lssp));
			return true;
		}


		//	Get/Set accessor
		public string IMEI
		{
			get; set;
		}

		public string GhiChu
		{
			get; set;
		}

		public DateTime ThoiGian
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
	}
}
