namespace QLCHDT
{
	partial class PanelCong
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(222, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 33);
			this.button1.TabIndex = 0;
			this.button1.Text = "Chấm Công";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.Control;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.Location = new System.Drawing.Point(3, 9);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.label1.Size = new System.Drawing.Size(213, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Ca 1";
			// 
			// PanelCong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
			this.Name = "PanelCong";
			this.Size = new System.Drawing.Size(337, 40);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
	}
}
