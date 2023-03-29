namespace Birds_Mangmeant
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}



		private void closebtn_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void textBox1_Click(object sender, EventArgs e)
		{
			textBox1Save.BackColor = Color.White;
			panel3Save.BackColor = Color.White;
			panel4Save.BackColor = SystemColors.Control;
			textBox2Save.BackColor = SystemColors.Control;
		}

		private void textBox2_Click(object sender, EventArgs e)
		{
			textBox2Save.BackColor = Color.White;
			panel4Save.BackColor = Color.White;
			textBox1Save.BackColor = SystemColors.Control;
			panel3Save.BackColor = SystemColors.Control;

		}

		private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
		{
			textBox2Save.UseSystemPasswordChar = false;
		}

		private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
		{
			textBox2Save.UseSystemPasswordChar = true;
		}

		private void btnRegisterSave_Click(object sender, EventArgs e)
		{


			PanelRegister.Height = PanelLoginSave.Height;

			PanelLoginSave.Location = new Point(300, 0);



		}

	

		private void BtnReturnLogin_Click_1(object sender, EventArgs e)
		{
			PanelRegister.Height = 0;

			PanelLoginSave.Location = new Point(300, 0);
		}
	}
}