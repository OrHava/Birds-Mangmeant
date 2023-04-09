namespace Birds_Mangmeant
{
	partial class Home
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
			button1 = new Button();
			toolStrip1 = new ToolStrip();
			toolStripSeparator1 = new ToolStripSeparator();
			toolStripButton1 = new ToolStripButton();
			toolStripSeparator2 = new ToolStripSeparator();
			toolStripButton2 = new ToolStripButton();
			toolStripSeparator3 = new ToolStripSeparator();
			toolStripButton3 = new ToolStripButton();
			toolStripSeparator4 = new ToolStripSeparator();
			toolStripButton4 = new ToolStripButton();
			backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			toolStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(569, 149);
			button1.Name = "button1";
			button1.Size = new Size(120, 38);
			button1.TabIndex = 0;
			button1.Text = "Return to login";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// toolStrip1
			// 
			toolStrip1.ImageScalingSize = new Size(20, 20);
			toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, toolStripButton1, toolStripSeparator2, toolStripButton2, toolStripSeparator3, toolStripButton3, toolStripSeparator4, toolStripButton4 });
			toolStrip1.Location = new Point(0, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(1282, 27);
			toolStrip1.TabIndex = 1;
			toolStrip1.Text = "toolStrip1";
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(6, 27);
			// 
			// toolStripButton1
			// 
			toolStripButton1.Image = Properties.Resources.icons8_home_page_48;
			toolStripButton1.ImageTransparentColor = Color.Magenta;
			toolStripButton1.Name = "toolStripButton1";
			toolStripButton1.Size = new Size(74, 24);
			toolStripButton1.Text = "Home";
			// 
			// toolStripSeparator2
			// 
			toolStripSeparator2.Name = "toolStripSeparator2";
			toolStripSeparator2.Size = new Size(6, 27);
			// 
			// toolStripButton2
			// 
			toolStripButton2.Image = Properties.Resources.icons8_search_50;
			toolStripButton2.ImageTransparentColor = Color.Magenta;
			toolStripButton2.Name = "toolStripButton2";
			toolStripButton2.Size = new Size(77, 24);
			toolStripButton2.Text = "Search";
			// 
			// toolStripSeparator3
			// 
			toolStripSeparator3.Name = "toolStripSeparator3";
			toolStripSeparator3.Size = new Size(6, 27);
			// 
			// toolStripButton3
			// 
			toolStripButton3.Image = Properties.Resources.icons8_help_60;
			toolStripButton3.ImageTransparentColor = Color.Magenta;
			toolStripButton3.Name = "toolStripButton3";
			toolStripButton3.Size = new Size(65, 24);
			toolStripButton3.Text = "Help";
			// 
			// toolStripSeparator4
			// 
			toolStripSeparator4.Name = "toolStripSeparator4";
			toolStripSeparator4.Size = new Size(6, 27);
			// 
			// toolStripButton4
			// 
			toolStripButton4.Image = Properties.Resources.icons8_enter_60;
			toolStripButton4.ImageTransparentColor = Color.Magenta;
			toolStripButton4.Name = "toolStripButton4";
			toolStripButton4.Size = new Size(90, 24);
			toolStripButton4.Text = "Sign Out";
			toolStripButton4.Click += toolStripButton4_Click;
			// 
			// Home
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1282, 753);
			Controls.Add(toolStrip1);
			Controls.Add(button1);
			Name = "Home";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Home";
			FormClosed += Home_FormClosed;
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private ToolStrip toolStrip1;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripButton toolStripButton1;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripButton toolStripButton2;
		private ToolStripSeparator toolStripSeparator3;
		private ToolStripButton toolStripButton3;
		private ToolStripSeparator toolStripSeparator4;
		private ToolStripButton toolStripButton4;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
	}
}