using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BUS.BusPhanCa;
using BUS.BusSanPham;

namespace BUS.BusNhanVien
{
	public class QuanLy : NhanVien
	{
		public QuanLy()
			:base()
		{
		}

		//	Create New Employee
		public static int ThemNhanVien(NHAN_VIEN nv, string ghiChu)
		{
			try
			{
				int msnv = NHAN_VIEN.insert(nv);
				LichSuNhanVien.ThemNhanVien(msnv, ghiChu);
				return msnv;
			}
			catch(Exception)
			{
				return 0;
			}
		}

		//	Employee leave
		public static bool SaThaiNhanVien(int msnv, string ghiChu)
		{
			LichSuNhanVien.SaThaiNhanVien(msnv, ghiChu);
			NHAN_VIEN nv = NHAN_VIEN.select(" where MSNV = " + msnv)[0];
			nv.TRANG_THAI = 0;
			NHAN_VIEN.update(nv);
			return true;
		}
		
		public bool ThemCaLamViec(PHAN_CA pc)
		{
			return PhanCa.ThemCaLamViec(pc);
		}

		public bool XacNhanCaLamViec(PHAN_CA pc)
		{
			return PhanCa.XacNhanCaLamViec(pc);
		}

		public bool XoaCaLamViec(PHAN_CA pc)
		{
			return PhanCa.XoaCaLamViec(pc);
		}

		//	Not Finish
		public bool ThemChiTietSanPham(CHI_TIET_SAN_PHAM ctsp)
		{
			return ChiTietSanPham.ThemChiTietSanPham(ctsp);
		}
	}
}
