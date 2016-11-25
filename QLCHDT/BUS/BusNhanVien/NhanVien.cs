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
		protected int msnv, trangThai;
		protected string hoTen, cmnd, soDienThoai, matKhau;
		protected DateTime ngaySinh, ngayVaoLam;
		
		//	Convert DB to Object
		protected NhanVien(NHAN_VIEN nv)
		{
			msnv = nv.MSNV;
			hoTen = nv.HO_TEN;
			cmnd = nv.CMND;
			trangThai = Convert.ToInt32(nv.TRANG_THAI);
			soDienThoai = nv.SO_DIEN_THOAI;
			matKhau = nv.MAT_KHAU;
			ngaySinh = Convert.ToDateTime(nv.NGAY_SINH);
			ngayVaoLam = Convert.ToDateTime(nv.NGAY_VAO_LAM);
		}

		//	Get Position of Employee
		public int getChucVu()
		{
			Type chucVu = this.GetType();
			if (chucVu == typeof(QuanLy))
				return 1;
			if (chucVu == typeof(ThuNgan))
				return 2;
			if (chucVu == typeof(HoTroKyThuat))
				return 3;
			if (chucVu == typeof(TuVanBanHang))
				return 4;
			return 0;
		}

		//	Create new object with exactly Employee
		public static NhanVien NhanVienFactory(NHAN_VIEN nv)
		{
			switch ((int)nv.CHUC_VU)
			{
				case 1:
					return new QuanLy(nv);
				case 2:
					return new ThuNgan(nv);
				case 3:
					return new HoTroKyThuat(nv);
				case 4:
					return new TuVanBanHang(nv);
				default:
					return null;
			}
		}

		//	Change Infomation of Employee
		public bool ThayDoiThongTin(NhanVien nv)
		{
			NhanVien nvCu = NhanVienFactory((from s in EntityConnect.getConnection().NHAN_VIEN
											 where s.MSNV == nv.MSNV select s).FirstOrDefault<NHAN_VIEN>());
			LichSuNhanVien.LuuLichSuNhanVien(nvCu, nv);
			EntityConnect.Update((NHAN_VIEN)Util.AdapterObjectToDB(nv));
			return EntityConnect.SaveChange() != 0;
		}




		//	Get/Set accessor
		public int MSNV
		{
			get { return msnv; }
			set { msnv = value; }
		}

		public string HoTen
		{
			get { return hoTen; }
			set { hoTen = value; }
		}

		public string CMND
		{
			get { return cmnd; }
			set { cmnd = value; }
		}

		public DateTime NgaySinh
		{
			get { return ngaySinh; }
			set { ngaySinh = value; }
		}

		public string SoDienThoai
		{
			get { return soDienThoai; }
			set { soDienThoai = value; }
		}

		public string MatKhau
		{
			get { return matKhau; }
			set { matKhau = value; }
		}

		public DateTime NgayVaoLam
		{
			get { return ngayVaoLam; }
			set { ngayVaoLam = value; }
		}

		public int TrangThai
		{
			get { return trangThai; }
			set { trangThai = value; }
		}
	}
}
