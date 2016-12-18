using BUS;
using BUS.BusNhanVien;
using BUS.BusPhanCa;
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

namespace QLCHDT.Cong
{
	public partial class FormLuong : Form
	{
		public FormLuong()
		{
			InitializeComponent();
			btnXacNhanNhanLuong.Enabled = false;
		}

		public static Button getButton()
		{
			System.Windows.Forms.Button tmp = new System.Windows.Forms.Button();
			tmp.Text = "Tính Lương";
			tmp.Image = Properties.Resources.btnBanHang;
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
			FormLuong formLuong = new FormLuong();
			formLuong.ShowDialog();
		}

		private void FormLuong_Load(object sender, EventArgs e)
		{
			dtpThoiGian.Value = DateTime.Now.AddMonths(-1);
		}
		
		private void dtpThoiGian_ValueChanged(object sender, EventArgs e)
		{
			LoadLuong();
		}

		private void LoadLuong()
		{
			DateTime thoiGian = dtpThoiGian.Value;
			DateTime ngayKetThuc = new DateTime(thoiGian.Year, thoiGian.Month, 1);
			ngayKetThuc = ngayKetThuc.AddMonths(1);
			BindingList<LUONG> list = Luong.LayBangLuong(thoiGian);
			if(list.Count == 0 && Util.CompareTime(ngayKetThuc, DateTime.Now) )
			{
				FormYeuCauTinhLuong formYeuCauTinhLuong = new FormYeuCauTinhLuong(thoiGian);
				formYeuCauTinhLuong.ShowDialog();
				LoadLuong(0);
				return;
			}
			dgvBangLuong.DataSource = list;
			ShowInfo();
		}

		private void LoadLuong(int t)
		{
			DateTime thoiGian = dtpThoiGian.Value;
			DateTime ngayKetThuc = new DateTime(thoiGian.Year, thoiGian.Month, 1);
			ngayKetThuc = ngayKetThuc.AddMonths(1);
			BindingList<LUONG> list = Luong.LayBangLuong(thoiGian);
			dgvBangLuong.DataSource = list;
			ShowInfo();
		}

		private void ShowInfo()
		{
			if (dgvBangLuong.RowCount <= 0)
				return;
			LUONG l;
			try
			{
				l = (LUONG)dgvBangLuong.SelectedRows[0].DataBoundItem;
			}
			catch(Exception)
			{
				return;
			}
			txtMSNV.Text = l.MSNV.ToString();
			txtHoTen.Text = NhanVien.LayHoTen(l.MSNV);
			txtTongLuongThuong.Text = l.TONG_LUONG.ToString();
			btnXacNhanNhanLuong.Enabled = ! (l.XAC_NHAN_LUONG == 1);
		}

		private void dgvBangLuong_SelectionChanged(object sender, EventArgs e)
		{
			ShowInfo();
		}

		private void btnXacNhanNhanLuong_Click(object sender, EventArgs e)
		{
			int msnv = Convert.ToInt32(txtMSNV.Text);
			DateTime thoiGian = dtpThoiGian.Value;

			if (Luong.XacNhanNhanLuong(msnv, thoiGian))
			{
				LUONG l = (LUONG)dgvBangLuong.SelectedRows[0].DataBoundItem;
				l.XAC_NHAN_LUONG = 1;
				object[] ls = new object[7];
				ls[0] = l.MSNV;
				ls[1] = l.THOI_GIAN;
				ls[2] = l.LUONG_THUONG;
				ls[3] = l.TONG_GIO_CONG;
				ls[4] = l.HE_SO_LUONG;
				ls[5] = l.TONG_LUONG;
				ls[6] = l.XAC_NHAN_LUONG;
				dgvBangLuong.SelectedRows[0].SetValues(ls);
				dgvBangLuong.Refresh();
                MessageBox.Show("Đã ghi nhận việc nhân viên đã nhận lương.");
				btnXacNhanNhanLuong.Enabled = false;

			}
			else
				MessageBox.Show("Việc ghi nhận xảy ra lỗi, vui lòng kiểm tra lại!");
		}
	}
}
