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
	public partial class FormKiemTraHangTon : Form
	{
		public FormKiemTraHangTon()
		{
			InitializeComponent();
			cbbChiTietSanPham.DataSource = ChiTietSanPham.LayChiTietSanPham();
			cbbChiTietSanPham.DisplayMember = "DINH_DANH";
			cbbChiTietSanPham.ValueMember = "MA_CHI_TIET_SAN_PHAM";
		}

		public static Button getButton()
		{
			System.Windows.Forms.Button tmp = new System.Windows.Forms.Button();
			tmp.Text = "K.Tra H.Tồn";
			tmp.Image = Properties.Resources.btnKiemTraHangTon;
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
			FormKiemTraHangTon formKiemTraHangTon = new FormKiemTraHangTon();
			formKiemTraHangTon.ShowDialog();
		}

		private void FormKiemTraHangTon_Load(object sender, EventArgs e)
		{
			cbbChiTietSanPham_SelectedIndexChanged(sender, e);
		}

		private void cbbChiTietSanPham_SelectedIndexChanged(object sender, EventArgs e)
		{
			int maChiTietSanPham = (int)cbbChiTietSanPham.SelectedValue;
			CHI_TIET_SAN_PHAM ctsp = ChiTietSanPham.LayChiTietSanPham(maChiTietSanPham);
			int conTon = KhoHang.GetTonKho(maChiTietSanPham);
			Console.WriteLine(conTon);
			txtConLai.Text = conTon.ToString();
			txtGiaBan.Text = ctsp.GIA_BAN.ToString();
			txtThoiGianBaoHanh.Text = ctsp.THOI_GIAN_BAO_HANH.ToString();
			txtThongTinKyThuat.Text = ctsp.THONG_TIN_KY_THUAT;
			txtThongTinSanPham.Text = ctsp.THONG_TIN_SAN_PHAM;
		}
	}
}
