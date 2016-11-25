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
	public partial class FormChamCong : Form
	{
		public async Task Foo()
		{
			await Task.Delay(1000);
			this.Dispose();
		}

		public FormChamCong()
		{
			InitializeComponent();
		}

		private async void FormChamCong_Load(object sender, EventArgs e)
		{
			if (flowLayoutPanel1.Controls.Count == 0)
			{
				Console.WriteLine("run");
				Label lb = new Label();
				lb.Text = "Không Có Công Để Chấm";
				lb.ForeColor = Color.White;
				lb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
				flowLayoutPanel1.Controls.Add(lb);
				await Foo();
			}
		}
	}
}
