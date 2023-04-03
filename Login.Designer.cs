
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using Firebase.Auth.Requests;
using FirebaseAdmin.Auth;
using Firebase.Auth;
using Firebase.Auth.Providers;
using Firebase.Auth.Repository;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using FireSharp;

namespace Birds_Mangmeant
{
	partial class Login
	{

		IFirebaseConfig config = new FirebaseConfig
		{
			AuthSecret = "X0ef9KE6sIzPgMR7rlUj52AWMITXNJXPEIMNKHF9",
			BasePath = "https://birds-mannagemeant-default-rtdb.firebaseio.com/"

		};
		IFirebaseClient client;

		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			PanelWelcomeSave = new Panel();
			labelDevs3Save = new Label();
			labelDevs4Save = new Label();
			labelDevs2Save = new Label();
			labelDevs1Save = new Label();
			labelWelcomeSave3 = new Label();
			labelWelcomeSave2 = new Label();
			labelWelcomeSave1 = new Label();
			pictureBoxBirdSave = new PictureBox();
			btnGoBackToLogin = new Button();
			linkLabel3 = new LinkLabel();
			label16 = new Label();
			label17 = new Label();
			label18 = new Label();
			button8 = new Button();
			button9 = new Button();
			panel9 = new Panel();
			textBox5 = new TextBox();
			pictureBox6 = new PictureBox();
			panel10 = new Panel();
			textBox6 = new TextBox();
			pictureBox7 = new PictureBox();
			label19 = new Label();
			button10 = new Button();
			button4 = new Button();
			linkLabel2 = new LinkLabel();
			label12 = new Label();
			label13 = new Label();
			label14 = new Label();
			button6 = new Button();
			panel6 = new Panel();
			textBox3 = new TextBox();
			pictureBox4 = new PictureBox();
			panel7 = new Panel();
			textBox4 = new TextBox();
			pictureBox5 = new PictureBox();
			label15 = new Label();
			button7 = new Button();
			PanelLoginSave = new Panel();
			PanelRegister = new Panel();
			panel5 = new Panel();
			txtRegId = new TextBox();
			pictureBox9 = new PictureBox();
			panel4 = new Panel();
			txtRegRePassword = new TextBox();
			pictureBox8 = new PictureBox();
			panel3 = new Panel();
			txtRegName = new TextBox();
			pictureBox3 = new PictureBox();
			button3 = new Button();
			panel1 = new Panel();
			txtRegPassword = new TextBox();
			pictureBox1 = new PictureBox();
			panel2 = new Panel();
			TxtRegEmail = new TextBox();
			pictureBox2 = new PictureBox();
			label1 = new Label();
			BtnReturnLogin = new Button();
			btnRegisterSave = new Button();
			linkLabel1Save = new LinkLabel();
			label11Save = new Label();
			label10Save = new Label();
			label9Save = new Label();
			button2Save = new Button();
			button1Save = new Button();
			panel4Save = new Panel();
			txtLoginPassword = new TextBox();
			pictureBox3Save = new PictureBox();
			panel3Save = new Panel();
			txtLoginUserName = new TextBox();
			pictureBoxSave = new PictureBox();
			labelLogin1Save = new Label();
			PanelWelcomeSave.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBoxBirdSave).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
			PanelLoginSave.SuspendLayout();
			PanelRegister.SuspendLayout();
			panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
			panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
			panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			panel4Save.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox3Save).BeginInit();
			panel3Save.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBoxSave).BeginInit();
			SuspendLayout();
			// 
			// PanelWelcomeSave
			// 
			PanelWelcomeSave.BackColor = Color.FromArgb(41, 128, 185);
			PanelWelcomeSave.Controls.Add(labelDevs3Save);
			PanelWelcomeSave.Controls.Add(labelDevs4Save);
			PanelWelcomeSave.Controls.Add(labelDevs2Save);
			PanelWelcomeSave.Controls.Add(labelDevs1Save);
			PanelWelcomeSave.Controls.Add(labelWelcomeSave3);
			PanelWelcomeSave.Controls.Add(labelWelcomeSave2);
			PanelWelcomeSave.Controls.Add(labelWelcomeSave1);
			PanelWelcomeSave.Controls.Add(pictureBoxBirdSave);
			PanelWelcomeSave.Dock = DockStyle.Left;
			PanelWelcomeSave.Location = new Point(0, 0);
			PanelWelcomeSave.Name = "PanelWelcomeSave";
			PanelWelcomeSave.Size = new Size(300, 530);
			PanelWelcomeSave.TabIndex = 0;
			// 
			// labelDevs3Save
			// 
			labelDevs3Save.AutoSize = true;
			labelDevs3Save.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
			labelDevs3Save.ForeColor = Color.White;
			labelDevs3Save.Location = new Point(217, 492);
			labelDevs3Save.Name = "labelDevs3Save";
			labelDevs3Save.Size = new Size(73, 17);
			labelDevs3Save.TabIndex = 7;
			labelDevs3Save.Text = "Gil Cohen";
			// 
			// labelDevs4Save
			// 
			labelDevs4Save.AutoSize = true;
			labelDevs4Save.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
			labelDevs4Save.ForeColor = Color.White;
			labelDevs4Save.Location = new Point(217, 509);
			labelDevs4Save.Name = "labelDevs4Save";
			labelDevs4Save.Size = new Size(68, 17);
			labelDevs4Save.TabIndex = 6;
			labelDevs4Save.Text = "Omer Shy";
			// 
			// labelDevs2Save
			// 
			labelDevs2Save.AutoSize = true;
			labelDevs2Save.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
			labelDevs2Save.ForeColor = Color.White;
			labelDevs2Save.Location = new Point(217, 475);
			labelDevs2Save.Name = "labelDevs2Save";
			labelDevs2Save.Size = new Size(62, 17);
			labelDevs2Save.TabIndex = 5;
			labelDevs2Save.Text = "Or Hava";
			// 
			// labelDevs1Save
			// 
			labelDevs1Save.AutoSize = true;
			labelDevs1Save.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
			labelDevs1Save.ForeColor = Color.White;
			labelDevs1Save.Location = new Point(214, 457);
			labelDevs1Save.Name = "labelDevs1Save";
			labelDevs1Save.Size = new Size(80, 17);
			labelDevs1Save.TabIndex = 4;
			labelDevs1Save.Text = "Develop By";
			// 
			// labelWelcomeSave3
			// 
			labelWelcomeSave3.AutoSize = true;
			labelWelcomeSave3.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			labelWelcomeSave3.ForeColor = Color.White;
			labelWelcomeSave3.Location = new Point(200, 221);
			labelWelcomeSave3.Name = "labelWelcomeSave3";
			labelWelcomeSave3.Size = new Size(90, 27);
			labelWelcomeSave3.TabIndex = 3;
			labelWelcomeSave3.Text = "System";
			// 
			// labelWelcomeSave2
			// 
			labelWelcomeSave2.AutoSize = true;
			labelWelcomeSave2.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			labelWelcomeSave2.ForeColor = Color.White;
			labelWelcomeSave2.Location = new Point(30, 194);
			labelWelcomeSave2.Name = "labelWelcomeSave2";
			labelWelcomeSave2.Size = new Size(260, 27);
			labelWelcomeSave2.TabIndex = 2;
			labelWelcomeSave2.Text = "Service Management";
			// 
			// labelWelcomeSave1
			// 
			labelWelcomeSave1.AutoSize = true;
			labelWelcomeSave1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			labelWelcomeSave1.ForeColor = Color.White;
			labelWelcomeSave1.Location = new Point(95, 167);
			labelWelcomeSave1.Name = "labelWelcomeSave1";
			labelWelcomeSave1.Size = new Size(195, 27);
			labelWelcomeSave1.TabIndex = 1;
			labelWelcomeSave1.Text = "Welcome to the";
			// 
			// pictureBoxBirdSave
			// 
			pictureBoxBirdSave.Image = Properties.Resources.icons8_swiftui_100;
			pictureBoxBirdSave.Location = new Point(82, 48);
			pictureBoxBirdSave.Name = "pictureBoxBirdSave";
			pictureBoxBirdSave.Size = new Size(125, 62);
			pictureBoxBirdSave.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBoxBirdSave.TabIndex = 0;
			pictureBoxBirdSave.TabStop = false;
			// 
			// btnGoBackToLogin
			// 
			btnGoBackToLogin.Location = new Point(0, 0);
			btnGoBackToLogin.Name = "btnGoBackToLogin";
			btnGoBackToLogin.Size = new Size(75, 23);
			btnGoBackToLogin.TabIndex = 0;
			// 
			// linkLabel3
			// 
			linkLabel3.Location = new Point(0, 0);
			linkLabel3.Name = "linkLabel3";
			linkLabel3.Size = new Size(100, 23);
			linkLabel3.TabIndex = 0;
			// 
			// label16
			// 
			label16.Location = new Point(0, 0);
			label16.Name = "label16";
			label16.Size = new Size(100, 23);
			label16.TabIndex = 0;
			// 
			// label17
			// 
			label17.Location = new Point(0, 0);
			label17.Name = "label17";
			label17.Size = new Size(100, 23);
			label17.TabIndex = 0;
			// 
			// label18
			// 
			label18.Location = new Point(0, 0);
			label18.Name = "label18";
			label18.Size = new Size(100, 23);
			label18.TabIndex = 0;
			// 
			// button8
			// 
			button8.Location = new Point(0, 0);
			button8.Name = "button8";
			button8.Size = new Size(75, 23);
			button8.TabIndex = 0;
			// 
			// button9
			// 
			button9.Location = new Point(0, 0);
			button9.Name = "button9";
			button9.Size = new Size(75, 23);
			button9.TabIndex = 0;
			// 
			// panel9
			// 
			panel9.Location = new Point(0, 0);
			panel9.Name = "panel9";
			panel9.Size = new Size(200, 100);
			panel9.TabIndex = 0;
			// 
			// textBox5
			// 
			textBox5.Location = new Point(0, 0);
			textBox5.Name = "textBox5";
			textBox5.Size = new Size(100, 27);
			textBox5.TabIndex = 0;
			// 
			// pictureBox6
			// 
			pictureBox6.Location = new Point(0, 0);
			pictureBox6.Name = "pictureBox6";
			pictureBox6.Size = new Size(100, 50);
			pictureBox6.TabIndex = 0;
			pictureBox6.TabStop = false;
			// 
			// panel10
			// 
			panel10.Location = new Point(0, 0);
			panel10.Name = "panel10";
			panel10.Size = new Size(200, 100);
			panel10.TabIndex = 0;
			// 
			// textBox6
			// 
			textBox6.Location = new Point(0, 0);
			textBox6.Name = "textBox6";
			textBox6.Size = new Size(100, 27);
			textBox6.TabIndex = 0;
			// 
			// pictureBox7
			// 
			pictureBox7.Location = new Point(0, 0);
			pictureBox7.Name = "pictureBox7";
			pictureBox7.Size = new Size(100, 50);
			pictureBox7.TabIndex = 0;
			pictureBox7.TabStop = false;
			// 
			// label19
			// 
			label19.Location = new Point(0, 0);
			label19.Name = "label19";
			label19.Size = new Size(100, 23);
			label19.TabIndex = 0;
			// 
			// button10
			// 
			button10.Location = new Point(0, 0);
			button10.Name = "button10";
			button10.Size = new Size(75, 23);
			button10.TabIndex = 0;
			// 
			// button4
			// 
			button4.Location = new Point(0, 0);
			button4.Name = "button4";
			button4.Size = new Size(75, 23);
			button4.TabIndex = 0;
			// 
			// linkLabel2
			// 
			linkLabel2.Location = new Point(0, 0);
			linkLabel2.Name = "linkLabel2";
			linkLabel2.Size = new Size(100, 23);
			linkLabel2.TabIndex = 0;
			// 
			// label12
			// 
			label12.Location = new Point(0, 0);
			label12.Name = "label12";
			label12.Size = new Size(100, 23);
			label12.TabIndex = 0;
			// 
			// label13
			// 
			label13.Location = new Point(0, 0);
			label13.Name = "label13";
			label13.Size = new Size(100, 23);
			label13.TabIndex = 0;
			// 
			// label14
			// 
			label14.Location = new Point(0, 0);
			label14.Name = "label14";
			label14.Size = new Size(100, 23);
			label14.TabIndex = 0;
			// 
			// button6
			// 
			button6.Location = new Point(0, 0);
			button6.Name = "button6";
			button6.Size = new Size(75, 23);
			button6.TabIndex = 0;
			// 
			// panel6
			// 
			panel6.Location = new Point(0, 0);
			panel6.Name = "panel6";
			panel6.Size = new Size(200, 100);
			panel6.TabIndex = 0;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(0, 0);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(100, 27);
			textBox3.TabIndex = 0;
			// 
			// pictureBox4
			// 
			pictureBox4.Location = new Point(0, 0);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new Size(100, 50);
			pictureBox4.TabIndex = 0;
			pictureBox4.TabStop = false;
			// 
			// panel7
			// 
			panel7.Location = new Point(0, 0);
			panel7.Name = "panel7";
			panel7.Size = new Size(200, 100);
			panel7.TabIndex = 0;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(0, 0);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(100, 27);
			textBox4.TabIndex = 0;
			// 
			// pictureBox5
			// 
			pictureBox5.Location = new Point(0, 0);
			pictureBox5.Name = "pictureBox5";
			pictureBox5.Size = new Size(100, 50);
			pictureBox5.TabIndex = 0;
			pictureBox5.TabStop = false;
			// 
			// label15
			// 
			label15.Location = new Point(0, 0);
			label15.Name = "label15";
			label15.Size = new Size(100, 23);
			label15.TabIndex = 0;
			// 
			// button7
			// 
			button7.Location = new Point(0, 0);
			button7.Name = "button7";
			button7.Size = new Size(75, 23);
			button7.TabIndex = 0;
			// 
			// PanelLoginSave
			// 
			PanelLoginSave.Controls.Add(PanelRegister);
			PanelLoginSave.Controls.Add(btnRegisterSave);
			PanelLoginSave.Controls.Add(linkLabel1Save);
			PanelLoginSave.Controls.Add(label11Save);
			PanelLoginSave.Controls.Add(label10Save);
			PanelLoginSave.Controls.Add(label9Save);
			PanelLoginSave.Controls.Add(button2Save);
			PanelLoginSave.Controls.Add(button1Save);
			PanelLoginSave.Controls.Add(panel4Save);
			PanelLoginSave.Controls.Add(panel3Save);
			PanelLoginSave.Controls.Add(labelLogin1Save);
			PanelLoginSave.Location = new Point(300, 0);
			PanelLoginSave.Name = "PanelLoginSave";
			PanelLoginSave.Size = new Size(450, 530);
			PanelLoginSave.TabIndex = 1;
			// 
			// PanelRegister
			// 
			PanelRegister.BackColor = SystemColors.Control;
			PanelRegister.Controls.Add(panel5);
			PanelRegister.Controls.Add(panel4);
			PanelRegister.Controls.Add(panel3);
			PanelRegister.Controls.Add(button3);
			PanelRegister.Controls.Add(panel1);
			PanelRegister.Controls.Add(panel2);
			PanelRegister.Controls.Add(label1);
			PanelRegister.Controls.Add(BtnReturnLogin);
			PanelRegister.Location = new Point(0, 0);
			PanelRegister.Name = "PanelRegister";
			PanelRegister.Size = new Size(450, 530);
			PanelRegister.TabIndex = 13;
			// 
			// panel5
			// 
			panel5.BackColor = Color.White;
			panel5.Controls.Add(txtRegId);
			panel5.Controls.Add(pictureBox9);
			panel5.Location = new Point(0, 347);
			panel5.Name = "panel5";
			panel5.Size = new Size(450, 51);
			panel5.TabIndex = 20;
			// 
			// txtRegId
			// 
			txtRegId.BackColor = Color.White;
			txtRegId.BorderStyle = BorderStyle.None;
			txtRegId.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
			txtRegId.ForeColor = Color.FromArgb(41, 128, 185);
			txtRegId.Location = new Point(55, 15);
			txtRegId.Name = "txtRegId";
			txtRegId.Size = new Size(370, 21);
			txtRegId.TabIndex = 3;
			txtRegId.Text = "Enter ID";
			txtRegId.Click += txtRegId_Click;
			// 
			// pictureBox9
			// 
			pictureBox9.Image = Properties.Resources.icons8_password_key_50;
			pictureBox9.Location = new Point(15, 15);
			pictureBox9.Name = "pictureBox9";
			pictureBox9.Size = new Size(24, 24);
			pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox9.TabIndex = 2;
			pictureBox9.TabStop = false;
			// 
			// panel4
			// 
			panel4.BackColor = Color.White;
			panel4.Controls.Add(txtRegRePassword);
			panel4.Controls.Add(pictureBox8);
			panel4.Location = new Point(0, 290);
			panel4.Name = "panel4";
			panel4.Size = new Size(450, 51);
			panel4.TabIndex = 19;
			// 
			// txtRegRePassword
			// 
			txtRegRePassword.BackColor = Color.White;
			txtRegRePassword.BorderStyle = BorderStyle.None;
			txtRegRePassword.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
			txtRegRePassword.ForeColor = Color.FromArgb(41, 128, 185);
			txtRegRePassword.Location = new Point(55, 15);
			txtRegRePassword.Name = "txtRegRePassword";
			txtRegRePassword.Size = new Size(370, 21);
			txtRegRePassword.TabIndex = 3;
			txtRegRePassword.Text = "Re - Enter Password";
			txtRegRePassword.Click += textBox8_Click;
			// 
			// pictureBox8
			// 
			pictureBox8.Image = Properties.Resources.icons8_password_key_50;
			pictureBox8.Location = new Point(15, 15);
			pictureBox8.Name = "pictureBox8";
			pictureBox8.Size = new Size(24, 24);
			pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox8.TabIndex = 2;
			pictureBox8.TabStop = false;
			// 
			// panel3
			// 
			panel3.BackColor = Color.White;
			panel3.Controls.Add(txtRegName);
			panel3.Controls.Add(pictureBox3);
			panel3.Location = new Point(0, 113);
			panel3.Name = "panel3";
			panel3.Size = new Size(450, 52);
			panel3.TabIndex = 18;
			// 
			// txtRegName
			// 
			txtRegName.BorderStyle = BorderStyle.None;
			txtRegName.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
			txtRegName.ForeColor = Color.FromArgb(41, 128, 185);
			txtRegName.Location = new Point(55, 15);
			txtRegName.Name = "txtRegName";
			txtRegName.Size = new Size(370, 21);
			txtRegName.TabIndex = 2;
			txtRegName.Text = "Enter UserName";
			txtRegName.Click += textBox7_Click;
			// 
			// pictureBox3
			// 
			pictureBox3.Image = Properties.Resources.icons8_user_30;
			pictureBox3.Location = new Point(15, 15);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(24, 24);
			pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox3.TabIndex = 1;
			pictureBox3.TabStop = false;
			// 
			// button3
			// 
			button3.BackColor = Color.FromArgb(41, 128, 185);
			button3.FlatStyle = FlatStyle.Flat;
			button3.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
			button3.ForeColor = Color.White;
			button3.Location = new Point(15, 419);
			button3.Name = "button3";
			button3.Size = new Size(148, 35);
			button3.TabIndex = 15;
			button3.Text = "Sign Up";
			button3.UseVisualStyleBackColor = false;
			button3.Click += button3_Click;
			// 
			// panel1
			// 
			panel1.BackColor = Color.White;
			panel1.Controls.Add(txtRegPassword);
			panel1.Controls.Add(pictureBox1);
			panel1.Location = new Point(0, 229);
			panel1.Name = "panel1";
			panel1.Size = new Size(450, 51);
			panel1.TabIndex = 14;
			// 
			// txtRegPassword
			// 
			txtRegPassword.BackColor = Color.White;
			txtRegPassword.BorderStyle = BorderStyle.None;
			txtRegPassword.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
			txtRegPassword.ForeColor = Color.FromArgb(41, 128, 185);
			txtRegPassword.Location = new Point(55, 15);
			txtRegPassword.Name = "txtRegPassword";
			txtRegPassword.Size = new Size(370, 21);
			txtRegPassword.TabIndex = 3;
			txtRegPassword.Text = "Enter Password";
			txtRegPassword.Click += textBox1_Click_1;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.icons8_password_key_50;
			pictureBox1.Location = new Point(15, 15);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(24, 24);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 2;
			pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			panel2.BackColor = Color.White;
			panel2.Controls.Add(TxtRegEmail);
			panel2.Controls.Add(pictureBox2);
			panel2.Location = new Point(0, 171);
			panel2.Name = "panel2";
			panel2.Size = new Size(450, 52);
			panel2.TabIndex = 13;
			// 
			// TxtRegEmail
			// 
			TxtRegEmail.BorderStyle = BorderStyle.None;
			TxtRegEmail.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
			TxtRegEmail.ForeColor = Color.FromArgb(41, 128, 185);
			TxtRegEmail.Location = new Point(55, 15);
			TxtRegEmail.Name = "TxtRegEmail";
			TxtRegEmail.Size = new Size(370, 21);
			TxtRegEmail.TabIndex = 2;
			TxtRegEmail.Text = "Enter Email";
			TxtRegEmail.Click += textBox2_Click_1;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = Properties.Resources.icons8_user_30;
			pictureBox2.Location = new Point(15, 15);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(24, 24);
			pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox2.TabIndex = 1;
			pictureBox2.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = Color.FromArgb(41, 128, 185);
			label1.Location = new Point(38, 48);
			label1.Name = "label1";
			label1.Size = new Size(254, 27);
			label1.TabIndex = 12;
			label1.Text = "Create New Account";
			// 
			// BtnReturnLogin
			// 
			BtnReturnLogin.Location = new Point(381, 0);
			BtnReturnLogin.Name = "BtnReturnLogin";
			BtnReturnLogin.Size = new Size(69, 53);
			BtnReturnLogin.TabIndex = 0;
			BtnReturnLogin.Text = "hide";
			BtnReturnLogin.UseVisualStyleBackColor = true;
			BtnReturnLogin.Click += BtnReturnLogin_Click_1;
			// 
			// btnRegisterSave
			// 
			btnRegisterSave.BackColor = SystemColors.Control;
			btnRegisterSave.FlatAppearance.BorderSize = 0;
			btnRegisterSave.FlatStyle = FlatStyle.Flat;
			btnRegisterSave.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point);
			btnRegisterSave.ForeColor = Color.FromArgb(41, 128, 185);
			btnRegisterSave.Location = new Point(94, 388);
			btnRegisterSave.Name = "btnRegisterSave";
			btnRegisterSave.Size = new Size(130, 35);
			btnRegisterSave.TabIndex = 11;
			btnRegisterSave.Text = "Register";
			btnRegisterSave.UseVisualStyleBackColor = false;
			btnRegisterSave.Click += btnRegisterSave_Click;
			// 
			// linkLabel1Save
			// 
			linkLabel1Save.AutoSize = true;
			linkLabel1Save.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
			linkLabel1Save.LinkColor = Color.FromArgb(41, 128, 185);
			linkLabel1Save.Location = new Point(234, 491);
			linkLabel1Save.Name = "linkLabel1Save";
			linkLabel1Save.Size = new Size(121, 17);
			linkLabel1Save.TabIndex = 10;
			linkLabel1Save.TabStop = true;
			linkLabel1Save.Text = "or6562@gmail.com";
			// 
			// label11Save
			// 
			label11Save.AutoSize = true;
			label11Save.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
			label11Save.ForeColor = Color.Silver;
			label11Save.Location = new Point(38, 491);
			label11Save.Name = "label11Save";
			label11Save.Size = new Size(199, 17);
			label11Save.TabIndex = 9;
			label11Save.Text = "submit an email message to: ";
			// 
			// label10Save
			// 
			label10Save.AutoSize = true;
			label10Save.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
			label10Save.ForeColor = Color.Silver;
			label10Save.Location = new Point(38, 474);
			label10Save.Name = "label10Save";
			label10Save.Size = new Size(349, 17);
			label10Save.TabIndex = 8;
			label10Save.Text = "to obtain access to this app or any qiestions about it";
			// 
			// label9Save
			// 
			label9Save.AutoSize = true;
			label9Save.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
			label9Save.ForeColor = Color.Silver;
			label9Save.Location = new Point(38, 457);
			label9Save.Name = "label9Save";
			label9Save.Size = new Size(58, 17);
			label9Save.TabIndex = 7;
			label9Save.Text = "Support";
			// 
			// button2Save
			// 
			button2Save.BackColor = SystemColors.Control;
			button2Save.FlatAppearance.BorderSize = 0;
			button2Save.FlatStyle = FlatStyle.Flat;
			button2Save.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point);
			button2Save.ForeColor = Color.FromArgb(41, 128, 185);
			button2Save.Location = new Point(182, 331);
			button2Save.Name = "button2Save";
			button2Save.Size = new Size(130, 35);
			button2Save.TabIndex = 6;
			button2Save.Text = "Forget password ?";
			button2Save.UseVisualStyleBackColor = false;
			button2Save.Click += button2Save_Click;
			// 
			// button1Save
			// 
			button1Save.BackColor = Color.FromArgb(41, 128, 185);
			button1Save.FlatStyle = FlatStyle.Flat;
			button1Save.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
			button1Save.ForeColor = Color.White;
			button1Save.Location = new Point(15, 331);
			button1Save.Name = "button1Save";
			button1Save.Size = new Size(148, 35);
			button1Save.TabIndex = 5;
			button1Save.Text = "LOGIN";
			button1Save.UseVisualStyleBackColor = false;
			button1Save.Click += button1Save_Click;
			// 
			// panel4Save
			// 
			panel4Save.BackColor = SystemColors.Control;
			panel4Save.Controls.Add(txtLoginPassword);
			panel4Save.Controls.Add(pictureBox3Save);
			panel4Save.Location = new Point(0, 243);
			panel4Save.Name = "panel4Save";
			panel4Save.Size = new Size(450, 51);
			panel4Save.TabIndex = 4;
			// 
			// txtLoginPassword
			// 
			txtLoginPassword.BackColor = SystemColors.Control;
			txtLoginPassword.BorderStyle = BorderStyle.None;
			txtLoginPassword.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
			txtLoginPassword.ForeColor = Color.FromArgb(41, 128, 185);
			txtLoginPassword.Location = new Point(55, 15);
			txtLoginPassword.Name = "txtLoginPassword";
			txtLoginPassword.Size = new Size(370, 21);
			txtLoginPassword.TabIndex = 3;
			txtLoginPassword.UseSystemPasswordChar = true;
			txtLoginPassword.Click += textBox2_Click;
			// 
			// pictureBox3Save
			// 
			pictureBox3Save.Image = Properties.Resources.icons8_password_key_50;
			pictureBox3Save.Location = new Point(15, 15);
			pictureBox3Save.Name = "pictureBox3Save";
			pictureBox3Save.Size = new Size(24, 24);
			pictureBox3Save.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox3Save.TabIndex = 2;
			pictureBox3Save.TabStop = false;
			pictureBox3Save.MouseDown += pictureBox3_MouseDown;
			pictureBox3Save.MouseUp += pictureBox3_MouseUp;
			// 
			// panel3Save
			// 
			panel3Save.BackColor = Color.White;
			panel3Save.Controls.Add(txtLoginUserName);
			panel3Save.Controls.Add(pictureBoxSave);
			panel3Save.Location = new Point(0, 185);
			panel3Save.Name = "panel3Save";
			panel3Save.Size = new Size(450, 52);
			panel3Save.TabIndex = 3;
			// 
			// txtLoginUserName
			// 
			txtLoginUserName.BorderStyle = BorderStyle.None;
			txtLoginUserName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtLoginUserName.ForeColor = Color.FromArgb(41, 128, 185);
			txtLoginUserName.Location = new Point(55, 15);
			txtLoginUserName.Name = "txtLoginUserName";
			txtLoginUserName.Size = new Size(370, 25);
			txtLoginUserName.TabIndex = 2;
			txtLoginUserName.Click += textBox1_Click;
			// 
			// pictureBoxSave
			// 
			pictureBoxSave.Image = Properties.Resources.icons8_user_30;
			pictureBoxSave.Location = new Point(15, 15);
			pictureBoxSave.Name = "pictureBoxSave";
			pictureBoxSave.Size = new Size(24, 24);
			pictureBoxSave.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBoxSave.TabIndex = 1;
			pictureBoxSave.TabStop = false;
			// 
			// labelLogin1Save
			// 
			labelLogin1Save.AutoSize = true;
			labelLogin1Save.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			labelLogin1Save.ForeColor = Color.FromArgb(41, 128, 185);
			labelLogin1Save.Location = new Point(38, 135);
			labelLogin1Save.Name = "labelLogin1Save";
			labelLogin1Save.Size = new Size(260, 27);
			labelLogin1Save.TabIndex = 2;
			labelLogin1Save.Text = "Login to your account";
			// 
			// Login
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(750, 530);
			Controls.Add(PanelLoginSave);
			Controls.Add(PanelWelcomeSave);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			Name = "Login";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Form1";
			Load += Login_Load;
			PanelWelcomeSave.ResumeLayout(false);
			PanelWelcomeSave.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBoxBirdSave).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
			PanelLoginSave.ResumeLayout(false);
			PanelLoginSave.PerformLayout();
			PanelRegister.ResumeLayout(false);
			PanelRegister.PerformLayout();
			panel5.ResumeLayout(false);
			panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			panel4Save.ResumeLayout(false);
			panel4Save.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox3Save).EndInit();
			panel3Save.ResumeLayout(false);
			panel3Save.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBoxSave).EndInit();
			ResumeLayout(false);
		}



		#endregion



		private Panel PanelWelcomeSave;
		private PictureBox pictureBoxBirdSave;
		private Panel PanelLoginSave;
		private Label labelWelcomeSave3;
		private Label labelWelcomeSave2;
		private Label labelWelcomeSave1;
		private Label labelDevs3Save;
		private Label labelDevs4Save;
		private Label labelDevs2Save;
		private Label labelDevs1Save;
		private Panel panel4Save;
		private TextBox txtLoginPassword;
		private PictureBox pictureBox3Save;
		private Panel panel3Save;
		private TextBox txtLoginUserName;
		private PictureBox pictureBoxSave;
		private Label labelLogin1Save;
		private Button button2Save;
		private Button button1Save;
		private LinkLabel linkLabel1Save;
		private Label label11Save;
		private Label label10Save;
		private Label label9Save;
		private Button btnRegisterSave;
		private Button button4;
		private LinkLabel linkLabel2;
		private Label label12;
		private Label label13;
		private Label label14;
		private Button button6;
		private Panel panel6;
		private TextBox textBox3;
		private PictureBox pictureBox4;
		private Panel panel7;
		private TextBox textBox4;
		private PictureBox pictureBox5;
		private Label label15;
		private Button button7;
		private Button btnGoBackToLogin;
		private LinkLabel linkLabel3;
		private Label label16;
		private Label label17;
		private Label label18;
		private Button button8;
		private Button button9;
		private Panel panel9;
		private TextBox textBox5;
		private PictureBox pictureBox6;
		private Panel panel10;
		private TextBox textBox6;
		private PictureBox pictureBox7;
		private Label label19;
		private Button button10;
		private Panel PanelRegister;
		private Button BtnReturnLogin;
		private Panel panel4;
		private TextBox txtRegRePassword;
		private PictureBox pictureBox8;
		private Panel panel3;
		private TextBox txtRegName;
		private PictureBox pictureBox3;
		private Button button3;
		private Panel panel1;
		private TextBox txtRegPassword;
		private PictureBox pictureBox1;
		private Panel panel2;
		private TextBox TxtRegEmail;
		private PictureBox pictureBox2;
		private Label label1;
		private Panel panel5;
		private TextBox txtRegId;
		private PictureBox pictureBox9;
	}
}