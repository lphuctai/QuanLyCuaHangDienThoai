using BUS.BusNhanVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
	public class Init
	{
		private static NhanVien _nhanVien = null;

		public static NhanVien nhanVien
		{
			get { return _nhanVien; }
			set { _nhanVien = value; }
		}
	}
}
