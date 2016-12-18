using BUS.BusHoaDon;
using BUS.BusSanPham;
using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHDT.FormSanPham
{
	public partial class FormNhanBaoHanh : Form
	{
		public FormNhanBaoHanh()
		{
			InitializeComponent();
			cbbTrangThai.DataSource = new BindingList<TRANG_THAI_SAN_PHAM>(TrangThaiSanPham.LayTrangThaiSanPham());
			cbbTrangThai.DisplayMember = "TRANG_THAI";
			cbbTrangThai.ValueMember = "MA_TRANG_THAI";
			btnNhanBaoHanh.Enabled = false;
		}

		public static Button getButton()
		{
			System.Windows.Forms.Button tmp = new System.Windows.Forms.Button();
			tmp.Text = "Nhận B.Hành";
			tmp.Image = Properties.Resources.btnNhanBaoHanh;
			tmp.AutoSize = true;
			tmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			tmp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			tmp.ForeColor = System.Drawing.Color.White;
			tmp.Location = new System.Drawing.Point(23, 23);
			tmp.Size = new System.Drawing.Size(120, 120);
			tmp.Margin = new System.Windows.Forms.Padding(10);
			tmp.TabIndex = 0;
			tmp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			tmp.UseVisualStyleBackColor = false;
			tmp.Click += new System.EventHandler(btnSelected);
			return tmp;
		}

		private static void btnSelected(object sender, EventArgs e)
		{
			FormNhanBaoHanh formNhanBaoHanh = new FormNhanBaoHanh();
			formNhanBaoHanh.ShowDialog();
		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			string s = txtIMEI.Text;
			SAN_PHAM sp = SanPham.TimSanPham(s);
			if(sp == null)
			{
				//InitializeComponent();
				lbThongBao.Text = "!!!Không Tìm Thấy!!!";
				txtMaKho.Text = "";
				txtChiTietSanPham.Text = "";
				dtpNgayBatDauBaoHanh.Value = DateTime.Now;
				dtpNgayKetThucBaoHanh.Value = DateTime.Now;
				txtGiaBan.Text = "0";
				txtGiaMua.Text = "0";
				btnNhanBaoHanh.Enabled = false;
				return;
			}
			else
			{
				lbThongBao.Text = "!!!Đã Tìm Thấy!!!";
				txtMaKho.Text = sp.MA_KHO.ToString();
				txtChiTietSanPham.Text = ChiTietSanPham.LayChiTietSanPham(sp.MA_CHI_TIET_SAN_PHAM).DINH_DANH;
				dtpNgayBatDauBaoHanh.Value = Convert.ToDateTime(sp.NGAY_BAT_DAU_BAO_HANH);
				dtpNgayKetThucBaoHanh.Value = Convert.ToDateTime(sp.NGAY_KET_THUC_BAO_HANH);
				txtGiaBan.Text = sp.GIA_BAN.ToString();
				txtGiaMua.Text = sp.GIA_MUA.ToString();
				cbbTrangThai.SelectedValue = sp.TRANG_THAI;
				if((int)cbbTrangThai.SelectedValue == 1)
				{
					btnNhanBaoHanh.Enabled = true;
				}
			}
		}

		private void txtNhanBaoHanh_Click(object sender, EventArgs e)
		{
			string imei = txtIMEI.Text;
			string thongTinKhachHang = txtThongTinKhachHang.Text;
			int maHoaDon = BienNhan.GuiBaoHanh(imei, thongTinKhachHang);

			if (maHoaDon != 0)
			{
				MessageBox.Show("Nhận Bảo Hành Thành Công!\nMã Hóa Đơn Là: " + maHoaDon);
				btnNhanBaoHanh.Enabled = false;
			}
			else
				MessageBox.Show("Nhận Bảo Hành Thất Bại!");
		}
	}
}
