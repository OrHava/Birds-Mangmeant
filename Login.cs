using FireSharp.Response;
using RestSharp.Extensions;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System;

using System.Text.RegularExpressions;
namespace Birds_Mangmeant
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
			PanelRegister.Height = 0;
			PanelLoginSave.Location = new Point(300, 0);
		}



		private void closebtn_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}



		private void textBox1_Click(object sender, EventArgs e)
		{
			txtLoginUserName.BackColor = Color.White;
			panel3Save.BackColor = Color.White;
			panel4Save.BackColor = SystemColors.Control;
			txtLoginPassword.BackColor = SystemColors.Control;
		}

		private void textBox2_Click(object sender, EventArgs e)
		{
			txtLoginPassword.BackColor = Color.White;
			panel4Save.BackColor = Color.White;
			txtLoginUserName.BackColor = SystemColors.Control;
			panel3Save.BackColor = SystemColors.Control;

		}

		private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
		{
			txtLoginPassword.UseSystemPasswordChar = false;
		}

		private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
		{
			txtLoginPassword.UseSystemPasswordChar = true;
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

		bool textDeleted = false;
		bool textDeleted1 = false;
		bool textDeleted2 = false;
		bool textDeleted3 = false;
		bool textDeleted4 = false;

		private void textBox7_Click(object sender, EventArgs e)
		{
			if (!textDeleted)
			{
				txtRegName.Text = "";
				textDeleted = true;
			}
		}



		private void textBox2_Click_1(object sender, EventArgs e)
		{
			if (!textDeleted1)
			{
				TxtRegEmail.Text = "";
				textDeleted1 = true;
			}

		}

		private void textBox1_Click_1(object sender, EventArgs e)
		{
			if (!textDeleted2)
			{
				txtRegPassword.Text = "";
				textDeleted2 = true;
			}
		}

		private void textBox8_Click(object sender, EventArgs e)
		{
			if (!textDeleted3)
			{
				txtRegRePassword.Text = "";
				textDeleted3 = true;
			}
		}

		private void txtRegId_Click(object sender, EventArgs e)
		{
			if (!textDeleted4)
			{
				txtRegId.Text = "";
				textDeleted4 = true;
			}
		}

		private void Login_Load(object sender, EventArgs e)
		{
			try
			{
				client = new FireSharp.FirebaseClient(config);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + "Check Your connection!");
			}

		}

		public static string email;
		public static string coins;


		private void button3_Click(object sender, EventArgs e)
		{

			int count = Regex.Matches(txtRegName.Text, @"\d").Count;


			bool isMatch = Regex.IsMatch(txtRegPassword.Text, @"^[a-zA-Z0-9\p{P}\p{S}]+$");
			bool containsDigit = Regex.IsMatch(txtRegPassword.Text, @"\d");
			bool containsSpecialChar = Regex.IsMatch(txtRegPassword.Text, @"[\W_]");
			bool containsLetter = Regex.IsMatch(txtRegPassword.Text, @"[a-zA-Z]");

			bool isValidEmail = Regex.IsMatch(TxtRegEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

			Regex regex = new Regex("[A-Za-z]"); // Regular expression to match English letters
			bool isEnglishOrNumber = Regex.IsMatch(txtRegName.Text, @"^[a-zA-Z0-9]+$");

			if (string.IsNullOrEmpty(txtRegId.Text) || string.IsNullOrEmpty(txtRegName.Text) || string.IsNullOrEmpty(TxtRegEmail.Text) || string.IsNullOrEmpty(txtRegPassword.Text) || string.IsNullOrEmpty(txtRegRePassword.Text))
			{
				MessageBox.Show("All fields must be filled!");
			}
			else if (txtRegId.Text == "Enter ID" || txtRegName.Text == "Enter UserName" || TxtRegEmail.Text == "Enter Email" || txtRegPassword.Text == "Enter Password" || txtRegRePassword.Text == "Re - Enter Password")
			{

				MessageBox.Show("Enter your details");
			}

			else if (!isValidEmail)
			{

				MessageBox.Show("Enter a valid email");
			}
			else if (!isEnglishOrNumber)
			{
				MessageBox.Show("User name can only contain english letters and numbers.");
			}
			else if (txtRegPassword.Text != txtRegRePassword.Text)
			{

				MessageBox.Show("Your Passwords dont match.");
			}
			else if (!isMatch)
			{
				MessageBox.Show("Your Passwords must only contain english letters.");
			}
			else if (!containsDigit)
			{
				MessageBox.Show("Your Passwords must contain at least one number ");

			}
			else if (!containsSpecialChar)
			{
				MessageBox.Show("Your Passwords must contain at least one special letter.");
			}

			else if (!containsLetter)
			{

				MessageBox.Show("Your Passwords must contain at least one english letter.");
			}
			else if (txtRegPassword.Text.Length < 8 || txtRegPassword.Text.Length > 10)
			{
				MessageBox.Show("Password need to be between 8 to 10 letters.");
			}

			else if (txtRegName.Text.Length > 8 || txtRegName.Text.Length < 6)
			{

				MessageBox.Show("User name need to be between 6 to 8 letters.");
			}
			else if (count > 2)
			{
				MessageBox.Show("User name can only contain less then two letters");

			}
			else
			{
				var register = new register
				{
					Name = txtRegName.Text,
					Password = txtRegPassword.Text,
					Email = TxtRegEmail.Text,
					ID = txtRegId.Text,
				};
				FirebaseResponse response = client.Set("users/" + txtRegName.Text, register);
				register res = response.ResultAs<register>();
				register todo = new register()
				{
					Email = TxtRegEmail.Text,
				};
				var setter = client.SetAsync("Rewards/" + TxtRegEmail.Top, todo);
				MessageBox.Show("Registered succesfully");
			}
		}

		private void button1Save_Click(object sender, EventArgs e)
		{

			if (string.IsNullOrEmpty(txtLoginUserName.Text) || string.IsNullOrEmpty(txtLoginPassword.Text))
			{
				MessageBox.Show("All fields must be filled!");
			}
			else
			{
				//string usernameres = null;
				List<Tuple<string, string>> usernameres = new List<Tuple<string, string>>();
				FirebaseResponse response = client.Get("users/");
				Dictionary<string, register> result = response.ResultAs<Dictionary<string, register>>();

				foreach (var get in result)
				{


					usernameres.Add(Tuple.Create(get.Value.Name, get.Value.Password));

				}

				if (usernameres.Contains(Tuple.Create(txtLoginUserName.Text, txtLoginPassword.Text)))
				{
					MessageBox.Show("Welcome " + txtLoginUserName.Text);
					Home hm = new Home();
					this.Hide();
					hm.ShowDialog();

				}

			}
		}


		void sendEMail(string email, string name, string password)
		{
			// configure the email message
			var fromAddress = new MailAddress("or6564444@gmail.com", "Birds Manager");
			var toAddress = new MailAddress(email, name);
			const string fromPassword = "nqutuiaebadyysvt";
			const string subject = "Password restore Request";
			string body = "Your password is: " + password;
			var smtp = new SmtpClient
			{
				Host = "smtp.gmail.com", // or the SMTP server of your email provider
				Port = 587,
				EnableSsl = true,
				DeliveryMethod = SmtpDeliveryMethod.Network,
				Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
				Timeout = 20000,

			};
			using (var message = new MailMessage(fromAddress, toAddress)
			{
				Subject = subject,
				Body = body
			})
			{
				smtp.Send(message);
				MessageBox.Show("Your Password was send to your Email, Make Sure to check your spam folder.");
			}
		}

		private void button2Save_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtLoginUserName.Text))
			{
				MessageBox.Show("All fields must be filled!");
			}
			else
			{
				//string usernameres = null;

				FirebaseResponse response2 = client.Get("users/");
				Dictionary<string, register> result = response2.ResultAs<Dictionary<string, register>>();

				foreach (var get in result)
				{

					if (get.Value.Name == txtLoginUserName.Text)
					{

						sendEMail(get.Value.Email, get.Value.Name, get.Value.Password);

						break;
					}


				}



			}

		}


	}
}