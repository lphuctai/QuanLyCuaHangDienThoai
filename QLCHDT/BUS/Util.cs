using BUS.BusDoiTac;
using BUS.BusHoaDon;
using BUS.BusNhanVien;
using BUS.BusPhanCa;
using BUS.BusSanPham;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
	public class Util
	{
		//	Convert Object to Database Record
		public static object AdapterObjectToDB(object obj)
		{
			//BusNhanVien
			if (obj.GetType() == typeof(QuanLy) || obj.GetType() == typeof(ThuNgan) 
				|| obj.GetType() == typeof(HoTroKyThuat) || obj.GetType() == typeof(TuVanBanHang))
			{
				NhanVien nv = (NhanVien)obj;
				NHAN_VIEN tmp = new NHAN_VIEN();
				tmp.MSNV = nv.MSNV;
				tmp.HO_TEN = nv.HoTen;
				tmp.CMND = nv.CMND;
				tmp.NGAY_SINH = nv.NgaySinh;
				tmp.SO_DIEN_THOAI = nv.SoDienThoai;
				tmp.MAT_KHAU = nv.MatKhau;
				tmp.NGAY_VAO_LAM = nv.NgayVaoLam;
				tmp.TRANG_THAI = nv.TrangThai;
				tmp.CHUC_VU = nv.getChucVu();
				return tmp;
			}
			if(obj.GetType() == typeof(LichSuNhanVien))
			{
				LichSuNhanVien lsnv = (LichSuNhanVien)obj;
				LICH_SU_NHAN_VIEN tmp = new LICH_SU_NHAN_VIEN();
				tmp.MSNV = lsnv.MSNV;
				tmp.MA_LICH_SU = lsnv.MaLichSu;
				tmp.MSNV_THUC_HIEN = lsnv.MSNVThucHien;
				tmp.THOI_GIAN = lsnv.ThoiGian;
				tmp.GHI_CHU = lsnv.GhiChu;
				return tmp;
			}
			if(obj.GetType() == typeof(Luong))
			{
				Luong l = (Luong)obj;
				LUONG tmp = new LUONG();
				tmp.MSNV = l.MSNV;
				tmp.THOI_GIAN = l.ThoiGian;
				tmp.LUONG_THUONG = l.LuongThuong;
				tmp.TONG_GIO_CONG = l.TongGioCong;
				tmp.HE_SO_LUONG = l.HeSoLuong;
				tmp.TONG_LUONG = l.TongLuong;
				tmp.XAC_NHAN_LUONG = l.XacNhanLuong;
				return tmp;
			}

			//BusPhanCa
			if(obj.GetType() == typeof(PhanCa))
			{
				PhanCa pc = (PhanCa)obj;
				PHAN_CA tmp = new PHAN_CA();
				tmp.MSNV = pc.MSNV;
				tmp.THOI_GIAN = pc.ThoiGian;
				tmp.CHAM_CONG = pc.ChamCong;
				tmp.CA = pc.Ca;
				tmp.XAC_NHAN_CONG = pc.XacNhanCong;
				return tmp;
			}
			if(obj.GetType() == typeof(CaLamViec))
			{
				CA_LAM_VIEC tmp = new CA_LAM_VIEC();
				CaLamViec clv = (CaLamViec)obj;
				tmp.CA = clv.Ca;
				tmp.GIO = clv.Gio;
				return tmp;
			}

			//BusDoiTac
			if (obj.GetType() == typeof(DoiTacNhapHang))
			{
				DoiTacNhapHang dt = (DoiTacNhapHang)obj;
				DOI_TAC_NHAP_HANG tmp = new DOI_TAC_NHAP_HANG();
				tmp.MA_DOI_TAC = dt.MaDoiTac;
				tmp.MSNV_QUAN_LY = dt.MSNVQuanLy;
				tmp.SO_DIEN_THOAI = dt.SoDienThoai;
				tmp.THONG_TIN = dt.ThongTin;
				return tmp;
			}

			//BusHoaDon
			if (obj.GetType() == typeof(HoaDon) || obj.GetType() == typeof(PhieuNhap) 
				|| obj.GetType() == typeof(PhieuXuat) || obj.GetType() == typeof(BienNhan))
			{
				HOA_DON tmp = new HOA_DON();
				HoaDon hd = (HoaDon)obj;
				tmp.MA_HOA_DON = hd.MaHoaDon;
				tmp.MSNV_THUC_HIEN = hd.MSNVThucHien;
				tmp.GHI_CHU = hd.GhiChu;
				tmp.THOI_GIAN = hd.ThoiGian;
				tmp.LOAI_HOA_DON = hd.getLoaiHoaDon();
				switch (tmp.LOAI_HOA_DON)
				{
					case 1:
						PhieuNhap pn = (PhieuNhap)obj;
						tmp.TONG_CONG = pn.TongCong;
						tmp.MA_DOI_TAC = pn.MaDoiTac;
						break;
					case 2:
						PhieuXuat px = (PhieuXuat)obj;
						tmp.TONG_CONG = px.TongCong;
						tmp.THONG_TIN_KHACH_HANG = px.ThongTinKhachHang;
						break;
					case 3:
						BienNhan bn = (BienNhan)obj;
						tmp.THONG_TIN_KHACH_HANG = bn.ThongTinKhachHang;
						break;
					case 4:
						BienNhan bn1 = (BienNhan)obj;
						tmp.THONG_TIN_KHACH_HANG = bn1.ThongTinKhachHang;
						break;
					default:
						return null;
				}
                return tmp;
			}

			if(obj.GetType() == typeof(ChiTietHoaDon))
			{
				CHI_TIET_HOA_DON tmp = new CHI_TIET_HOA_DON();
				ChiTietHoaDon cthd = (ChiTietHoaDon)obj;
				tmp.MA_HOA_DON = cthd.MaHoaDon;
				tmp.IMEI = cthd.IMEI;
				tmp.GIA = cthd.Gia;
				tmp.GHI_CHU = cthd.GhiChu;
				return tmp;
            }

			//BusSanPham
			if (obj.GetType() == typeof(SanPham))
			{
				SAN_PHAM tmp = new SAN_PHAM();
				SanPham sp = (SanPham)obj;
				tmp.IMEI = sp.IMEI;
				tmp.MA_CHI_TIET_SAN_PHAM = sp.MaChiTietSanPham;
				tmp.TRANG_THAI = sp.TrangThai;
				if(tmp.TRANG_THAI == 1)
				{
					tmp.NGAY_BAT_DAU_BAO_HANH = sp.NgayBatDauBaoHanh;
					tmp.NGAY_KET_THUC_BAO_HANG = sp.NgayKetThucBaoHanh;
					tmp.GIA_MUA = sp.GiaMua;
					tmp.GIA_BAN = sp.GiaBan;
					tmp.GHI_CHU = sp.GhiChu;
				}
				return tmp;
			}
			if(obj.GetType() == typeof(LichSuSanPham))
			{
				LICH_SU_SAN_PHAM tmp = new LICH_SU_SAN_PHAM();
				LichSuSanPham lssp = (LichSuSanPham)obj;
				tmp.IMEI = lssp.IMEI;
				tmp.MA_LICH_SU = lssp.MaLichSu;
				tmp.MSNV_THUC_HIEN = lssp.MSNVThucHien;
				tmp.THOI_GIAN = lssp.ThoiGian;
				tmp.GHI_CHU = lssp.GhiChu;
				return tmp;
			}
			if (obj.GetType() == typeof(ChiTietSanPham))
			{
				CHI_TIET_SAN_PHAM tmp = new CHI_TIET_SAN_PHAM();
				ChiTietSanPham ctsp = (ChiTietSanPham)obj;
				tmp.MA_CHI_TIET_SAN_PHAM = ctsp.MaChiTietSanPham;
				tmp.MA_HANG = ctsp.MaHang;
				tmp.DONG_SAN_PHAM = ctsp.DongSanPham;
				tmp.SO_HIEU_SAN_PHAM = ctsp.SoHieuSanPham;
				tmp.TEN_SAN_PHAM = ctsp.TenSanPham;
				tmp.THONG_TIN_KY_THUAT = ctsp.ThongTinKyThuat;
				tmp.THONG_TIN_SAN_PHAM = ctsp.ThongTinSanPham;
				tmp.THOI_GIAN_BAO_HANH = ctsp.ThoiGianBaoHanh;
				tmp.GIA_BAN = ctsp.GiaBan;
				tmp.GIA_MUA = ctsp.GiaMua;
				tmp.CON_TON = ctsp.ConTon;
				tmp.GHI_CHU = ctsp.GhiChu;
				return tmp;
			}
			if(obj.GetType() == typeof(HangSanXuat))
			{
				HANG_SAN_XUAT tmp = new HANG_SAN_XUAT();
				HangSanXuat hsx = (HangSanXuat)obj;
				tmp.MA_HANG = hsx.MaHang;
				tmp.HANG = hsx.Hang;
				return tmp;
			}

			//
			return null;
		}

		public static bool CompareTime(DateTime a, DateTime b) // <=
		{
			if (a.Year > b.Year)
				return false;
			if (a.Month > b.Month)
				return false;
			if (a.Day > b.Day)
				return false;
			return true;
		}

	}
}
