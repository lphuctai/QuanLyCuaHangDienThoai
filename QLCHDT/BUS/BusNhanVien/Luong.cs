using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusNhanVien
{
	public class Luong
	{
		int msnv, luongThuong, tongGioCong, heSoLuong, tongLuong, xacNhanLuong;
		DateTime thoiGian;

		//	Process Salary
		public static int TinhLuong(NhanVien nv, DateTime thoiGian)
		{

			return 0;
		}

		//	Confirm Receive Salary
		public static bool XacNhanNhanLuong(NhanVien nv, DateTime thoiGian)
		{

			return false;
		}





		//	Get/Set accessor
		public int MSNV
		{
			get { return msnv; }
			set { msnv = value; }
		}

		public int LuongThuong
		{
			get { return luongThuong; }
			set { luongThuong = value; }
		}

		public int TongGioCong
		{
			get { return tongGioCong; }
			set { tongGioCong = value; }
		}

		public int HeSoLuong
		{
			get { return heSoLuong; }
			set { heSoLuong = value; }
		}

		public int TongLuong
		{
			get { return tongLuong; }
			set { tongLuong = value; }
		}
		
		public int XacNhanLuong
		{
			get { return xacNhanLuong; }
			set { xacNhanLuong = value; }
		}

		public DateTime ThoiGian
		{
			get { return thoiGian; }
			set { thoiGian = value; }
		}
    }
}
