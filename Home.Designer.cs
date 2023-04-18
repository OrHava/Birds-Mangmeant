using FireSharp.Config;
using FireSharp.Interfaces;

namespace Birds_Mangmeant
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "X0ef9KE6sIzPgMR7rlUj52AWMITXNJXPEIMNKHF9",
            BasePath = "https://birds-mannagemeant-default-rtdb.firebaseio.com/"

        };
        IFirebaseClient client;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            toolStrip1 = new ToolStrip();
            toolStripSeparator1 = new ToolStripSeparator();
            ButtonHome = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            ButtonAddBird = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            ButtonAddCage = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            ButtonSearch = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            ButtonHelp = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            ButtonSignOut = new ToolStripButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            PanelAddBird = new Panel();
            listViewBirds = new ListView();
            comboBoxSubspecies = new ComboBox();
            comboBoxBreed = new ComboBox();
            checkBoxFemale = new CheckBox();
            checkBoxMale = new CheckBox();
            dateTimePicker1 = new DateTimePicker();
            pictureBox1 = new PictureBox();
            textBoxIndexFatherofBird = new TextBox();
            textBoxIndexMotherofBird = new TextBox();
            textBoxIndexCage = new TextBox();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxIndexNumber = new TextBox();
            panelUser = new Panel();
            labelBirdAnim = new Label();
            pictureBoxAnim = new PictureBox();
            labelEmail = new Label();
            pictureBoxProfile = new PictureBox();
            labelId = new Label();
            labelUserName = new Label();
            panelHome = new Panel();
            plotSurface2d1 = new NPlot.Windows.PlotSurface2D();
            pictureBoxBirdFly = new PictureBox();
            panel7 = new Panel();
            label11 = new Label();
            panel6 = new Panel();
            pictureBoxRefresh = new PictureBox();
            label14 = new Label();
            pictureBox6 = new PictureBox();
            panel4 = new Panel();
            pictureBox5 = new PictureBox();
            label8 = new Label();
            labelAmountUsers = new Label();
            panel3 = new Panel();
            textBoxListOfChores = new TextBox();
            pictureBoxSaveList = new PictureBox();
            pictureBox4 = new PictureBox();
            label15 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label13 = new Label();
            labelNumCages = new Label();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            label12 = new Label();
            labelTypeOfBirds = new Label();
            panelAddCage = new Panel();
            textBox1 = new TextBox();
            label10 = new Label();
            panelSearch = new Panel();
            panelHelp = new Panel();
            panel5 = new Panel();
            textBoxQuestion = new TextBox();
            pictureBoxSubmitQuestion = new PictureBox();
            pictureBox7 = new PictureBox();
            labelSubmitHelp = new Label();
            dataGridViewQA = new DataGridView();
            toolStrip1.SuspendLayout();
            PanelAddBird.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAnim).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).BeginInit();
            panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBirdFly).BeginInit();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRefresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSaveList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelAddCage.SuspendLayout();
            panelHelp.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSubmitQuestion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewQA).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(46, 51, 73);
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.ImeMode = ImeMode.On;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, ButtonHome, toolStripSeparator5, ButtonAddBird, toolStripSeparator6, ButtonAddCage, toolStripSeparator2, ButtonSearch, toolStripSeparator3, ButtonHelp, toolStripSeparator4, ButtonSignOut });
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
            // ButtonHome
            // 
            ButtonHome.ForeColor = Color.White;
            ButtonHome.Image = Properties.Resources.icons8_home_24;
            ButtonHome.ImageTransparentColor = Color.Magenta;
            ButtonHome.Name = "ButtonHome";
            ButtonHome.Size = new Size(74, 24);
            ButtonHome.Text = "Home";
            ButtonHome.Click += ButtonHome_Click_1;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 27);
            // 
            // ButtonAddBird
            // 
            ButtonAddBird.ForeColor = Color.White;
            ButtonAddBird.Image = Properties.Resources.icons8_bird_24;
            ButtonAddBird.ImageTransparentColor = Color.Magenta;
            ButtonAddBird.Name = "ButtonAddBird";
            ButtonAddBird.Size = new Size(92, 24);
            ButtonAddBird.Text = "Add Bird";
            ButtonAddBird.Click += ButtonAddBird_Click_1;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 27);
            // 
            // ButtonAddCage
            // 
            ButtonAddCage.ForeColor = Color.White;
            ButtonAddCage.Image = Properties.Resources.icons8_cage_of_a_bird_24;
            ButtonAddCage.ImageTransparentColor = Color.Magenta;
            ButtonAddCage.Name = "ButtonAddCage";
            ButtonAddCage.Size = new Size(99, 24);
            ButtonAddCage.Text = "Add Cage";
            ButtonAddCage.Click += ButtonAddCage_Click_1;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // ButtonSearch
            // 
            ButtonSearch.ForeColor = Color.White;
            ButtonSearch.Image = Properties.Resources.icons8_search_24;
            ButtonSearch.ImageTransparentColor = Color.Magenta;
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(77, 24);
            ButtonSearch.Text = "Search";
            ButtonSearch.Click += ButtonSearch_Click_1;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 27);
            // 
            // ButtonHelp
            // 
            ButtonHelp.ForeColor = Color.White;
            ButtonHelp.Image = Properties.Resources.icons8_help_24;
            ButtonHelp.ImageTransparentColor = Color.Magenta;
            ButtonHelp.Name = "ButtonHelp";
            ButtonHelp.Size = new Size(65, 24);
            ButtonHelp.Text = "Help";
            ButtonHelp.Click += ButtonHelp_Click_1;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 27);
            // 
            // ButtonSignOut
            // 
            ButtonSignOut.ForeColor = Color.White;
            ButtonSignOut.Image = Properties.Resources.icons8_logout_rounded_24;
            ButtonSignOut.ImageTransparentColor = Color.Magenta;
            ButtonSignOut.Name = "ButtonSignOut";
            ButtonSignOut.Size = new Size(90, 24);
            ButtonSignOut.Text = "Sign Out";
            ButtonSignOut.Click += ButtonSignOut_Click;
            // 
            // PanelAddBird
            // 
            PanelAddBird.BackColor = Color.FromArgb(46, 51, 73);
            PanelAddBird.Controls.Add(listViewBirds);
            PanelAddBird.Controls.Add(comboBoxSubspecies);
            PanelAddBird.Controls.Add(comboBoxBreed);
            PanelAddBird.Controls.Add(checkBoxFemale);
            PanelAddBird.Controls.Add(checkBoxMale);
            PanelAddBird.Controls.Add(dateTimePicker1);
            PanelAddBird.Controls.Add(pictureBox1);
            PanelAddBird.Controls.Add(textBoxIndexFatherofBird);
            PanelAddBird.Controls.Add(textBoxIndexMotherofBird);
            PanelAddBird.Controls.Add(textBoxIndexCage);
            PanelAddBird.Controls.Add(label9);
            PanelAddBird.Controls.Add(label7);
            PanelAddBird.Controls.Add(label6);
            PanelAddBird.Controls.Add(label5);
            PanelAddBird.Controls.Add(label4);
            PanelAddBird.Controls.Add(label3);
            PanelAddBird.Controls.Add(label2);
            PanelAddBird.Controls.Add(label1);
            PanelAddBird.Controls.Add(textBoxIndexNumber);
            PanelAddBird.ForeColor = Color.Cornsilk;
            PanelAddBird.Location = new Point(0, 27);
            PanelAddBird.Name = "PanelAddBird";
            PanelAddBird.Size = new Size(1282, 733);
            PanelAddBird.TabIndex = 2;
            // 
            // listViewBirds
            // 
            listViewBirds.BackColor = Color.FromArgb(37, 42, 64);
            listViewBirds.BorderStyle = BorderStyle.None;
            listViewBirds.ForeColor = Color.White;
            listViewBirds.Location = new Point(669, 39);
            listViewBirds.Name = "listViewBirds";
            listViewBirds.Size = new Size(585, 397);
            listViewBirds.TabIndex = 23;
            listViewBirds.UseCompatibleStateImageBehavior = false;
            listViewBirds.View = View.SmallIcon;
            listViewBirds.MouseDoubleClick += listViewBirds_MouseDoubleClick_1;
            // 
            // comboBoxSubspecies
            // 
            comboBoxSubspecies.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSubspecies.FormattingEnabled = true;
            comboBoxSubspecies.Items.AddRange(new object[] { "North America", "Center America", "South America", "Eastren Europe", "Western Europe", "Australian Center", "Australian City Beaches" });
            comboBoxSubspecies.Location = new Point(48, 257);
            comboBoxSubspecies.Name = "comboBoxSubspecies";
            comboBoxSubspecies.Size = new Size(201, 31);
            comboBoxSubspecies.TabIndex = 25;
            comboBoxSubspecies.Text = "Select Subspecies";
            // 
            // comboBoxBreed
            // 
            comboBoxBreed.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxBreed.FormattingEnabled = true;
            comboBoxBreed.Items.AddRange(new object[] { "American gouldian", "European gouldian", "Australian gouldian" });
            comboBoxBreed.Location = new Point(48, 181);
            comboBoxBreed.Name = "comboBoxBreed";
            comboBoxBreed.Size = new Size(201, 31);
            comboBoxBreed.TabIndex = 24;
            comboBoxBreed.Text = "Select Breed";
            // 
            // checkBoxFemale
            // 
            checkBoxFemale.AutoSize = true;
            checkBoxFemale.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxFemale.Location = new Point(399, 85);
            checkBoxFemale.Name = "checkBoxFemale";
            checkBoxFemale.Size = new Size(106, 27);
            checkBoxFemale.TabIndex = 22;
            checkBoxFemale.Text = "Female";
            checkBoxFemale.UseVisualStyleBackColor = true;
            // 
            // checkBoxMale
            // 
            checkBoxMale.AutoSize = true;
            checkBoxMale.Checked = true;
            checkBoxMale.CheckState = CheckState.Checked;
            checkBoxMale.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxMale.Location = new Point(312, 85);
            checkBoxMale.Name = "checkBoxMale";
            checkBoxMale.Size = new Size(81, 27);
            checkBoxMale.TabIndex = 21;
            checkBoxMale.Text = "Male";
            checkBoxMale.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(48, 336);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(201, 32);
            dateTimePicker1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_add_new_50;
            pictureBox1.Location = new Point(225, 396);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // textBoxIndexFatherofBird
            // 
            textBoxIndexFatherofBird.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIndexFatherofBird.Location = new Point(313, 336);
            textBoxIndexFatherofBird.Name = "textBoxIndexFatherofBird";
            textBoxIndexFatherofBird.Size = new Size(201, 32);
            textBoxIndexFatherofBird.TabIndex = 16;
            // 
            // textBoxIndexMotherofBird
            // 
            textBoxIndexMotherofBird.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIndexMotherofBird.Location = new Point(313, 257);
            textBoxIndexMotherofBird.Name = "textBoxIndexMotherofBird";
            textBoxIndexMotherofBird.Size = new Size(201, 32);
            textBoxIndexMotherofBird.TabIndex = 15;
            // 
            // textBoxIndexCage
            // 
            textBoxIndexCage.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIndexCage.Location = new Point(313, 179);
            textBoxIndexCage.Name = "textBoxIndexCage";
            textBoxIndexCage.Size = new Size(201, 32);
            textBoxIndexCage.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(313, 39);
            label9.Name = "label9";
            label9.Size = new Size(155, 23);
            label9.TabIndex = 10;
            label9.Text = "Gender of Bird:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(310, 301);
            label7.Name = "label7";
            label7.Size = new Size(200, 23);
            label7.TabIndex = 8;
            label7.Text = "index Father of Bird:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(312, 223);
            label6.Name = "label6";
            label6.Size = new Size(212, 23);
            label6.TabIndex = 7;
            label6.Text = "Index Mother Of Bird:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(313, 137);
            label5.Name = "label5";
            label5.Size = new Size(131, 23);
            label5.TabIndex = 6;
            label5.Text = "Index Cage:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(48, 301);
            label4.Name = "label4";
            label4.Size = new Size(129, 23);
            label4.TabIndex = 5;
            label4.Text = "Hatch date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(47, 223);
            label3.Name = "label3";
            label3.Size = new Size(123, 23);
            label3.TabIndex = 4;
            label3.Text = "Subspecies:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(47, 137);
            label2.Name = "label2";
            label2.Size = new Size(137, 23);
            label2.TabIndex = 3;
            label2.Text = "Breed of Bird:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(47, 39);
            label1.Name = "label1";
            label1.Size = new Size(154, 23);
            label1.TabIndex = 2;
            label1.Text = "Index Number:";
            // 
            // textBoxIndexNumber
            // 
            textBoxIndexNumber.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIndexNumber.Location = new Point(48, 80);
            textBoxIndexNumber.Name = "textBoxIndexNumber";
            textBoxIndexNumber.Size = new Size(201, 32);
            textBoxIndexNumber.TabIndex = 0;
            // 
            // panelUser
            // 
            panelUser.BackColor = Color.FromArgb(24, 30, 54);
            panelUser.Controls.Add(labelBirdAnim);
            panelUser.Controls.Add(pictureBoxAnim);
            panelUser.Controls.Add(labelEmail);
            panelUser.Controls.Add(pictureBoxProfile);
            panelUser.Controls.Add(labelId);
            panelUser.Controls.Add(labelUserName);
            panelUser.Location = new Point(2, 27);
            panelUser.Name = "panelUser";
            panelUser.Size = new Size(218, 730);
            panelUser.TabIndex = 1;
            // 
            // labelBirdAnim
            // 
            labelBirdAnim.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelBirdAnim.ForeColor = Color.White;
            labelBirdAnim.Location = new Point(3, 336);
            labelBirdAnim.Name = "labelBirdAnim";
            labelBirdAnim.Size = new Size(227, 57);
            labelBirdAnim.TabIndex = 5;
            labelBirdAnim.Text = "Birds";
            // 
            // pictureBoxAnim
            // 
            pictureBoxAnim.BackColor = Color.FromArgb(46, 51, 73);
            pictureBoxAnim.Location = new Point(11, 396);
            pictureBoxAnim.Name = "pictureBoxAnim";
            pictureBoxAnim.Size = new Size(195, 215);
            pictureBoxAnim.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAnim.TabIndex = 4;
            pictureBoxAnim.TabStop = false;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmail.ForeColor = Color.White;
            labelEmail.Location = new Point(3, 237);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(83, 16);
            labelEmail.TabIndex = 3;
            labelEmail.Text = "User Email";
            labelEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxProfile
            // 
            pictureBoxProfile.Image = Properties.Resources.icons8_user_67;
            pictureBoxProfile.Location = new Point(38, 49);
            pictureBoxProfile.Name = "pictureBoxProfile";
            pictureBoxProfile.Size = new Size(133, 111);
            pictureBoxProfile.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxProfile.TabIndex = 0;
            pictureBoxProfile.TabStop = false;
            pictureBoxProfile.Click += pictureBoxProfile_Click;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelId.ForeColor = Color.White;
            labelId.Location = new Point(3, 215);
            labelId.Name = "labelId";
            labelId.Size = new Size(59, 16);
            labelId.TabIndex = 2;
            labelId.Text = "User ID";
            labelId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelUserName.ForeColor = Color.FromArgb(0, 156, 249);
            labelUserName.Location = new Point(0, 179);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(103, 20);
            labelUserName.TabIndex = 1;
            labelUserName.Text = "User Name";
            labelUserName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelHome
            // 
            panelHome.BackColor = Color.FromArgb(46, 51, 73);
            panelHome.Controls.Add(plotSurface2d1);
            panelHome.Controls.Add(pictureBoxBirdFly);
            panelHome.Controls.Add(panel7);
            panelHome.Controls.Add(panel6);
            panelHome.Controls.Add(panel4);
            panelHome.Controls.Add(panel3);
            panelHome.Controls.Add(panel2);
            panelHome.Controls.Add(panel1);
            panelHome.Location = new Point(216, 27);
            panelHome.Name = "panelHome";
            panelHome.Size = new Size(1066, 729);
            panelHome.TabIndex = 0;
            // 
            // plotSurface2d1
            // 
            plotSurface2d1.AutoScaleAutoGeneratedAxes = false;
            plotSurface2d1.AutoScaleTitle = false;
            plotSurface2d1.BackColor = Color.FromArgb(37, 42, 64);
            plotSurface2d1.DateTimeToolTip = false;
            plotSurface2d1.Legend = null;
            plotSurface2d1.LegendZOrder = -1;
            plotSurface2d1.Location = new Point(479, 269);
            plotSurface2d1.Name = "plotSurface2d1";
            plotSurface2d1.RightMenu = null;
            plotSurface2d1.ShowCoordinates = true;
            plotSurface2d1.Size = new Size(410, 340);
            plotSurface2d1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            plotSurface2d1.TabIndex = 10;
            plotSurface2d1.Text = "plotSurface2d1";
            plotSurface2d1.Title = "";
            plotSurface2d1.TitleFont = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            plotSurface2d1.XAxis1 = null;
            plotSurface2d1.XAxis2 = null;
            plotSurface2d1.YAxis1 = null;
            plotSurface2d1.YAxis2 = null;
            // 
            // pictureBoxBirdFly
            // 
            pictureBoxBirdFly.Image = Properties.Resources.giphy;
            pictureBoxBirdFly.Location = new Point(1000, 12);
            pictureBoxBirdFly.Name = "pictureBoxBirdFly";
            pictureBoxBirdFly.Size = new Size(54, 39);
            pictureBoxBirdFly.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxBirdFly.TabIndex = 9;
            pictureBoxBirdFly.TabStop = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(37, 42, 64);
            panel7.Controls.Add(label11);
            panel7.Location = new Point(479, 607);
            panel7.Name = "panel7";
            panel7.Size = new Size(410, 91);
            panel7.TabIndex = 8;
            // 
            // label11
            // 
            label11.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(3, 0);
            label11.Name = "label11";
            label11.Size = new Size(407, 91);
            label11.TabIndex = 4;
            label11.Text = "1: North America 2: Center America 3: South America 4: Eastren Europe 5: Western Europe 6: Australian Center 7: Australian City Beaches";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(37, 42, 64);
            panel6.Controls.Add(pictureBoxRefresh);
            panel6.Controls.Add(label14);
            panel6.Controls.Add(pictureBox6);
            panel6.Location = new Point(479, 227);
            panel6.Name = "panel6";
            panel6.Size = new Size(410, 44);
            panel6.TabIndex = 7;
            // 
            // pictureBoxRefresh
            // 
            pictureBoxRefresh.Image = Properties.Resources.icons8_refresh_24;
            pictureBoxRefresh.Location = new Point(0, 0);
            pictureBoxRefresh.Name = "pictureBoxRefresh";
            pictureBoxRefresh.Size = new Size(35, 33);
            pictureBoxRefresh.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxRefresh.TabIndex = 10;
            pictureBoxRefresh.TabStop = false;
            pictureBoxRefresh.Click += pictureBoxRefresh_Click_1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(103, 12);
            label14.Name = "label14";
            label14.Size = new Size(207, 20);
            label14.TabIndex = 9;
            label14.Text = "Graph of Breed Amount";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.icons8_combo_chart_24;
            pictureBox6.Location = new Point(372, 0);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(35, 33);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 9;
            pictureBox6.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(37, 42, 64);
            panel4.Controls.Add(pictureBox5);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(labelAmountUsers);
            panel4.Location = new Point(717, 69);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 125);
            panel4.TabIndex = 5;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.icons8_users_64;
            pictureBox5.Location = new Point(215, 1);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(35, 33);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(45, 19);
            label8.Name = "label8";
            label8.Size = new Size(150, 20);
            label8.TabIndex = 3;
            label8.Text = "Amount of Users";
            // 
            // labelAmountUsers
            // 
            labelAmountUsers.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelAmountUsers.ForeColor = Color.White;
            labelAmountUsers.Location = new Point(3, 3);
            labelAmountUsers.Name = "labelAmountUsers";
            labelAmountUsers.Size = new Size(250, 125);
            labelAmountUsers.TabIndex = 2;
            labelAmountUsers.Text = "Number";
            labelAmountUsers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(37, 42, 64);
            panel3.Controls.Add(textBoxListOfChores);
            panel3.Controls.Add(pictureBoxSaveList);
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(label15);
            panel3.Location = new Point(95, 229);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 448);
            panel3.TabIndex = 4;
            // 
            // textBoxListOfChores
            // 
            textBoxListOfChores.BackColor = Color.FromArgb(46, 51, 73);
            textBoxListOfChores.BorderStyle = BorderStyle.None;
            textBoxListOfChores.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxListOfChores.ForeColor = Color.White;
            textBoxListOfChores.Location = new Point(27, 77);
            textBoxListOfChores.Multiline = true;
            textBoxListOfChores.Name = "textBoxListOfChores";
            textBoxListOfChores.Size = new Size(198, 307);
            textBoxListOfChores.TabIndex = 7;
            // 
            // pictureBoxSaveList
            // 
            pictureBoxSaveList.Image = Properties.Resources.icons8_save_50;
            pictureBoxSaveList.Location = new Point(101, 400);
            pictureBoxSaveList.Name = "pictureBoxSaveList";
            pictureBoxSaveList.Size = new Size(49, 39);
            pictureBoxSaveList.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSaveList.TabIndex = 5;
            pictureBoxSaveList.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.icons8_notes_64;
            pictureBox4.Location = new Point(215, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 33);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.White;
            label15.Location = new Point(59, 20);
            label15.Name = "label15";
            label15.Size = new Size(129, 20);
            label15.TabIndex = 3;
            label15.Text = "List of Chores";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(37, 42, 64);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(labelNumCages);
            panel2.Location = new Point(406, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 125);
            panel2.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_cage_of_a_bird_50__1_;
            pictureBox2.Location = new Point(215, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(45, 19);
            label13.Name = "label13";
            label13.Size = new Size(153, 20);
            label13.TabIndex = 3;
            label13.Text = "Amount of Cages";
            // 
            // labelNumCages
            // 
            labelNumCages.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelNumCages.ForeColor = Color.FromArgb(0, 156, 249);
            labelNumCages.Location = new Point(62, 47);
            labelNumCages.Name = "labelNumCages";
            labelNumCages.Size = new Size(120, 32);
            labelNumCages.TabIndex = 2;
            labelNumCages.Text = "Number";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 42, 64);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(labelTypeOfBirds);
            panel1.Location = new Point(95, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_quail_50;
            pictureBox3.Location = new Point(213, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(43, 19);
            label12.Name = "label12";
            label12.Size = new Size(145, 20);
            label12.TabIndex = 3;
            label12.Text = "Amount of Birds";
            // 
            // labelTypeOfBirds
            // 
            labelTypeOfBirds.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelTypeOfBirds.ForeColor = Color.FromArgb(0, 156, 249);
            labelTypeOfBirds.Location = new Point(0, 0);
            labelTypeOfBirds.Name = "labelTypeOfBirds";
            labelTypeOfBirds.Size = new Size(250, 125);
            labelTypeOfBirds.TabIndex = 2;
            labelTypeOfBirds.Text = "Number";
            labelTypeOfBirds.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelAddCage
            // 
            panelAddCage.BackColor = Color.FromArgb(46, 51, 73);
            panelAddCage.Controls.Add(textBox1);
            panelAddCage.Controls.Add(label10);
            panelAddCage.Location = new Point(0, 27);
            panelAddCage.Name = "panelAddCage";
            panelAddCage.Size = new Size(1282, 726);
            panelAddCage.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(154, 107);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(154, 59);
            label10.Name = "label10";
            label10.Size = new Size(112, 20);
            label10.TabIndex = 0;
            label10.Text = "this is add cage";
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.FromArgb(46, 51, 73);
            panelSearch.Location = new Point(0, 27);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(1282, 731);
            panelSearch.TabIndex = 2;
            // 
            // panelHelp
            // 
            panelHelp.BackColor = Color.FromArgb(46, 51, 73);
            panelHelp.Controls.Add(dataGridViewQA);
            panelHelp.Controls.Add(panel5);
            panelHelp.Location = new Point(0, 27);
            panelHelp.Name = "panelHelp";
            panelHelp.Size = new Size(1282, 733);
            panelHelp.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(37, 42, 64);
            panel5.Controls.Add(textBoxQuestion);
            panel5.Controls.Add(pictureBoxSubmitQuestion);
            panel5.Controls.Add(pictureBox7);
            panel5.Controls.Add(labelSubmitHelp);
            panel5.Location = new Point(0, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(469, 693);
            panel5.TabIndex = 5;
            // 
            // textBoxQuestion
            // 
            textBoxQuestion.BackColor = Color.FromArgb(46, 51, 73);
            textBoxQuestion.BorderStyle = BorderStyle.None;
            textBoxQuestion.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxQuestion.ForeColor = Color.White;
            textBoxQuestion.Location = new Point(17, 115);
            textBoxQuestion.Multiline = true;
            textBoxQuestion.Name = "textBoxQuestion";
            textBoxQuestion.Size = new Size(427, 465);
            textBoxQuestion.TabIndex = 7;
            // 
            // pictureBoxSubmitQuestion
            // 
            pictureBoxSubmitQuestion.Image = Properties.Resources.icons8_submit_58;
            pictureBoxSubmitQuestion.Location = new Point(181, 603);
            pictureBoxSubmitQuestion.Name = "pictureBoxSubmitQuestion";
            pictureBoxSubmitQuestion.Size = new Size(49, 39);
            pictureBoxSubmitQuestion.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSubmitQuestion.TabIndex = 5;
            pictureBoxSubmitQuestion.TabStop = false;
            pictureBoxSubmitQuestion.Click += pictureBoxSubmitQuestion_Click_1;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.icons8_help_50;
            pictureBox7.Location = new Point(430, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(35, 33);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 6;
            pictureBox7.TabStop = false;
            // 
            // labelSubmitHelp
            // 
            labelSubmitHelp.AutoSize = true;
            labelSubmitHelp.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelSubmitHelp.ForeColor = Color.White;
            labelSubmitHelp.Location = new Point(142, 69);
            labelSubmitHelp.Name = "labelSubmitHelp";
            labelSubmitHelp.Size = new Size(154, 20);
            labelSubmitHelp.TabIndex = 3;
            labelSubmitHelp.Text = "Submit Question:";
            // 
            // dataGridViewQA
            // 
            dataGridViewQA.AllowUserToAddRows = false;
            dataGridViewQA.AllowUserToDeleteRows = false;
            dataGridViewQA.BackgroundColor = Color.FromArgb(37, 42, 64);
            dataGridViewQA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewQA.Location = new Point(471, 0);
            dataGridViewQA.Name = "dataGridViewQA";
            dataGridViewQA.ReadOnly = true;
            dataGridViewQA.RowHeadersWidth = 51;
            dataGridViewQA.RowTemplate.Height = 29;
            dataGridViewQA.Size = new Size(811, 727);
            dataGridViewQA.TabIndex = 6;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1282, 753);
            Controls.Add(panelHome);
            Controls.Add(panelUser);
            Controls.Add(PanelAddBird);
            Controls.Add(panelHelp);
            Controls.Add(panelSearch);
            Controls.Add(toolStrip1);
            Controls.Add(panelAddCage);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            PanelAddBird.ResumeLayout(false);
            PanelAddBird.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelUser.ResumeLayout(false);
            panelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAnim).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).EndInit();
            panelHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxBirdFly).EndInit();
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRefresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSaveList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelAddCage.ResumeLayout(false);
            panelAddCage.PerformLayout();
            panelHelp.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSubmitQuestion).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewQA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private ToolStrip toolStrip1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton ButtonHome;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton ButtonSearch;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton ButtonHelp;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton ButtonSignOut;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton ButtonAddBird;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton ButtonAddCage;
        private Panel PanelAddBird;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxIndexNumber;
        private TextBox textBoxIndexFatherofBird;
        private TextBox textBoxIndexMotherofBird;
        private TextBox textBoxIndexCage;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox1;
        private CheckBox checkBoxFemale;
        private CheckBox checkBoxMale;
        private ListView listViewBirds;
        private ComboBox comboBoxSubspecies;
        private ComboBox comboBoxBreed;
        private Panel panelHome;
        private Panel panelAddCage;
        private Label label10;
        private TextBox textBox1;
        private Panel panelSearch;
        private Panel panelHelp;
        private Panel panelUser;
        private Label labelUserName;
        private PictureBox pictureBoxProfile;
        private Label labelId;
        private Panel panel1;
        private Panel panel3;
        private Label label15;
        private Panel panel2;
        private Label label13;
        private Label labelNumCages;
        private Label label12;
        private Label labelTypeOfBirds;
        private TextBox textBoxListOfChores;
        private PictureBox pictureBoxSaveList;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel4;
        private PictureBox pictureBox5;
        private Label label8;
        private Label labelAmountUsers;
        private Label labelEmail;
        private Panel panel5;
        private TextBox textBoxQuestion;
        private PictureBox pictureBoxSubmitQuestion;
        private PictureBox pictureBox7;
        private Label labelSubmitHelp;
        private DataGridView dataGridViewQA;
        private NPlot.Windows.PlotSurface2D plotSurface2d1;
        private Panel panel7;
        private Label label11;
        private Panel panel6;
        private Label label14;
        private PictureBox pictureBox6;
        private PictureBox pictureBoxRefresh;
        private PictureBox pictureBoxAnim;
        private Label labelBirdAnim;
        private PictureBox pictureBoxBirdFly;
    }
}