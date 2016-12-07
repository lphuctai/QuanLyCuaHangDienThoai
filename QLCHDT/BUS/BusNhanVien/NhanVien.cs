﻿using BUS.BusPhanCa;
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
		protected NhanVien()
		{
		}

		//	Get Position of Employee
		public static int getChucVu(int user)
		{
			try
			{
				return NHAN_VIEN.select(" where MSNV = " + user + " ")[0].MSNV;
			}
			catch(Exception)
			{
				return 0;
			}
		}

		//	Create new object with exactly Employee
		public static NhanVien NhanVienFactory(NHAN_VIEN nv)
		{
			switch ((int)nv.CHUC_VU)
			{
				case 1:
					return new QuanLy();
				case 2:
					return new ThuNgan();
				case 3:
					return new HoTroKyThuat();
				case 4:
					return new TuVanBanHang();
				default:
					return null;
			}
		}

		//	Change Infomation of Employee
		public bool ThayDoiThongTin(NHAN_VIEN nv)
		{
			if (Init.nhanVien.MSNV != nv.MSNV)
				return false;
			NHAN_VIEN nvCu;
			try
			{
				nvCu = NHAN_VIEN.select(" where MSNV = " + nv.MSNV)[0];
			}
			catch(Exception)
			{
				return false;
			}
			LichSuNhanVien.ThayDoiThongTin(nvCu, nv);
			NHAN_VIEN.update(nv);
			return true;
		}

		//	Timekeeping
		public static bool ChamCongHangNgay(PHAN_CA pc)
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
				tmp = NHAN_VIEN.select(" where MSNV = " + user + " and TRANG_THAI > 0 ")[0];
			}
			catch(Exception)
			{
				tmp = null;
			}
            if (tmp != null && tmp.MAT_KHAU == matKhau)
			{
				Init.nhanVien = tmp;
				return true;
			}
			return false;
		}

		public static List<NHAN_VIEN> LayDanhSachNhanVien()
		{
			return NHAN_VIEN.select(" where TRANG_THAI = 1 ");
		}
	}
}
