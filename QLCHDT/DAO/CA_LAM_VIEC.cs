namespace DAO
{
	using System;
	using System.Collections.Generic;
	using System.Data.SqlClient;

	public partial class CA_LAM_VIEC
    {
        public CA_LAM_VIEC()
        {
			CA = 0;
			GIO = 0;
			BAT_DAU = DateTime.Now.TimeOfDay;
			KET_THUC = DateTime.Now.TimeOfDay;
		}
    
        public int CA { get; set; }
        public int GIO { get; set; }
		public TimeSpan BAT_DAU { get; set; }
		public TimeSpan KET_THUC { get; set; }

		public static List<CA_LAM_VIEC> select(string cond)
		{
			string query = "select * from CA_LAM_VIEC " + cond + " ";
			SqlDataReader reader = Connect.select(query);
			List<CA_LAM_VIEC> clv = new List<CA_LAM_VIEC>();
			while(reader.Read())
			{
				CA_LAM_VIEC tmp = new CA_LAM_VIEC();
				tmp.CA = reader.GetInt32(0);
				tmp.GIO = reader.GetInt32(1);
				tmp.BAT_DAU = reader.GetTimeSpan(2);
				tmp.KET_THUC = reader.GetTimeSpan(3);
				clv.Add(tmp);
			}
			return clv;
		}

		public static int insert(CA_LAM_VIEC clv)
		{
			string query = "insert into CA_LAM_VIEC values( " + clv.GIO
				+ " , '" + clv.BAT_DAU
				+ "' , '" + clv.KET_THUC
				+ "' ) ";
			return Connect.sendQuery(query);
		}

		public static int update(CA_LAM_VIEC clv)
		{
			string query = "update CA_LAM_VIEC set BAT_DAU = '" + clv.BAT_DAU
				+ "' , KET_THUC = '" + clv.KET_THUC
				+ "' , GIO = " + clv.GIO 
				+ " where CA = " + clv.CA;
			return Connect.sendQuery(query);
		}

		public static int delete(int ca)
		{
			string query = "delete from CA_LAM_VIEC where CA = " + ca + " ";
			return Connect.sendQuery(query);
		}
	}
}
