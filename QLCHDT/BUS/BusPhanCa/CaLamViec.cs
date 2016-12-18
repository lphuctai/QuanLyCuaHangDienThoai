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
			return CA_LAM_VIEC.select(" ").Count;
		}

		private static List<int> caLamViec = null;
		private static void initLayGioCong()
		{
			List<CA_LAM_VIEC> clv = CA_LAM_VIEC.select(" ");
			caLamViec = new List<int>();
			for (int i = 0; i <= 100; i++)
				caLamViec.Add(0);
			for(int i = 0; i < clv.Count; i ++)
				caLamViec[clv[i].CA] = Convert.ToInt32(clv[i].GIO);
		}

		public static int LayGioCong(int ca)
		{
			if (caLamViec == null)
				initLayGioCong();
			return caLamViec[ca];
		}
	}
}
