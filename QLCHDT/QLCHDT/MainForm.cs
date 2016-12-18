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
			AddHR("Tư Vấn Bán Hàng");
			AddButton(FormChamCong.getButton());
			AddButton(FormBanHang.getButton());
			AddButton(FormThayDoiThongTin.getButton());
			AddButton(FormKiemTraHangTon.getButton());
			if (chucVu == 1) //QL
			{
				AddHR("Nhân Sự");
				AddButton(FormAddUser.getButton());
				AddButton(FormSaThai.getButton());
				AddButton(FormPhanCa.getButton());
				AddButton(FormXacNhanCong.getButton());
				AddButton(FormLuong.getButton());
				AddHR("Đối Tác");
				AddButton(FormThemDoiTac.getButton());
				AddButton(FormThayDoiDoiTac.getButton());
				AddHR("Quản Lý Sản Phẩm");
				AddButton(FormThemChiTietSanPham.getButton());
				AddButton(FormThayDoiChiTietSanPham.getButton());
				AddButton(FormQuanLyHangSanXuat.getButton());
				AddButton(FormNhapHang.getButton());
				AddButton(FormThongKe.getButton());

			}
			else
			if (chucVu == 2) //TN
			{
				AddHR("Thu Ngân");
				AddButton(FormThayDoiChiTietSanPham.getButton());
				AddButton(FormThongKe.getButton());
			}
			else
			if (chucVu == 3) //HTKT
			{
				AddHR("Hỗ Trợ Kỹ Thuật");
				AddButton(FormNhanBaoHanh.getButton());
				AddButton(FormTraBaoHanh.getButton());
			}
			AddHR();
		}

		public void AddButton(Button btn)
		{
			this.FlowPanel.Controls.Add(btn);
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
