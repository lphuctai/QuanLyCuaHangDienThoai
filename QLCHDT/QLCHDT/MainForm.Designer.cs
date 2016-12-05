namespace QLCHDT
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.FlowPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// FlowPanel
			// 
			this.FlowPanel.Location = new System.Drawing.Point(12, 12);
			this.FlowPanel.Name = "FlowPanel";
			this.FlowPanel.Padding = new System.Windows.Forms.Padding(20);
			this.FlowPanel.Size = new System.Drawing.Size(1310, 483);
			this.FlowPanel.TabIndex = 1;
			// 
			// btnExit
			// 
			this.btnExit.AutoSize = true;
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btnExit.ForeColor = System.Drawing.Color.White;
			this.btnExit.Image = global::QLCHDT.Properties.Resources.btnExit;
			this.btnExit.Location = new System.Drawing.Point(1202, 501);
			this.btnExit.Margin = new System.Windows.Forms.Padding(10);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(120, 120);
			this.btnExit.TabIndex = 0;
			this.btnExit.Text = "Thoát";
			this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(1334, 633);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.FlowPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.FlowLayoutPanel FlowPanel;
	}
}