using BUS.BusNhanVien;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
	public class Init
	{
		private static NHAN_VIEN _nhanVien;
		public static NHAN_VIEN nhanVien
		{
			get
			{
				return _nhanVien;
			}
			set
			{
				_nhanVien = value;
			}
		}
	}
}
