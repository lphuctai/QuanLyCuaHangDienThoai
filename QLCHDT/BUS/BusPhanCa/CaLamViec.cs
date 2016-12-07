using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusPhanCa
{
	public class CaLamViec
	{

		public CaLamViec()
		{
		}

		public static int LaySoLuongCa()
		{
			return CA_LAM_VIEC.select("").Count;
		}
	}
}
