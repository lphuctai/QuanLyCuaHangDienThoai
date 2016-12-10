using QLCHDT.Cong;
using QLCHDT.DoiTac;
using QLCHDT.FormSanPham;
using QLCHDT.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHDT
{
	public partial class MainForm : Form
	{
		public MainForm(int chucVu)
		{
			InitializeComponent();
			AddHR("Tiện Ích");
			AddButton("Chấm Công", FormChamCong.getIcon());
			AddButton("Thay Đổi Thông Tin", FormThayDoiThongTin.getIcon());
			if(chucVu == 1) //QL
			{
				AddHR("Nhân Sự");
				AddButton("Thêm NV", FormAddUser.getIcon());
				AddButton("Xoá NV", FormSaThai.getIcon());
				AddHR("Phân Ca");
				AddButton("Phân Ca", FormPhanCa.getIcon());
				AddButton("Xác Nhận Ca", FormXacNhanCong.getIcon());
				AddHR("Đối Tác");
				AddButton("Thêm Đối Tác", FormThemDoiTac.getIcon());
				AddButton("Thay Đổi Đối Tác", FormThayDoiDoiTac.getIcon());
				AddHR("Sản Phẩm");
				AddButton("Hãng Sản Xuất", FormQuanLyHangSanXuat.getIcon());
				AddButton("Nhập Hàng", FormNhapHang.getIcon());
				AddHR();

			}
			if (chucVu == 2) //TN
			{
			}

			if (chucVu == 3) //HTKT
			{
				AddButton("Nhận Bảo Hành", FormNhanBaoHanh.getIcon());
				AddButton("Trả Bảo Hành", FormTraBaoHanh.getIcon());
				AddButton("Bán Hàng", FormBanHang.getIcon());
			}
		}

		private void btnSelected(object sender, EventArgs e)
		{
			Button tmp = (Button)sender;
			switch (tmp.Text)
			{
				case "Chấm Công":
					new FormChamCong().ShowDialog(); break;
				case "Thêm NV":
					new FormAddUser().ShowDialog(); break;
				case "Xoá NV":
					new FormSaThai().ShowDialog(); break;
				case "Phân Ca":
					new FormPhanCa().ShowDialog(); break;
				case "Xác Nhận Ca":
					new FormXacNhanCong().ShowDialog(); break;
				case "Thay Đổi Thông Tin":
					new FormThayDoiThongTin().ShowDialog(); break;
				case "Thêm Đối Tác":
					new FormThemDoiTac().ShowDialog(); break;
				case "Thay Đổi Đối Tác":
					new FormThayDoiDoiTac().ShowDialog(); break;
				case "Hãng Sản Xuất":
					new FormQuanLyHangSanXuat().ShowDialog(); break;
				case "Nhập Hàng":
					new FormNhapHang().ShowDialog(); break;
				case "Nhận Bảo Hành":
					new FormNhanBaoHanh().ShowDialog(); break;
				case "Bán Hàng":
					new FormBanHang().ShowDialog(); break;
				case "Trả Bảo Hành":
					new FormTraBaoHanh().ShowDialog(); break;

			}
		}

		public void AddButton(string text, System.Drawing.Bitmap icon)
		{
			System.Windows.Forms.Button tmp = new System.Windows.Forms.Button();
			tmp.AutoSize = true;
			tmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			tmp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			tmp.ForeColor = System.Drawing.Color.White;
			tmp.Image = icon;
			tmp.Location = new System.Drawing.Point(23, 23);
			tmp.Size = new System.Drawing.Size(120, 120);
			tmp.Margin = new System.Windows.Forms.Padding(10);
			tmp.TabIndex = 0;
			tmp.Text = text;
			tmp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			tmp.UseVisualStyleBackColor = false;
			tmp.Click += new System.EventHandler(this.btnSelected);
			this.FlowPanel.Controls.Add(tmp);
		}

		public void AddHR()
		{
			this.FlowPanel.Controls.Add(new HR());
		}

		public void AddHR(string text)
		{
			this.FlowPanel.Controls.Add(new HR(text));
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
