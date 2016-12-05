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
		public QuanLy(NHAN_VIEN nv)
			:base(nv)
		{
		}

		//	Create New Employee
		public bool ThemNhanVien(NhanVien nv, string ghiChu)
		{
			NHAN_VIEN tmp = (NHAN_VIEN)Util.AdapterObjectToDB(nv);
			NHAN_VIEN.insert(tmp);
			nv.MSNV = tmp.MSNV;
			LichSuNhanVien.ThemNhanVien(nv, ghiChu);
			return true;
		}

		//	Employee leave
		public bool SaThaiNhanVien(NhanVien nv, string ghiChu)
		{
			LichSuNhanVien.SaThaiNhanVien(nv, ghiChu);
			nv.TrangThai = 0;
			NHAN_VIEN.update((NHAN_VIEN)Util.AdapterObjectToDB(nv));
			return true;
		}
		
		public bool ThemCaLamViec(PhanCa pc)
		{
			return PhanCa.ThemCaLamViec(pc);
		}

		public bool XacNhanCaLamViec(PhanCa pc)
		{
			return PhanCa.XacNhanCaLamViec(pc);
		}

		public bool XoaCaLamViec(PhanCa pc)
		{
			return PhanCa.XoaCaLamViec(pc);
		}

		//	Not Finish
		public bool ThemChiTietSanPham(ChiTietSanPham ctsp)
		{
			return ChiTietSanPham.ThemChiTietSanPham(ctsp);
		}
	}
}
