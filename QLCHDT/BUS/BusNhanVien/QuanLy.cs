using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BUS.BusNhanVien
{
	public class QuanLy : NhanVien
	{
		public QuanLy(NHAN_VIEN nv)
			:base(nv)
		{
		}

		//	Create New Employee
		public static bool ThemNhanVien(NhanVien nvThem)
		{
			if (Init.nhanVien.GetType() != typeof(QuanLy))
				return false;
			bool result = true;
			NHAN_VIEN tmp = (NHAN_VIEN)Util.AdapterObjectToDB(nvThem);
			EntityConnect.getConnection().NHAN_VIEN.Add(tmp);
			result &= (EntityConnect.SaveChange() == 1);
			EntityConnect.getConnection().LICH_SU_NHAN_VIEN.Add((LICH_SU_NHAN_VIEN)Util.AdapterObjectToDB
				(new LichSuNhanVien(NhanVien.NhanVienFactory(tmp), DateTime.Now, 0, Init.nhanVien, "Add New Employee")));
			result &= (EntityConnect.SaveChange() == 1);
			return result;
		}

		//	Employee leave
		public static bool NhanVienNghiViec(NhanVien nvNghiViec)
		{
			if (Init.nhanVien.GetType() != typeof(QuanLy))
				return false;
			bool result = true;
			NHAN_VIEN tmp = (NHAN_VIEN)Util.AdapterObjectToDB(nvNghiViec);
			EntityConnect.Update(tmp);
			result &= (EntityConnect.SaveChange() == 1);
			return result;
		}

		//	Not Finish
		public static bool NhapHang(/*DienThoai dt*/)
		{
			if (Init.nhanVien.GetType() != typeof(QuanLy))
				return false;
			return false;
		}

	}
}
