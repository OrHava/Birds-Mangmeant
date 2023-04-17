
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            PanelWelcomeSave = new Panel();
            labelDevs3Save = new Label();
            labelDevs4Save = new Label();
            labelDevs2Save = new Label();
            labelDevs1Save = new Label();
            labelWelcomeSave3 = new Label();
            labelWelcomeSave2 = new Label();
            labelWelcomeSave1 = new Label();
            pictureBoxBirdSave = new PictureBox();
            PanelRegister = new Panel();
            pictureBox10 = new PictureBox();
            panelID = new Panel();
            txtRegId = new TextBox();
            pictureBox9 = new PictureBox();
            panelRePassword = new Panel();
            txtRegRePassword = new TextBox();
            pictureBox8 = new PictureBox();
            panelUsername = new Panel();
            txtRegName = new TextBox();
            pictureBox3 = new PictureBox();
            button3 = new Button();
            panelPassword = new Panel();
            txtRegPassword = new TextBox();
            pictureBox1 = new PictureBox();
            panelEmail = new Panel();
            TxtRegEmail = new TextBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
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
            checkBoxRememberMe = new CheckBox();
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
            PanelRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            panelID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            panelRePassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panelUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            PanelLoginSave.SuspendLayout();
            panel4Save.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3Save).BeginInit();
            panel3Save.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSave).BeginInit();
            SuspendLayout();
            // 
            // PanelWelcomeSave
            // 
            PanelWelcomeSave.BackColor = Color.FromArgb(46, 51, 73);
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
            PanelWelcomeSave.Size = new Size(299, 531);
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
            labelDevs4Save.Size = new Size(77, 17);
            labelDevs4Save.TabIndex = 6;
            labelDevs4Save.Text = "Omer Shay";
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
            labelWelcomeSave3.Location = new Point(209, 229);
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
            labelWelcomeSave2.Location = new Point(84, 198);
            labelWelcomeSave2.Name = "labelWelcomeSave2";
            labelWelcomeSave2.Size = new Size(218, 27);
            labelWelcomeSave2.TabIndex = 2;
            labelWelcomeSave2.Text = "Bird Management";
            // 
            // labelWelcomeSave1
            // 
            labelWelcomeSave1.AutoSize = true;
            labelWelcomeSave1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelWelcomeSave1.ForeColor = Color.White;
            labelWelcomeSave1.Location = new Point(107, 167);
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
            pictureBoxBirdSave.Size = new Size(125, 61);
            pictureBoxBirdSave.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxBirdSave.TabIndex = 0;
            pictureBoxBirdSave.TabStop = false;
            // 
            // PanelRegister
            // 
            PanelRegister.BackColor = SystemColors.Control;
            PanelRegister.Controls.Add(pictureBox10);
            PanelRegister.Controls.Add(panelID);
            PanelRegister.Controls.Add(panelRePassword);
            PanelRegister.Controls.Add(panelUsername);
            PanelRegister.Controls.Add(button3);
            PanelRegister.Controls.Add(panelPassword);
            PanelRegister.Controls.Add(panelEmail);
            PanelRegister.Controls.Add(label1);
            PanelRegister.Location = new Point(0, 0);
            PanelRegister.Name = "PanelRegister";
            PanelRegister.Size = new Size(450, 531);
            PanelRegister.TabIndex = 13;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.icons8_close_48;
            pictureBox10.Location = new Point(397, 3);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(50, 61);
            pictureBox10.TabIndex = 21;
            pictureBox10.TabStop = false;
            pictureBox10.Click += pictureBox10_Click;
            // 
            // panelID
            // 
            panelID.BackColor = SystemColors.Control;
            panelID.Controls.Add(txtRegId);
            panelID.Controls.Add(pictureBox9);
            panelID.Location = new Point(0, 347);
            panelID.Name = "panelID";
            panelID.Size = new Size(450, 51);
            panelID.TabIndex = 20;
            // 
            // txtRegId
            // 
            txtRegId.BackColor = SystemColors.Control;
            txtRegId.BorderStyle = BorderStyle.None;
            txtRegId.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtRegId.ForeColor = Color.FromArgb(46, 51, 73);
            txtRegId.Location = new Point(55, 15);
            txtRegId.Name = "txtRegId";
            txtRegId.Size = new Size(370, 21);
            txtRegId.TabIndex = 3;
            txtRegId.Text = "Enter ID";
            txtRegId.Click += txtRegId_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.icons8_identification_documents_241;
            pictureBox9.Location = new Point(15, 15);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(24, 24);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 2;
            pictureBox9.TabStop = false;
            // 
            // panelRePassword
            // 
            panelRePassword.BackColor = SystemColors.Control;
            panelRePassword.Controls.Add(txtRegRePassword);
            panelRePassword.Controls.Add(pictureBox8);
            panelRePassword.Location = new Point(0, 291);
            panelRePassword.Name = "panelRePassword";
            panelRePassword.Size = new Size(450, 51);
            panelRePassword.TabIndex = 19;
            // 
            // txtRegRePassword
            // 
            txtRegRePassword.BackColor = SystemColors.Control;
            txtRegRePassword.BorderStyle = BorderStyle.None;
            txtRegRePassword.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtRegRePassword.ForeColor = Color.FromArgb(46, 51, 73);
            txtRegRePassword.Location = new Point(55, 15);
            txtRegRePassword.Name = "txtRegRePassword";
            txtRegRePassword.Size = new Size(370, 21);
            txtRegRePassword.TabIndex = 3;
            txtRegRePassword.Text = "Re - Enter Password";
            txtRegRePassword.Click += textBox8_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.icons8_secure_24;
            pictureBox8.Location = new Point(15, 15);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(24, 24);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 2;
            pictureBox8.TabStop = false;
            // 
            // panelUsername
            // 
            panelUsername.BackColor = SystemColors.Control;
            panelUsername.Controls.Add(txtRegName);
            panelUsername.Controls.Add(pictureBox3);
            panelUsername.Location = new Point(0, 113);
            panelUsername.Name = "panelUsername";
            panelUsername.Size = new Size(450, 52);
            panelUsername.TabIndex = 18;
            // 
            // txtRegName
            // 
            txtRegName.BackColor = SystemColors.Control;
            txtRegName.BorderStyle = BorderStyle.None;
            txtRegName.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtRegName.ForeColor = Color.FromArgb(46, 51, 73);
            txtRegName.Location = new Point(55, 15);
            txtRegName.Name = "txtRegName";
            txtRegName.Size = new Size(370, 21);
            txtRegName.TabIndex = 2;
            txtRegName.Text = "Enter UserName";
            txtRegName.Click += textBox7_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.Control;
            pictureBox3.Image = Properties.Resources.icons8_name_24;
            pictureBox3.Location = new Point(15, 15);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(46, 51, 73);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(15, 419);
            button3.Name = "button3";
            button3.Size = new Size(149, 35);
            button3.TabIndex = 15;
            button3.Text = "Sign Up";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panelPassword
            // 
            panelPassword.BackColor = SystemColors.Control;
            panelPassword.Controls.Add(txtRegPassword);
            panelPassword.Controls.Add(pictureBox1);
            panelPassword.Location = new Point(0, 229);
            panelPassword.Name = "panelPassword";
            panelPassword.Size = new Size(450, 51);
            panelPassword.TabIndex = 14;
            // 
            // txtRegPassword
            // 
            txtRegPassword.BackColor = SystemColors.Control;
            txtRegPassword.BorderStyle = BorderStyle.None;
            txtRegPassword.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtRegPassword.ForeColor = Color.FromArgb(46, 51, 73);
            txtRegPassword.Location = new Point(55, 15);
            txtRegPassword.Name = "txtRegPassword";
            txtRegPassword.Size = new Size(370, 21);
            txtRegPassword.TabIndex = 3;
            txtRegPassword.Text = "Enter Password";
            txtRegPassword.Click += textBox1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_password_24;
            pictureBox1.Location = new Point(15, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panelEmail
            // 
            panelEmail.BackColor = SystemColors.Control;
            panelEmail.Controls.Add(TxtRegEmail);
            panelEmail.Controls.Add(pictureBox2);
            panelEmail.Location = new Point(0, 171);
            panelEmail.Name = "panelEmail";
            panelEmail.Size = new Size(450, 52);
            panelEmail.TabIndex = 13;
            // 
            // TxtRegEmail
            // 
            TxtRegEmail.BackColor = SystemColors.Control;
            TxtRegEmail.BorderStyle = BorderStyle.None;
            TxtRegEmail.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TxtRegEmail.ForeColor = Color.FromArgb(46, 51, 73);
            TxtRegEmail.Location = new Point(55, 15);
            TxtRegEmail.Name = "TxtRegEmail";
            TxtRegEmail.Size = new Size(370, 21);
            TxtRegEmail.TabIndex = 2;
            TxtRegEmail.Text = "Enter Email";
            TxtRegEmail.Click += textBox2_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_mail_24;
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
            label1.ForeColor = Color.FromArgb(46, 51, 73);
            label1.Location = new Point(38, 48);
            label1.Name = "label1";
            label1.Size = new Size(254, 27);
            label1.TabIndex = 12;
            label1.Text = "Create New Account";
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
            PanelLoginSave.Controls.Add(checkBoxRememberMe);
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
            PanelLoginSave.Location = new Point(299, 0);
            PanelLoginSave.Name = "PanelLoginSave";
            PanelLoginSave.Size = new Size(450, 531);
            PanelLoginSave.TabIndex = 1;
            // 
            // checkBoxRememberMe
            // 
            checkBoxRememberMe.AutoSize = true;
            checkBoxRememberMe.Location = new Point(15, 300);
            checkBoxRememberMe.Name = "checkBoxRememberMe";
            checkBoxRememberMe.Size = new Size(129, 24);
            checkBoxRememberMe.TabIndex = 14;
            checkBoxRememberMe.Text = "Remember me";
            checkBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // btnRegisterSave
            // 
            btnRegisterSave.BackColor = SystemColors.Control;
            btnRegisterSave.FlatAppearance.BorderSize = 0;
            btnRegisterSave.FlatStyle = FlatStyle.Flat;
            btnRegisterSave.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegisterSave.ForeColor = Color.FromArgb(46, 51, 73);
            btnRegisterSave.Location = new Point(94, 388);
            btnRegisterSave.Name = "btnRegisterSave";
            btnRegisterSave.Size = new Size(130, 35);
            btnRegisterSave.TabIndex = 11;
            btnRegisterSave.Text = "Register";
            btnRegisterSave.UseVisualStyleBackColor = false;
            btnRegisterSave.Click += btnRegisterSave_Click_1;
            // 
            // linkLabel1Save
            // 
            linkLabel1Save.AutoSize = true;
            linkLabel1Save.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1Save.LinkColor = Color.FromArgb(46, 51, 73);
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
            label10Save.Location = new Point(38, 475);
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
            button2Save.ForeColor = Color.FromArgb(46, 51, 73);
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
            button1Save.BackColor = Color.FromArgb(46, 51, 73);
            button1Save.FlatStyle = FlatStyle.Flat;
            button1Save.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1Save.ForeColor = Color.White;
            button1Save.Location = new Point(15, 331);
            button1Save.Name = "button1Save";
            button1Save.Size = new Size(149, 35);
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
            txtLoginPassword.ForeColor = Color.FromArgb(46, 51, 73);
            txtLoginPassword.Location = new Point(55, 15);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.Size = new Size(370, 21);
            txtLoginPassword.TabIndex = 3;
            txtLoginPassword.UseSystemPasswordChar = true;
            txtLoginPassword.Click += textBox2_Click;
            // 
            // pictureBox3Save
            // 
            pictureBox3Save.Image = Properties.Resources.icons8_password_24;
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
            txtLoginUserName.ForeColor = Color.FromArgb(46, 51, 73);
            txtLoginUserName.Location = new Point(55, 15);
            txtLoginUserName.Name = "txtLoginUserName";
            txtLoginUserName.Size = new Size(370, 25);
            txtLoginUserName.TabIndex = 2;
            txtLoginUserName.Click += textBox1_Click;
            // 
            // pictureBoxSave
            // 
            pictureBoxSave.Image = Properties.Resources.icons8_name_24;
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
            labelLogin1Save.ForeColor = Color.FromArgb(46, 51, 73);
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
            ClientSize = new Size(750, 531);
            Controls.Add(PanelLoginSave);
            Controls.Add(PanelWelcomeSave);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosed += Login_FormClosed;
            Load += Login_Load;
            PanelWelcomeSave.ResumeLayout(false);
            PanelWelcomeSave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBirdSave).EndInit();
            PanelRegister.ResumeLayout(false);
            PanelRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            panelID.ResumeLayout(false);
            panelID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            panelRePassword.ResumeLayout(false);
            panelRePassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panelUsername.ResumeLayout(false);
            panelUsername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelPassword.ResumeLayout(false);
            panelPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelEmail.ResumeLayout(false);
            panelEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            PanelLoginSave.ResumeLayout(false);
            PanelLoginSave.PerformLayout();
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
        private Panel panelRePassword;
        private TextBox txtRegRePassword;
        private PictureBox pictureBox8;
        private Panel panelUsername;
        private TextBox txtRegName;
        private PictureBox pictureBox3;
        private Button button3;
        private Panel panelPassword;
        private TextBox txtRegPassword;
        private PictureBox pictureBox1;
        private Panel panelEmail;
        private TextBox TxtRegEmail;
        private PictureBox pictureBox2;
        private Label label1;
        private Panel panelID;
        private TextBox txtRegId;
        private PictureBox pictureBox9;
        private CheckBox checkBoxRememberMe;
        private PictureBox pictureBox10;
    }
}