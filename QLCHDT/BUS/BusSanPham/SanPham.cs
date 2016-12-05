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

		public SanPham(string imei, int maChiTietSanPham)
		{
			IMEI = imei;
			MaChiTietSanPham = maChiTietSanPham;
			TrangThai = 0;
		}

		public SanPham(SAN_PHAM dt)
		{
			IMEI = dt.IMEI;
			GhiChu = dt.GHI_CHU;
			MaChiTietSanPham = Convert.ToInt32(dt.MA_CHI_TIET_SAN_PHAM);
			TrangThai = dt.TRANG_THAI;
			GiaMua = Convert.ToInt32(dt.GIA_MUA);
			GiaBan = Convert.ToInt32(dt.GIA_BAN);
			NgayBatDauBaoHanh = Convert.ToDateTime(dt.NGAY_BAT_DAU_BAO_HANH);
			NgayKetThucBaoHanh = Convert.ToDateTime(dt.NGAY_KET_THUC_BAO_HANG);
		}

		public bool ThayDoiGhiChu(string ghiChu)
		{
			this.GhiChu = ghiChu;
			NHAN_VIEN.update((NHAN_VIEN)Util.AdapterObjectToDB(this));
			return true;
		}

		public static bool ThanhToan(SanPham sp, string ghiChu)
		{
			if (sp.TrangThai == 1)
				return false;
			ChiTietSanPham ctsp;
            try
			{
				ctsp = new ChiTietSanPham(CHI_TIET_SAN_PHAM.select(" where MA_CHI_TIET_SAN_PHAM = " + sp.MaChiTietSanPham)[0]);
			}
			catch(Exception)
			{
				return false;
			}
			SanPham tmp = sp;
			// Doing
			tmp.TrangThai = 1;
			tmp.GhiChu = ghiChu;
			tmp.GiaBan = ctsp.GiaBan;
			tmp.GiaMua = ctsp.GiaMua;
			tmp.NgayBatDauBaoHanh = DateTime.Now;
			tmp.NgayKetThucBaoHanh = new DateTime(DateTime.Now.AddMonths(ctsp.ThoiGianBaoHanh).Year
				, DateTime.Now.AddMonths(ctsp.ThoiGianBaoHanh).Month, DateTime.Now.Day);

			LichSuSanPham.ThanhToan(sp, tmp);
			if (ChiTietSanPham.ThanhToan(ctsp.MaChiTietSanPham) == false)
			{
				LichSuSanPham.ThanhToan(tmp, sp);
				return false;
			}
			SAN_PHAM.update((SAN_PHAM)Util.AdapterObjectToDB(tmp));
			return true;
		}

		public static bool ThemSanPham(SanPham sp)
		{
			SanPham tmp = new SanPham(sp.IMEI, sp.MaChiTietSanPham);
			LichSuSanPham.ThemSanPham(tmp, sp.GhiChu);
			SAN_PHAM.insert((SAN_PHAM)Util.AdapterObjectToDB(tmp));
			return true;
		}

		public static bool GuiBaoHanh(SanPham sp)
		{
			if (sp.TrangThai == 0 || sp.TrangThai == 2)
				return false;
			sp.TrangThai = 2;
			LichSuSanPham.GuiBaoHanh(sp);
			SAN_PHAM.update((SAN_PHAM)Util.AdapterObjectToDB(sp));
			return true;
		}

		public static bool NhanBaoHanh(SanPham sp)
		{
			if (sp.TrangThai == 0 || sp.TrangThai == 1)
				return false;
			sp.TrangThai = 1;
			LichSuSanPham.NhanBaoHanh(sp);
			SAN_PHAM.update((SAN_PHAM)Util.AdapterObjectToDB(sp));
			return true;
		}

		public static SanPham LaySanPham(string imei)
		{
			try
			{
				return new SanPham(SAN_PHAM.select(" where IMEI = " + imei)[0]);
			}
			catch(Exception)
			{
				return null;
			}
		}


		//	Get/Set accessor
		public string GhiChu
		{
			get; set;
		}

		public int GiaBan
		{
			get; set;
		}

		public int GiaMua
		{
			get; set;
		}

		public string IMEI
		{
			get; set;
		}

		public int MaChiTietSanPham
		{
			get; set;
		}

		public DateTime NgayBatDauBaoHanh
		{
			get; set;
		}

		public DateTime NgayKetThucBaoHanh
		{
			get; set;
		}

		public int TrangThai
		{
			get; set;
		}
	}
}
