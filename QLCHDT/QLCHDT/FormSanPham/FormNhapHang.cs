using BUS;
using BUS.BusDoiTac;
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
	public partial class FormNhapHang : Form
	{
		public FormNhapHang()
		{
			InitializeComponent();
		}
		
		public static Button getButton()
		{
			System.Windows.Forms.Button tmp = new System.Windows.Forms.Button();
			tmp.Text = "Nhập Hàng";
			tmp.Image = Properties.Resources.btnThemSanPham;
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
			FormNhapHang formNhapHang = new FormNhapHang();
			formNhapHang.ShowDialog();
		}

		private void FormNhapHang_Load(object sender, EventArgs e)
		{
			cbbDoiTac.DataSource = new BindingList<DOI_TAC_NHAP_HANG>(DoiTacNhapHang.LayDoiTac());
			cbbDoiTac.DisplayMember = "THONG_TIN";
			cbbDoiTac.ValueMember = "MA_DOI_TAC";
			cbbChiTietSanPham.DataSource = new BindingList<CHI_TIET_SAN_PHAM>(ChiTietSanPham.LayChiTietSanPham());
			cbbChiTietSanPham.DisplayMember = "DINH_DANH";
			cbbChiTietSanPham.ValueMember = "MA_CHI_TIET_SAN_PHAM";
			try
			{
				int soLuong = Convert.ToInt32(txtSoLuong.Text);
				int count = flowPanel.Controls.Count;
				Console.WriteLine(soLuong + " " + count);
				btnThemSanPham.Enabled = (count < soLuong);
			}
			catch (Exception)
			{

			}
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			if (Convert.ToInt32(txtSoLuong.Text) != flowPanel.Controls.Count)
			{
				MessageBox.Show("Bạn chưa nhập đủ sản phẩm của đợt nhập hàng này!");
				return;
			}
			if (MessageBox.Show("Bạn có chắc chắn muốn thêm đợt nhập hàng này không?", "Xác Nhận Thêm", MessageBoxButtons.YesNo) == DialogResult.No)
				return;
			KHO_HANG kh = new KHO_HANG();
			if (cbbDoiTac.SelectedValue == null || cbbChiTietSanPham.SelectedValue == null)
				return;
			kh.MA_DOI_TAC = (int)cbbDoiTac.SelectedValue;
			kh.MA_CHI_TIET_SAN_PHAM = (int)cbbChiTietSanPham.SelectedValue;
			kh.THOI_GIAN = DateTime.Now;
			kh.GIA_MUA = Convert.ToInt32(txtGiaMua.Text);
			kh.SO_LUONG = Convert.ToInt32(txtSoLuong.Text);
			kh.CON_LAI = Convert.ToInt32(txtSoLuong.Text); ;
			kh.MSNV_THUC_HIEN = Init.nhanVien.MSNV;
			List<string> imei = new List<string>();
			for (int i = 0; i < flowPanel.Controls.Count; i++)
				imei.Add(((PanelSanPham)flowPanel.Controls[i]).getString());
			int maHoaDon = PhieuNhap.NhapHang(kh, imei);
            if (maHoaDon != 0)
			{
				MessageBox.Show("Nhập Hàng Thành Công!\nMã Hóa Đơn Là: " + maHoaDon);
				for (int i = 0; i < flowPanel.Controls.Count; i++)
					flowPanel.Controls[i].Dispose();
				flowPanel.Controls.Clear();
			}
			else
				MessageBox.Show("Nhập Hàng Thất Bại!");
		}

		private void btnThemSanPham_Click(object sender, EventArgs e)
		{
			string imei = txtIMEI.Text;
			SAN_PHAM sp = new SAN_PHAM(imei, 0);
			if (imei.Length > 0)
			{
				if (SanPham.LaySanPham(imei) == null)
				{
					for(int i = 0; i < flowPanel.Controls.Count; i ++)
					{
						PanelSanPham tmp = (PanelSanPham)flowPanel.Controls[i];
						if(tmp.getString() == imei)
						{
							MessageBox.Show("IMEI bị trùng rồi, bạn hãy nhập lại.");
							return;
						}
					}
					flowPanel.Controls.Add(new PanelSanPham(sp));
					txtIMEI.Text = "";
				}
				else
					MessageBox.Show("IMEI bị trùng rồi, bạn hãy nhập lại.");
			}
			else
				MessageBox.Show("Error!");
		}

		private void flowPanel_ControlAdded(object sender, ControlEventArgs e)
		{
			try
			{
				int soLuong = Convert.ToInt32(txtSoLuong.Text);
				int count = flowPanel.Controls.Count;
				Console.WriteLine(soLuong + " " + count);
				btnThemSanPham.Enabled = (count < soLuong);
			}
			catch (Exception)
			{

			}
		}

		private void flowPanel_ControlRemoved(object sender, ControlEventArgs e)
		{
			try
			{
				int soLuong = Convert.ToInt32(txtSoLuong.Text);
				int count = flowPanel.Controls.Count;
				Console.WriteLine(soLuong + " " + count);
				btnThemSanPham.Enabled = (count < soLuong);
			}
			catch (Exception)
			{

			}
		}

		private void txtSoLuong_TextChanged(object sender, EventArgs e)
		{
			try
			{
				int soLuong = Convert.ToInt32(txtSoLuong.Text);
				int count = flowPanel.Controls.Count;
				Console.WriteLine(soLuong + " " + count);
				btnThemSanPham.Enabled = (count < soLuong);
			}
			catch (Exception)
			{

			}
		}
	}
}
