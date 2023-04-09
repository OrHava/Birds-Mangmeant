using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birds_Mangmeant
{
	public partial class Home : Form
	{
		public Home()
		{
			InitializeComponent();
		}




		private void button1_Click(object sender, EventArgs e)
		{
			Login Lg = new Login();
			this.Hide();
			Lg.ShowDialog();
		}

		private void Home_FormClosed(object sender, FormClosedEventArgs e)
		{
			// Check if the user clicked the exit button
			if (e.CloseReason == CloseReason.UserClosing)
			{
				// Close all open forms except the main form
				foreach (Form form in Application.OpenForms)
				{
					if (form != this)
					{
						form.Close();
					}
				}
			}
		}

		private void toolStripButton4_Click(object sender, EventArgs e)
		{
			Login Lg = new Login();
			this.Hide();
			Lg.ShowDialog();
		}
	}
}
