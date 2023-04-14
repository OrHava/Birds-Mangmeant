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
            comboBoxSubspecies = new ComboBox();
            comboBoxBreed = new ComboBox();
            listViewBirds = new ListView();
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
            panelHome = new Panel();
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
            panelUser = new Panel();
            pictureBoxProfile = new PictureBox();
            labelId = new Label();
            labelUserName = new Label();
            panelAddCage = new Panel();
            textBox1 = new TextBox();
            label10 = new Label();
            panelSearch = new Panel();
            panelHelp = new Panel();
            label11 = new Label();
            toolStrip1.SuspendLayout();
            PanelAddBird.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelHome.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSaveList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).BeginInit();
            panelAddCage.SuspendLayout();
            panelHelp.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
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
            ButtonHome.Image = Properties.Resources.icons8_home_page_48;
            ButtonHome.ImageTransparentColor = Color.Magenta;
            ButtonHome.Name = "ButtonHome";
            ButtonHome.Size = new Size(74, 24);
            ButtonHome.Text = "Home";
            ButtonHome.Click += ButtonHome_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 27);
            // 
            // ButtonAddBird
            // 
            ButtonAddBird.Image = Properties.Resources.icons8_puffin_bird_50;
            ButtonAddBird.ImageTransparentColor = Color.Magenta;
            ButtonAddBird.Name = "ButtonAddBird";
            ButtonAddBird.Size = new Size(92, 24);
            ButtonAddBird.Text = "Add Bird";
            ButtonAddBird.Click += ButtonAddBird_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 27);
            // 
            // ButtonAddCage
            // 
            ButtonAddCage.Image = Properties.Resources.icons8_cage_of_a_bird_50;
            ButtonAddCage.ImageTransparentColor = Color.Magenta;
            ButtonAddCage.Name = "ButtonAddCage";
            ButtonAddCage.Size = new Size(99, 24);
            ButtonAddCage.Text = "Add Cage";
            ButtonAddCage.Click += ButtonAddCage_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // ButtonSearch
            // 
            ButtonSearch.Image = Properties.Resources.icons8_search_50;
            ButtonSearch.ImageTransparentColor = Color.Magenta;
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(77, 24);
            ButtonSearch.Text = "Search";
            ButtonSearch.Click += ButtonSearch_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 27);
            // 
            // ButtonHelp
            // 
            ButtonHelp.Image = Properties.Resources.icons8_help_60;
            ButtonHelp.ImageTransparentColor = Color.Magenta;
            ButtonHelp.Name = "ButtonHelp";
            ButtonHelp.Size = new Size(65, 24);
            ButtonHelp.Text = "Help";
            ButtonHelp.Click += ButtonHelp_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 27);
            // 
            // ButtonSignOut
            // 
            ButtonSignOut.Image = Properties.Resources.icons8_enter_60;
            ButtonSignOut.ImageTransparentColor = Color.Magenta;
            ButtonSignOut.Name = "ButtonSignOut";
            ButtonSignOut.Size = new Size(90, 24);
            ButtonSignOut.Text = "Sign Out";
            ButtonSignOut.Click += toolStripButton4_Click;
            // 
            // PanelAddBird
            // 
            PanelAddBird.Controls.Add(comboBoxSubspecies);
            PanelAddBird.Controls.Add(comboBoxBreed);
            PanelAddBird.Controls.Add(listViewBirds);
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
            PanelAddBird.Location = new Point(0, 30);
            PanelAddBird.Name = "PanelAddBird";
            PanelAddBird.Size = new Size(1282, 724);
            PanelAddBird.TabIndex = 2;
            // 
            // comboBoxSubspecies
            // 
            comboBoxSubspecies.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSubspecies.FormattingEnabled = true;
            comboBoxSubspecies.Items.AddRange(new object[] { "North America", "Center America", "South America", "Eastren Europe", "Western Europe", "Australian Center", "Australian City Beaches" });
            comboBoxSubspecies.Location = new Point(48, 257);
            comboBoxSubspecies.Name = "comboBoxSubspecies";
            comboBoxSubspecies.Size = new Size(200, 31);
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
            comboBoxBreed.Size = new Size(200, 31);
            comboBoxBreed.TabIndex = 24;
            comboBoxBreed.Text = "Select Breed";
            // 
            // listViewBirds
            // 
            listViewBirds.BorderStyle = BorderStyle.None;
            listViewBirds.Location = new Point(633, 49);
            listViewBirds.Name = "listViewBirds";
            listViewBirds.Size = new Size(585, 398);
            listViewBirds.TabIndex = 23;
            listViewBirds.UseCompatibleStateImageBehavior = false;
            listViewBirds.View = View.SmallIcon;
            listViewBirds.SelectedIndexChanged += listViewBirds_SelectedIndexChanged;
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
            checkBoxFemale.CheckedChanged += checkBoxFemale_CheckedChanged;
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
            checkBoxMale.CheckedChanged += checkBoxMale_CheckedChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(48, 336);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 32);
            dateTimePicker1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_add_new_100;
            pictureBox1.Location = new Point(201, 403);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 99);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBoxIndexFatherofBird
            // 
            textBoxIndexFatherofBird.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIndexFatherofBird.Location = new Point(313, 336);
            textBoxIndexFatherofBird.Name = "textBoxIndexFatherofBird";
            textBoxIndexFatherofBird.Size = new Size(200, 32);
            textBoxIndexFatherofBird.TabIndex = 16;
            // 
            // textBoxIndexMotherofBird
            // 
            textBoxIndexMotherofBird.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIndexMotherofBird.Location = new Point(313, 257);
            textBoxIndexMotherofBird.Name = "textBoxIndexMotherofBird";
            textBoxIndexMotherofBird.Size = new Size(200, 32);
            textBoxIndexMotherofBird.TabIndex = 15;
            // 
            // textBoxIndexCage
            // 
            textBoxIndexCage.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIndexCage.Location = new Point(313, 178);
            textBoxIndexCage.Name = "textBoxIndexCage";
            textBoxIndexCage.Size = new Size(200, 32);
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
            textBoxIndexNumber.Size = new Size(200, 32);
            textBoxIndexNumber.TabIndex = 0;
            // 
            // panelHome
            // 
            panelHome.BackColor = Color.FromArgb(46, 51, 73);
            panelHome.Controls.Add(panel3);
            panelHome.Controls.Add(panel2);
            panelHome.Controls.Add(panel1);
            panelHome.Controls.Add(panelUser);
            panelHome.Location = new Point(0, 30);
            panelHome.Name = "panelHome";
            panelHome.Size = new Size(1282, 727);
            panelHome.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(37, 42, 64);
            panel3.Controls.Add(textBoxListOfChores);
            panel3.Controls.Add(pictureBoxSaveList);
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(label15);
            panel3.Location = new Point(339, 249);
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
            textBoxListOfChores.Location = new Point(27, 78);
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
            pictureBoxSaveList.Click += pictureBoxSaveList_Click;
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
            label15.Location = new Point(60, 20);
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
            panel2.Location = new Point(650, 73);
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
            panel1.Location = new Point(339, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_quail_50;
            pictureBox3.Location = new Point(212, 3);
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
            label12.Location = new Point(44, 19);
            label12.Name = "label12";
            label12.Size = new Size(145, 20);
            label12.TabIndex = 3;
            label12.Text = "Amount of Birds";
            // 
            // labelTypeOfBirds
            // 
            labelTypeOfBirds.Dock = DockStyle.Fill;
            labelTypeOfBirds.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelTypeOfBirds.ForeColor = Color.FromArgb(0, 156, 249);
            labelTypeOfBirds.Location = new Point(0, 0);
            labelTypeOfBirds.Name = "labelTypeOfBirds";
            labelTypeOfBirds.Size = new Size(250, 125);
            labelTypeOfBirds.TabIndex = 2;
            labelTypeOfBirds.Text = "Number";
            labelTypeOfBirds.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelUser
            // 
            panelUser.BackColor = Color.FromArgb(24, 30, 54);
            panelUser.Controls.Add(pictureBoxProfile);
            panelUser.Controls.Add(labelId);
            panelUser.Controls.Add(labelUserName);
            panelUser.Location = new Point(0, 0);
            panelUser.Name = "panelUser";
            panelUser.Size = new Size(233, 757);
            panelUser.TabIndex = 1;
            // 
            // pictureBoxProfile
            // 
            pictureBoxProfile.Image = Properties.Resources.icons8_user_67;
            pictureBoxProfile.Location = new Point(45, 49);
            pictureBoxProfile.Name = "pictureBoxProfile";
            pictureBoxProfile.Size = new Size(132, 111);
            pictureBoxProfile.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxProfile.TabIndex = 0;
            pictureBoxProfile.TabStop = false;
            pictureBoxProfile.Click += ButtonAddImage;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelId.ForeColor = Color.White;
            labelId.Location = new Point(61, 215);
            labelId.Name = "labelId";
            labelId.Size = new Size(74, 20);
            labelId.TabIndex = 2;
            labelId.Text = "User ID";
            labelId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelUserName.ForeColor = Color.FromArgb(0, 156, 249);
            labelUserName.Location = new Point(32, 184);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(103, 20);
            labelUserName.TabIndex = 1;
            labelUserName.Text = "User Name";
            labelUserName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelAddCage
            // 
            panelAddCage.Controls.Add(textBox1);
            panelAddCage.Controls.Add(label10);
            panelAddCage.Location = new Point(0, 30);
            panelAddCage.Name = "panelAddCage";
            panelAddCage.Size = new Size(1282, 694);
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
            label10.Location = new Point(154, 58);
            label10.Name = "label10";
            label10.Size = new Size(112, 20);
            label10.TabIndex = 0;
            label10.Text = "this is add cage";
            // 
            // panelSearch
            // 
            panelSearch.Location = new Point(0, 30);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(1282, 691);
            panelSearch.TabIndex = 2;
            // 
            // panelHelp
            // 
            panelHelp.Controls.Add(label11);
            panelHelp.Location = new Point(0, 30);
            panelHelp.Name = "panelHelp";
            panelHelp.Size = new Size(1282, 697);
            panelHelp.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(142, 87);
            label11.Name = "label11";
            label11.Size = new Size(79, 20);
            label11.TabIndex = 0;
            label11.Text = "this is help";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 753);
            Controls.Add(panelHome);
            Controls.Add(panelHelp);
            Controls.Add(panelSearch);
            Controls.Add(PanelAddBird);
            Controls.Add(panelAddCage);
            Controls.Add(toolStrip1);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            FormClosed += Home_FormClosed;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            PanelAddBird.ResumeLayout(false);
            PanelAddBird.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelHome.ResumeLayout(false);
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
            panelUser.ResumeLayout(false);
            panelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).EndInit();
            panelAddCage.ResumeLayout(false);
            panelAddCage.PerformLayout();
            panelHelp.ResumeLayout(false);
            panelHelp.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
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
        private Label label11;
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
    }
}