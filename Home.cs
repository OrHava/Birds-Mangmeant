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

		// In your main form class
		public partial class MainForm : Form
		{
			// Create a list to keep track of all open forms
			private List<Form> openForms = new List<Form>();

			// Override the OnFormClosed method to remove the closed form from the list
			protected override void OnFormClosed(FormClosedEventArgs e)
			{
				base.OnFormClosed(e);

				openForms.Remove(this);
			}

			// Override the OnLoad method to add the main form to the list
			protected override void OnLoad(EventArgs e)
			{
				base.OnLoad(e);

				openForms.Add(this);
			}

			// Override the OnFormClosing method for the exit button
			protected override void OnFormClosing(FormClosingEventArgs e)
			{
				base.OnFormClosing(e);

				// Check if the user clicked the exit button
				if (e.CloseReason == CloseReason.UserClosing)
				{
					// Loop through all open forms and close them
					foreach (Form form in openForms)
					{
						form.Close();
					}
				}
			}
		}

	}
}
