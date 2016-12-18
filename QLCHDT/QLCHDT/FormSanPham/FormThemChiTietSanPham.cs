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
	public partial class FormThemChiTietSanPham : Form
	{
		public FormThemChiTietSanPham()
		{
			InitializeComponent();
		}
		
		public static Button getButton()
		{
			System.Windows.Forms.Button tmp = new System.Windows.Forms.Button();
			tmp.Text = "Thêm CTSP";
			tmp.Image = Properties.Resources.btnThemChiTietSanPham;
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
			FormThemChiTietSanPham formThemChiTietSanPham = new FormThemChiTietSanPham();
			formThemChiTietSanPham.ShowDialog();
		}

		private void FormThemChiTietSanPham_Load(object sender, EventArgs e)
		{
			cbbHangSanXuat.DataSource = new BindingList<HANG_SAN_XUAT>(HangSanXuat.LayHangSanXuat());
			cbbHangSanXuat.DisplayMember = "HANG";
			cbbHangSanXuat.ValueMember = "MA_HANG";
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			CHI_TIET_SAN_PHAM ctsp = ChiTietSanPham.LayChiTietSanPham((int)cbbHangSanXuat.SelectedValue, 
				txtDongSanPham.Text, txtSoHieuSanPham.Text, txtTenSanPham.Text);
			if(ctsp != null)
			{
				MessageBox.Show("Thông tin thêm bị trùng!");
				return;
			}
			ctsp = new CHI_TIET_SAN_PHAM();
			ctsp.MA_HANG = (int)cbbHangSanXuat.SelectedValue;
			ctsp.DONG_SAN_PHAM = txtDongSanPham.Text;
			ctsp.SO_HIEU_SAN_PHAM = txtSoHieuSanPham.Text;
			ctsp.TEN_SAN_PHAM = txtTenSanPham.Text;
			ctsp.THONG_TIN_KY_THUAT = txtThongTinKyThuat.Text;
			ctsp.THONG_TIN_SAN_PHAM = txtThongTinSanPham.Text;
			ctsp.THOI_GIAN_BAO_HANH = Convert.ToInt32(nudThoiGianBaoHanh.Value);
			ctsp.GIA_BAN = Convert.ToInt32(txtGiaBan.Text);
			if (ChiTietSanPham.ThemChiTietSanPham(ctsp))
				MessageBox.Show("Thêm Thành Công!");
			else
				MessageBox.Show("Thêm Thất Bại!");
		}
	}
}
