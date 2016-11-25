using BUS.BusDoiTac;
using BUS.BusHoaDon;
using BUS.BusNhanVien;
using BUS.BusPhanCa;
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
			if(obj.GetType() == typeof(PhanCa))
			{
				PhanCa pc = (PhanCa)obj;
				PHAN_CA tmp = new PHAN_CA();
				tmp.MSNV = pc.MSNV;
				tmp.CHAM_CONG = pc.ChamCong;
				tmp.CA = pc.Ca;
				tmp.XAC_NHAN_CONG = pc.XacNhanCong;
				return tmp;
			}
			if(obj.GetType() == typeof(DoiTacNhapHang))
			{
				DoiTacNhapHang dt = (DoiTacNhapHang)obj;
				DOI_TAC_NHAP_HANG tmp = new DOI_TAC_NHAP_HANG();
				tmp.MA_DOI_TAC = dt.MaDoiTac;
				tmp.MSNV_QUAN_LY = dt.MSNVQuanLy;
				tmp.SO_DIEN_THOAI = dt.SoDienThoai;
				tmp.THONG_TIN = dt.ThongTin;
				return tmp;
			}
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
					default:
						return null;
				}
                return tmp;
			}
			return null;
		}
	}
}
