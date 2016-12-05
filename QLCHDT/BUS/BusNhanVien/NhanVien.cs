using BUS.BusPhanCa;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusNhanVien
{
	public abstract class NhanVien
	{
		//	Convert DB to Object
		protected NhanVien(NHAN_VIEN nv)
		{
			MSNV = nv.MSNV;
			HoTen = nv.HO_TEN;
			CMND = nv.CMND;
			TrangThai = Convert.ToInt32(nv.TRANG_THAI);
			SoDienThoai = nv.SO_DIEN_THOAI;
			MatKhau = nv.MAT_KHAU;
			NgaySinh = Convert.ToDateTime(nv.NGAY_SINH);
			NgayVaoLam = Convert.ToDateTime(nv.NGAY_VAO_LAM);
		}

		//	Get Position of Employee
		public int getChucVu()
		{
			Type chucVu = this.GetType();
			if (chucVu == typeof(QuanLy))
				return 1;
			if (chucVu == typeof(ThuNgan))
				return 2;
			if (chucVu == typeof(HoTroKyThuat))
				return 3;
			if (chucVu == typeof(TuVanBanHang))
				return 4;
			return 0;
		}

		//	Create new object with exactly Employee
		public static NhanVien NhanVienFactory(NHAN_VIEN nv)
		{
			switch ((int)nv.CHUC_VU)
			{
				case 1:
					return new QuanLy(nv);
				case 2:
					return new ThuNgan(nv);
				case 3:
					return new HoTroKyThuat(nv);
				case 4:
					return new TuVanBanHang(nv);
				default:
					return null;
			}
		}

		//	Change Infomation of Employee
		public bool ThayDoiThongTin(NhanVien nv)
		{
			if (Init.nhanVien.MSNV != nv.MSNV)
				return false;
			NhanVien nvCu;
			try
			{
				nvCu = NhanVienFactory(NHAN_VIEN.select(" where MSNV = " + nv.MSNV)[0]);
			}
			catch(Exception)
			{
				return false;
			}
			LichSuNhanVien.ThayDoiThongTin(nvCu, nv);
			NHAN_VIEN.update((NHAN_VIEN)Util.AdapterObjectToDB(nv));
			return true;
		}

		//	Timekeeping
		public static bool ChamCongHangNgay(PhanCa pc)
		{
			//Cham Cong
			return PhanCa.ChamCongHangNgay(pc);
		}

		public static bool Login(string tenDangNhap, string matKhau)
		{
			int user = 0;
			NHAN_VIEN tmp;
			try
			{
				user = Convert.ToInt32(tenDangNhap);
			}
			catch (Exception)
			{
				user = 0;
			}
			try
			{
				tmp = NHAN_VIEN.select(" where MSNV = " + user)[0];
			}
			catch(Exception)
			{
				tmp = null;
			}
            if (tmp != null && tmp.MAT_KHAU == matKhau)
			{
				Init.nhanVien = NhanVien.NhanVienFactory(tmp);
				return true;
			}
			return false;
		}

		//	Get/Set accessor
		public int MSNV
		{
			get; set;
		}

		public string HoTen
		{
			get; set;
		}

		public string CMND
		{
			get; set;
		}

		public DateTime NgaySinh
		{
			get; set;
		}

		public string SoDienThoai
		{
			get; set;
		}

		public string MatKhau
		{
			get; set;
		}

		public DateTime NgayVaoLam
		{
			get; set;
		}

		public int TrangThai
		{
			get; set;
		}
	}
}
