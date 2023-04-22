﻿using FireSharp.Config;
using FireSharp.Interfaces;

namespace Birds_Mangmeant
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        //IFirebaseConfig config = new FirebaseConfig
        //{
        //    AuthSecret = "X0ef9KE6sIzPgMR7rlUj52AWMITXNJXPEIMNKHF9",
        //    BasePath = "https://birds-mannagemeant-default-rtdb.firebaseio.com/"

        //};
        //IFirebaseClient client;

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
            toolStripSeparator7 = new ToolStripSeparator();
            toolStripButtonSearchCages = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            ButtonHelp = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            ButtonSignOut = new ToolStripButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            PanelAddBird = new Panel();
            pictureBoxEditBird = new PictureBox();
            ContainerBoxIndexCage = new ComboBox();
            listViewBirds = new ListView();
            comboBoxSubspecies = new ComboBox();
            comboBoxBreed = new ComboBox();
            checkBoxFemale = new CheckBox();
            checkBoxMale = new CheckBox();
            dateTimePicker1 = new DateTimePicker();
            pictureBoxAddBird = new PictureBox();
            textBoxIndexFatherofBird = new TextBox();
            textBoxIndexMotherofBird = new TextBox();
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
            pictureBoxEditCage = new PictureBox();
            pictureBoxAddCage = new PictureBox();
            label19 = new Label();
            material_cage_list = new ComboBox();
            enter_height = new TextBox();
            enter_width = new TextBox();
            enter_length = new TextBox();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label10 = new Label();
            enter_index_cage = new TextBox();
            cage_listview = new ListView();
            panelSearch = new Panel();
            checkBoxSearchMale = new CheckBox();
            label24 = new Label();
            checkBoxSearchFemale = new CheckBox();
            checkBoxSearchByGender = new CheckBox();
            checkBoxSearchByHatchDate = new CheckBox();
            checkBoxSearchBySubSpecie = new CheckBox();
            checkBoxSearchByIndex = new CheckBox();
            dateTimePicker2 = new DateTimePicker();
            listViewSearch = new ListView();
            comboBoxSubSpeciesSearch = new ComboBox();
            pictureBoxSearchBird = new PictureBox();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            textBoxIndexSearch = new TextBox();
            panelHelp = new Panel();
            dataGridViewQA = new DataGridView();
            panel5 = new Panel();
            textBoxQuestion = new TextBox();
            pictureBoxSubmitQuestion = new PictureBox();
            pictureBox7 = new PictureBox();
            labelSubmitHelp = new Label();
            panelSearchCages = new Panel();
            pictureBoxSearchCages = new PictureBox();
            comboBoxSearchCageMaterial = new ComboBox();
            label25 = new Label();
            checkBoxSearchCageMaterial = new CheckBox();
            checkBoxSearchIndexCage = new CheckBox();
            listViewSearchCages = new ListView();
            label28 = new Label();
            label29 = new Label();
            textBoxSearchCageIndex = new TextBox();
            label26 = new Label();
            pictureBox1 = new PictureBox();
            toolStrip1.SuspendLayout();
            PanelAddBird.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEditBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAddBird).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)pictureBoxEditCage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAddCage).BeginInit();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearchBird).BeginInit();
            panelHelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewQA).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSubmitQuestion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panelSearchCages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearchCages).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(46, 51, 73);
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.ImeMode = ImeMode.On;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, ButtonHome, toolStripSeparator5, ButtonAddBird, toolStripSeparator6, ButtonAddCage, toolStripSeparator2, ButtonSearch, toolStripSeparator7, toolStripButtonSearchCages, toolStripSeparator3, ButtonHelp, toolStripSeparator4, ButtonSignOut });
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
            ButtonHome.Click += ButtonHome_Click;
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
            ButtonAddBird.Click += ButtonAddBird_Click;
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
            ButtonAddCage.Click += ButtonAddCage_Click;
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
            ButtonSearch.Size = new Size(114, 24);
            ButtonSearch.Text = "Search Birds";
            ButtonSearch.Click += ButtonSearch_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(6, 27);
            // 
            // toolStripButtonSearchCages
            // 
            toolStripButtonSearchCages.ForeColor = Color.White;
            toolStripButtonSearchCages.Image = Properties.Resources.icons8_search_80;
            toolStripButtonSearchCages.ImageTransparentColor = Color.Magenta;
            toolStripButtonSearchCages.Name = "toolStripButtonSearchCages";
            toolStripButtonSearchCages.Size = new Size(121, 24);
            toolStripButtonSearchCages.Text = "Search Cages";
            toolStripButtonSearchCages.Click += ToolStripButtonSearchCages_Click;
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
            ButtonHelp.Click += ButtonHelp_Click;
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
            ButtonSignOut.Click += ButtonSignOut_Click_1;
            // 
            // PanelAddBird
            // 
            PanelAddBird.BackColor = Color.FromArgb(46, 51, 73);
            PanelAddBird.Controls.Add(pictureBox1);
            PanelAddBird.Controls.Add(label26);
            PanelAddBird.Controls.Add(pictureBoxEditBird);
            PanelAddBird.Controls.Add(ContainerBoxIndexCage);
            PanelAddBird.Controls.Add(listViewBirds);
            PanelAddBird.Controls.Add(comboBoxSubspecies);
            PanelAddBird.Controls.Add(comboBoxBreed);
            PanelAddBird.Controls.Add(checkBoxFemale);
            PanelAddBird.Controls.Add(checkBoxMale);
            PanelAddBird.Controls.Add(dateTimePicker1);
            PanelAddBird.Controls.Add(pictureBoxAddBird);
            PanelAddBird.Controls.Add(textBoxIndexFatherofBird);
            PanelAddBird.Controls.Add(textBoxIndexMotherofBird);
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
            PanelAddBird.Location = new Point(0, 29);
            PanelAddBird.Margin = new Padding(3, 2, 3, 2);
            PanelAddBird.Name = "PanelAddBird";
            PanelAddBird.Size = new Size(1282, 724);
            PanelAddBird.TabIndex = 2;
            // 
            // pictureBoxEditBird
            // 
            pictureBoxEditBird.Image = Properties.Resources.icons8_create_100;
            pictureBoxEditBird.Location = new Point(547, 210);
            pictureBoxEditBird.Margin = new Padding(3, 2, 3, 2);
            pictureBoxEditBird.Name = "pictureBoxEditBird";
            pictureBoxEditBird.Size = new Size(94, 70);
            pictureBoxEditBird.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxEditBird.TabIndex = 27;
            pictureBoxEditBird.TabStop = false;
            pictureBoxEditBird.Click += pictureBoxEditBird_Click;
            // 
            // ContainerBoxIndexCage
            // 
            ContainerBoxIndexCage.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ContainerBoxIndexCage.FormattingEnabled = true;
            ContainerBoxIndexCage.Location = new Point(304, 184);
            ContainerBoxIndexCage.Margin = new Padding(3, 2, 3, 2);
            ContainerBoxIndexCage.Name = "ContainerBoxIndexCage";
            ContainerBoxIndexCage.Size = new Size(176, 31);
            ContainerBoxIndexCage.TabIndex = 26;
            ContainerBoxIndexCage.Text = "Select Cage";
            // 
            // listViewBirds
            // 
            listViewBirds.BackColor = Color.FromArgb(37, 42, 64);
            listViewBirds.BorderStyle = BorderStyle.None;
            listViewBirds.ForeColor = Color.White;
            listViewBirds.Location = new Point(669, 64);
            listViewBirds.Margin = new Padding(3, 2, 3, 2);
            listViewBirds.Name = "listViewBirds";
            listViewBirds.Size = new Size(570, 527);
            listViewBirds.TabIndex = 23;
            listViewBirds.UseCompatibleStateImageBehavior = false;
            listViewBirds.View = View.SmallIcon;
            listViewBirds.SelectedIndexChanged += listViewBirds_SelectedIndexChanged_1;
            listViewBirds.MouseDoubleClick += listViewBirds_MouseDoubleClick;
            // 
            // comboBoxSubspecies
            // 
            comboBoxSubspecies.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSubspecies.FormattingEnabled = true;
            comboBoxSubspecies.Items.AddRange(new object[] { "North America", "Center America", "South America", "Eastren Europe", "Western Europe", "Australian Center", "Australian City Beaches" });
            comboBoxSubspecies.Location = new Point(73, 241);
            comboBoxSubspecies.Margin = new Padding(3, 2, 3, 2);
            comboBoxSubspecies.Name = "comboBoxSubspecies";
            comboBoxSubspecies.Size = new Size(176, 31);
            comboBoxSubspecies.TabIndex = 25;
            comboBoxSubspecies.Text = "Select Subspecies";
            // 
            // comboBoxBreed
            // 
            comboBoxBreed.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxBreed.FormattingEnabled = true;
            comboBoxBreed.Items.AddRange(new object[] { "American gouldian", "European gouldian", "Australian gouldian" });
            comboBoxBreed.Location = new Point(73, 184);
            comboBoxBreed.Margin = new Padding(3, 2, 3, 2);
            comboBoxBreed.Name = "comboBoxBreed";
            comboBoxBreed.Size = new Size(176, 31);
            comboBoxBreed.TabIndex = 24;
            comboBoxBreed.Text = "Select Breed";
            // 
            // checkBoxFemale
            // 
            checkBoxFemale.AutoSize = true;
            checkBoxFemale.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxFemale.Location = new Point(380, 112);
            checkBoxFemale.Margin = new Padding(3, 2, 3, 2);
            checkBoxFemale.Name = "checkBoxFemale";
            checkBoxFemale.Size = new Size(106, 27);
            checkBoxFemale.TabIndex = 22;
            checkBoxFemale.Text = "Female";
            checkBoxFemale.UseVisualStyleBackColor = true;
            checkBoxFemale.CheckedChanged += checkBoxFemale_CheckedChanged_1;
            // 
            // checkBoxMale
            // 
            checkBoxMale.AutoSize = true;
            checkBoxMale.Checked = true;
            checkBoxMale.CheckState = CheckState.Checked;
            checkBoxMale.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxMale.Location = new Point(304, 112);
            checkBoxMale.Margin = new Padding(3, 2, 3, 2);
            checkBoxMale.Name = "checkBoxMale";
            checkBoxMale.Size = new Size(81, 27);
            checkBoxMale.TabIndex = 21;
            checkBoxMale.Text = "Male";
            checkBoxMale.UseVisualStyleBackColor = true;
            checkBoxMale.CheckedChanged += checkBoxMale_CheckedChanged_1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(73, 300);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(176, 32);
            dateTimePicker1.TabIndex = 20;
            // 
            // pictureBoxAddBird
            // 
            pictureBoxAddBird.Image = Properties.Resources.icons8_add_new_50;
            pictureBoxAddBird.Location = new Point(544, 95);
            pictureBoxAddBird.Margin = new Padding(3, 2, 3, 2);
            pictureBoxAddBird.Name = "pictureBoxAddBird";
            pictureBoxAddBird.Size = new Size(94, 70);
            pictureBoxAddBird.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAddBird.TabIndex = 19;
            pictureBoxAddBird.TabStop = false;
            pictureBoxAddBird.Click += pictureBoxAddBird_Click;
            // 
            // textBoxIndexFatherofBird
            // 
            textBoxIndexFatherofBird.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIndexFatherofBird.Location = new Point(305, 300);
            textBoxIndexFatherofBird.Margin = new Padding(3, 2, 3, 2);
            textBoxIndexFatherofBird.Name = "textBoxIndexFatherofBird";
            textBoxIndexFatherofBird.Size = new Size(176, 32);
            textBoxIndexFatherofBird.TabIndex = 16;
            // 
            // textBoxIndexMotherofBird
            // 
            textBoxIndexMotherofBird.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIndexMotherofBird.Location = new Point(305, 241);
            textBoxIndexMotherofBird.Margin = new Padding(3, 2, 3, 2);
            textBoxIndexMotherofBird.Name = "textBoxIndexMotherofBird";
            textBoxIndexMotherofBird.Size = new Size(176, 32);
            textBoxIndexMotherofBird.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(305, 77);
            label9.Name = "label9";
            label9.Size = new Size(155, 23);
            label9.TabIndex = 10;
            label9.Text = "Gender of Bird:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(302, 274);
            label7.Name = "label7";
            label7.Size = new Size(200, 23);
            label7.TabIndex = 8;
            label7.Text = "index Father of Bird:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(304, 215);
            label6.Name = "label6";
            label6.Size = new Size(212, 23);
            label6.TabIndex = 7;
            label6.Text = "Index Mother Of Bird:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(305, 151);
            label5.Name = "label5";
            label5.Size = new Size(131, 23);
            label5.TabIndex = 6;
            label5.Text = "Index Cage:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(73, 274);
            label4.Name = "label4";
            label4.Size = new Size(129, 23);
            label4.TabIndex = 5;
            label4.Text = "Hatch date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(72, 215);
            label3.Name = "label3";
            label3.Size = new Size(123, 23);
            label3.TabIndex = 4;
            label3.Text = "Subspecies:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(72, 151);
            label2.Name = "label2";
            label2.Size = new Size(137, 23);
            label2.TabIndex = 3;
            label2.Text = "Breed of Bird:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(72, 77);
            label1.Name = "label1";
            label1.Size = new Size(154, 23);
            label1.TabIndex = 2;
            label1.Text = "Index Number:";
            // 
            // textBoxIndexNumber
            // 
            textBoxIndexNumber.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIndexNumber.Location = new Point(73, 108);
            textBoxIndexNumber.Margin = new Padding(3, 2, 3, 2);
            textBoxIndexNumber.Name = "textBoxIndexNumber";
            textBoxIndexNumber.Size = new Size(176, 32);
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
            panelUser.Location = new Point(0, 31);
            panelUser.Margin = new Padding(3, 2, 3, 2);
            panelUser.Name = "panelUser";
            panelUser.Size = new Size(209, 726);
            panelUser.TabIndex = 1;
            // 
            // labelBirdAnim
            // 
            labelBirdAnim.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelBirdAnim.ForeColor = Color.White;
            labelBirdAnim.Location = new Point(3, 326);
            labelBirdAnim.Name = "labelBirdAnim";
            labelBirdAnim.Size = new Size(199, 43);
            labelBirdAnim.TabIndex = 5;
            labelBirdAnim.Text = "Birds";
            // 
            // pictureBoxAnim
            // 
            pictureBoxAnim.BackColor = Color.FromArgb(46, 51, 73);
            pictureBoxAnim.Location = new Point(5, 382);
            pictureBoxAnim.Margin = new Padding(3, 2, 3, 2);
            pictureBoxAnim.Name = "pictureBoxAnim";
            pictureBoxAnim.Size = new Size(190, 191);
            pictureBoxAnim.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAnim.TabIndex = 4;
            pictureBoxAnim.TabStop = false;
            // 
            // labelEmail
            // 
            labelEmail.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmail.ForeColor = Color.White;
            labelEmail.Location = new Point(5, 236);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(204, 50);
            labelEmail.TabIndex = 3;
            labelEmail.Text = "User Email";
            labelEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxProfile
            // 
            pictureBoxProfile.Image = Properties.Resources.icons8_user_67;
            pictureBoxProfile.Location = new Point(35, 25);
            pictureBoxProfile.Margin = new Padding(3, 2, 3, 2);
            pictureBoxProfile.Name = "pictureBoxProfile";
            pictureBoxProfile.Size = new Size(136, 103);
            pictureBoxProfile.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxProfile.TabIndex = 0;
            pictureBoxProfile.TabStop = false;
            pictureBoxProfile.Click += pictureBoxProfile_Click_1;
            // 
            // labelId
            // 
            labelId.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelId.ForeColor = Color.White;
            labelId.Location = new Point(0, 174);
            labelId.Name = "labelId";
            labelId.Size = new Size(209, 55);
            labelId.TabIndex = 2;
            labelId.Text = "User ID";
            labelId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelUserName
            // 
            labelUserName.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelUserName.ForeColor = Color.FromArgb(0, 156, 249);
            labelUserName.Location = new Point(0, 140);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(206, 34);
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
            panelHome.Location = new Point(208, 31);
            panelHome.Margin = new Padding(3, 2, 3, 2);
            panelHome.Name = "panelHome";
            panelHome.Size = new Size(1074, 726);
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
            plotSurface2d1.Location = new Point(530, 281);
            plotSurface2d1.Margin = new Padding(3, 2, 3, 2);
            plotSurface2d1.Name = "plotSurface2d1";
            plotSurface2d1.RightMenu = null;
            plotSurface2d1.ShowCoordinates = true;
            plotSurface2d1.Size = new Size(418, 306);
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
            pictureBoxBirdFly.Location = new Point(1000, 17);
            pictureBoxBirdFly.Margin = new Padding(3, 2, 3, 2);
            pictureBoxBirdFly.Name = "pictureBoxBirdFly";
            pictureBoxBirdFly.Size = new Size(47, 29);
            pictureBoxBirdFly.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxBirdFly.TabIndex = 9;
            pictureBoxBirdFly.TabStop = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(37, 42, 64);
            panel7.Controls.Add(label11);
            panel7.Location = new Point(530, 589);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(418, 77);
            panel7.TabIndex = 8;
            // 
            // label11
            // 
            label11.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(0, 0);
            label11.Name = "label11";
            label11.Size = new Size(418, 70);
            label11.TabIndex = 4;
            label11.Text = "1: North America 2: Center America 3: South America 4: Eastren Europe 5: Western Europe 6: Australian Center 7: Australian City Beaches";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(37, 42, 64);
            panel6.Controls.Add(pictureBoxRefresh);
            panel6.Controls.Add(label14);
            panel6.Controls.Add(pictureBox6);
            panel6.Location = new Point(530, 237);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(418, 41);
            panel6.TabIndex = 7;
            // 
            // pictureBoxRefresh
            // 
            pictureBoxRefresh.Image = Properties.Resources.icons8_refresh_24;
            pictureBoxRefresh.Location = new Point(0, 0);
            pictureBoxRefresh.Margin = new Padding(3, 2, 3, 2);
            pictureBoxRefresh.Name = "pictureBoxRefresh";
            pictureBoxRefresh.Size = new Size(31, 25);
            pictureBoxRefresh.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxRefresh.TabIndex = 10;
            pictureBoxRefresh.TabStop = false;
            pictureBoxRefresh.Click += pictureBoxRefresh_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(90, 9);
            label14.Name = "label14";
            label14.Size = new Size(207, 20);
            label14.TabIndex = 9;
            label14.Text = "Graph of Breed Amount";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.icons8_combo_chart_24;
            pictureBox6.Location = new Point(387, 0);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(31, 25);
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
            panel4.Location = new Point(698, 62);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 130);
            panel4.TabIndex = 5;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.icons8_users_64;
            pictureBox5.Location = new Point(216, 1);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(31, 25);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(39, 14);
            label8.Name = "label8";
            label8.Size = new Size(150, 20);
            label8.TabIndex = 3;
            label8.Text = "Amount of Users";
            // 
            // labelAmountUsers
            // 
            labelAmountUsers.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelAmountUsers.ForeColor = Color.FromArgb(0, 156, 249);
            labelAmountUsers.Location = new Point(0, -2);
            labelAmountUsers.Name = "labelAmountUsers";
            labelAmountUsers.Size = new Size(250, 130);
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
            panel3.Location = new Point(95, 262);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 400);
            panel3.TabIndex = 4;
            // 
            // textBoxListOfChores
            // 
            textBoxListOfChores.BackColor = Color.FromArgb(46, 51, 73);
            textBoxListOfChores.BorderStyle = BorderStyle.None;
            textBoxListOfChores.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxListOfChores.ForeColor = Color.White;
            textBoxListOfChores.Location = new Point(37, 61);
            textBoxListOfChores.Margin = new Padding(3, 2, 3, 2);
            textBoxListOfChores.Multiline = true;
            textBoxListOfChores.Name = "textBoxListOfChores";
            textBoxListOfChores.Size = new Size(213, 276);
            textBoxListOfChores.TabIndex = 7;
            // 
            // pictureBoxSaveList
            // 
            pictureBoxSaveList.Image = Properties.Resources.icons8_save_50;
            pictureBoxSaveList.Location = new Point(125, 355);
            pictureBoxSaveList.Margin = new Padding(3, 2, 3, 2);
            pictureBoxSaveList.Name = "pictureBoxSaveList";
            pictureBoxSaveList.Size = new Size(43, 29);
            pictureBoxSaveList.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSaveList.TabIndex = 5;
            pictureBoxSaveList.TabStop = false;
            pictureBoxSaveList.Click += pictureBoxSaveList_Click_1;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.icons8_notes_64;
            pictureBox4.Location = new Point(266, 2);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(31, 25);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.White;
            label15.Location = new Point(88, 25);
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
            panel2.Location = new Point(397, 62);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 130);
            panel2.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_cage_of_a_bird_50__1_;
            pictureBox2.Location = new Point(219, 2);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(39, 14);
            label13.Name = "label13";
            label13.Size = new Size(153, 20);
            label13.TabIndex = 3;
            label13.Text = "Amount of Cages";
            // 
            // labelNumCages
            // 
            labelNumCages.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelNumCages.ForeColor = Color.FromArgb(0, 156, 249);
            labelNumCages.Location = new Point(49, 40);
            labelNumCages.Name = "labelNumCages";
            labelNumCages.Size = new Size(157, 47);
            labelNumCages.TabIndex = 2;
            labelNumCages.Text = "Number";
            labelNumCages.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 42, 64);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(labelTypeOfBirds);
            panel1.Location = new Point(95, 62);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 130);
            panel1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_quail_50;
            pictureBox3.Location = new Point(219, 0);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(38, 14);
            label12.Name = "label12";
            label12.Size = new Size(145, 20);
            label12.TabIndex = 3;
            label12.Text = "Amount of Birds";
            // 
            // labelTypeOfBirds
            // 
            labelTypeOfBirds.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelTypeOfBirds.ForeColor = Color.FromArgb(0, 156, 249);
            labelTypeOfBirds.Location = new Point(0, -2);
            labelTypeOfBirds.Name = "labelTypeOfBirds";
            labelTypeOfBirds.Size = new Size(250, 130);
            labelTypeOfBirds.TabIndex = 2;
            labelTypeOfBirds.Text = "Number";
            labelTypeOfBirds.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelAddCage
            // 
            panelAddCage.BackColor = Color.FromArgb(46, 51, 73);
            panelAddCage.Controls.Add(pictureBoxEditCage);
            panelAddCage.Controls.Add(pictureBoxAddCage);
            panelAddCage.Controls.Add(label19);
            panelAddCage.Controls.Add(material_cage_list);
            panelAddCage.Controls.Add(enter_height);
            panelAddCage.Controls.Add(enter_width);
            panelAddCage.Controls.Add(enter_length);
            panelAddCage.Controls.Add(label18);
            panelAddCage.Controls.Add(label17);
            panelAddCage.Controls.Add(label16);
            panelAddCage.Controls.Add(label10);
            panelAddCage.Controls.Add(enter_index_cage);
            panelAddCage.Controls.Add(cage_listview);
            panelAddCage.Location = new Point(0, 31);
            panelAddCage.Margin = new Padding(3, 2, 3, 2);
            panelAddCage.Name = "panelAddCage";
            panelAddCage.Size = new Size(1282, 722);
            panelAddCage.TabIndex = 1;
            // 
            // pictureBoxEditCage
            // 
            pictureBoxEditCage.Image = Properties.Resources.icons8_create_100;
            pictureBoxEditCage.Location = new Point(165, 371);
            pictureBoxEditCage.Margin = new Padding(3, 2, 3, 2);
            pictureBoxEditCage.Name = "pictureBoxEditCage";
            pictureBoxEditCage.Size = new Size(94, 70);
            pictureBoxEditCage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxEditCage.TabIndex = 36;
            pictureBoxEditCage.TabStop = false;
            pictureBoxEditCage.Click += pictureBoxEditCage_Click;
            // 
            // pictureBoxAddCage
            // 
            pictureBoxAddCage.Image = Properties.Resources.icons8_add_new_50;
            pictureBoxAddCage.Location = new Point(350, 374);
            pictureBoxAddCage.Margin = new Padding(3, 2, 3, 2);
            pictureBoxAddCage.Name = "pictureBoxAddCage";
            pictureBoxAddCage.Size = new Size(94, 70);
            pictureBoxAddCage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAddCage.TabIndex = 35;
            pictureBoxAddCage.TabStop = false;
            pictureBoxAddCage.Click += pictureBoxAddCage_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = SystemColors.ControlLightLight;
            label19.Location = new Point(228, 281);
            label19.Name = "label19";
            label19.Size = new Size(156, 23);
            label19.TabIndex = 34;
            label19.Text = "Cage Material:";
            // 
            // material_cage_list
            // 
            material_cage_list.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            material_cage_list.FormattingEnabled = true;
            material_cage_list.Items.AddRange(new object[] { "Iron", "Wood", "Plastic" });
            material_cage_list.Location = new Point(215, 317);
            material_cage_list.Margin = new Padding(3, 2, 3, 2);
            material_cage_list.Name = "material_cage_list";
            material_cage_list.Size = new Size(176, 31);
            material_cage_list.TabIndex = 33;
            material_cage_list.Text = "Select Material";
            // 
            // enter_height
            // 
            enter_height.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            enter_height.Location = new Point(451, 200);
            enter_height.Margin = new Padding(3, 2, 3, 2);
            enter_height.Name = "enter_height";
            enter_height.Size = new Size(90, 32);
            enter_height.TabIndex = 32;
            // 
            // enter_width
            // 
            enter_width.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            enter_width.Location = new Point(258, 200);
            enter_width.Margin = new Padding(3, 2, 3, 2);
            enter_width.Name = "enter_width";
            enter_width.Size = new Size(90, 32);
            enter_width.TabIndex = 31;
            // 
            // enter_length
            // 
            enter_length.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            enter_length.Location = new Point(74, 200);
            enter_length.Margin = new Padding(3, 2, 3, 2);
            enter_length.Name = "enter_length";
            enter_length.Size = new Size(90, 32);
            enter_length.TabIndex = 30;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = SystemColors.ControlLightLight;
            label18.Location = new Point(451, 169);
            label18.Name = "label18";
            label18.Size = new Size(77, 23);
            label18.TabIndex = 29;
            label18.Text = "Height:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.ControlLightLight;
            label17.Location = new Point(258, 174);
            label17.Name = "label17";
            label17.Size = new Size(68, 23);
            label17.TabIndex = 28;
            label17.Text = "Width:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = SystemColors.ControlLightLight;
            label16.Location = new Point(74, 169);
            label16.Name = "label16";
            label16.Size = new Size(81, 23);
            label16.TabIndex = 27;
            label16.Text = "Length:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(232, 93);
            label10.Name = "label10";
            label10.Size = new Size(131, 23);
            label10.TabIndex = 26;
            label10.Text = "Index Cage:";
            // 
            // enter_index_cage
            // 
            enter_index_cage.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            enter_index_cage.Location = new Point(211, 126);
            enter_index_cage.Margin = new Padding(3, 2, 3, 2);
            enter_index_cage.Name = "enter_index_cage";
            enter_index_cage.Size = new Size(176, 32);
            enter_index_cage.TabIndex = 25;
            // 
            // cage_listview
            // 
            cage_listview.BackColor = Color.FromArgb(37, 42, 64);
            cage_listview.BorderStyle = BorderStyle.None;
            cage_listview.ForeColor = Color.White;
            cage_listview.Location = new Point(654, 46);
            cage_listview.Margin = new Padding(3, 2, 3, 2);
            cage_listview.Name = "cage_listview";
            cage_listview.Size = new Size(585, 509);
            cage_listview.TabIndex = 24;
            cage_listview.UseCompatibleStateImageBehavior = false;
            cage_listview.View = View.SmallIcon;
            cage_listview.SelectedIndexChanged += cage_listview_SelectedIndexChanged;
            cage_listview.MouseClick += cage_listview_MouseClick;
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.FromArgb(46, 51, 73);
            panelSearch.Controls.Add(checkBoxSearchMale);
            panelSearch.Controls.Add(label24);
            panelSearch.Controls.Add(checkBoxSearchFemale);
            panelSearch.Controls.Add(checkBoxSearchByGender);
            panelSearch.Controls.Add(checkBoxSearchByHatchDate);
            panelSearch.Controls.Add(checkBoxSearchBySubSpecie);
            panelSearch.Controls.Add(checkBoxSearchByIndex);
            panelSearch.Controls.Add(dateTimePicker2);
            panelSearch.Controls.Add(listViewSearch);
            panelSearch.Controls.Add(comboBoxSubSpeciesSearch);
            panelSearch.Controls.Add(pictureBoxSearchBird);
            panelSearch.Controls.Add(label23);
            panelSearch.Controls.Add(label22);
            panelSearch.Controls.Add(label21);
            panelSearch.Controls.Add(label20);
            panelSearch.Controls.Add(textBoxIndexSearch);
            panelSearch.Location = new Point(0, 33);
            panelSearch.Margin = new Padding(3, 2, 3, 2);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(1282, 722);
            panelSearch.TabIndex = 2;
            // 
            // checkBoxSearchMale
            // 
            checkBoxSearchMale.AutoSize = true;
            checkBoxSearchMale.Checked = true;
            checkBoxSearchMale.CheckState = CheckState.Checked;
            checkBoxSearchMale.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxSearchMale.ForeColor = Color.White;
            checkBoxSearchMale.Location = new Point(121, 340);
            checkBoxSearchMale.Name = "checkBoxSearchMale";
            checkBoxSearchMale.Size = new Size(81, 27);
            checkBoxSearchMale.TabIndex = 36;
            checkBoxSearchMale.Text = "Male";
            checkBoxSearchMale.UseVisualStyleBackColor = true;
            checkBoxSearchMale.CheckedChanged += checkBoxSearchMale_CheckedChanged;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.FromArgb(46, 51, 73);
            label24.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label24.ForeColor = Color.White;
            label24.Location = new Point(302, 60);
            label24.Name = "label24";
            label24.Size = new Size(142, 19);
            label24.TabIndex = 35;
            label24.Text = "Search Conditions: ";
            // 
            // checkBoxSearchFemale
            // 
            checkBoxSearchFemale.AutoSize = true;
            checkBoxSearchFemale.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxSearchFemale.ForeColor = Color.White;
            checkBoxSearchFemale.Location = new Point(203, 341);
            checkBoxSearchFemale.Name = "checkBoxSearchFemale";
            checkBoxSearchFemale.Size = new Size(106, 27);
            checkBoxSearchFemale.TabIndex = 34;
            checkBoxSearchFemale.Text = "Female";
            checkBoxSearchFemale.UseVisualStyleBackColor = true;
            checkBoxSearchFemale.CheckedChanged += checkBoxSearchFemale_CheckedChanged;
            // 
            // checkBoxSearchByGender
            // 
            checkBoxSearchByGender.AutoSize = true;
            checkBoxSearchByGender.Location = new Point(356, 348);
            checkBoxSearchByGender.Name = "checkBoxSearchByGender";
            checkBoxSearchByGender.Size = new Size(18, 17);
            checkBoxSearchByGender.TabIndex = 32;
            checkBoxSearchByGender.UseVisualStyleBackColor = true;
            // 
            // checkBoxSearchByHatchDate
            // 
            checkBoxSearchByHatchDate.AutoSize = true;
            checkBoxSearchByHatchDate.Location = new Point(356, 259);
            checkBoxSearchByHatchDate.Name = "checkBoxSearchByHatchDate";
            checkBoxSearchByHatchDate.Size = new Size(18, 17);
            checkBoxSearchByHatchDate.TabIndex = 31;
            checkBoxSearchByHatchDate.UseVisualStyleBackColor = true;
            // 
            // checkBoxSearchBySubSpecie
            // 
            checkBoxSearchBySubSpecie.AutoSize = true;
            checkBoxSearchBySubSpecie.Location = new Point(356, 180);
            checkBoxSearchBySubSpecie.Name = "checkBoxSearchBySubSpecie";
            checkBoxSearchBySubSpecie.Size = new Size(18, 17);
            checkBoxSearchBySubSpecie.TabIndex = 30;
            checkBoxSearchBySubSpecie.UseVisualStyleBackColor = true;
            // 
            // checkBoxSearchByIndex
            // 
            checkBoxSearchByIndex.AutoSize = true;
            checkBoxSearchByIndex.Location = new Point(356, 97);
            checkBoxSearchByIndex.Name = "checkBoxSearchByIndex";
            checkBoxSearchByIndex.Size = new Size(18, 17);
            checkBoxSearchByIndex.TabIndex = 29;
            checkBoxSearchByIndex.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(123, 249);
            dateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(176, 32);
            dateTimePicker2.TabIndex = 28;
            // 
            // listViewSearch
            // 
            listViewSearch.BackColor = Color.FromArgb(37, 42, 64);
            listViewSearch.BorderStyle = BorderStyle.None;
            listViewSearch.ForeColor = Color.White;
            listViewSearch.Location = new Point(508, 44);
            listViewSearch.Margin = new Padding(3, 2, 3, 2);
            listViewSearch.Name = "listViewSearch";
            listViewSearch.Size = new Size(719, 590);
            listViewSearch.TabIndex = 27;
            listViewSearch.UseCompatibleStateImageBehavior = false;
            listViewSearch.View = View.SmallIcon;
            // 
            // comboBoxSubSpeciesSearch
            // 
            comboBoxSubSpeciesSearch.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSubSpeciesSearch.FormattingEnabled = true;
            comboBoxSubSpeciesSearch.Items.AddRange(new object[] { "North America", "Center America", "South America", "Eastren Europe", "Western Europe", "Australian Center", "Australian City Beaches" });
            comboBoxSubSpeciesSearch.Location = new Point(123, 166);
            comboBoxSubSpeciesSearch.Margin = new Padding(3, 2, 3, 2);
            comboBoxSubSpeciesSearch.Name = "comboBoxSubSpeciesSearch";
            comboBoxSubSpeciesSearch.Size = new Size(176, 31);
            comboBoxSubSpeciesSearch.TabIndex = 26;
            comboBoxSubSpeciesSearch.Text = "Select Subspecies";
            // 
            // pictureBoxSearchBird
            // 
            pictureBoxSearchBird.Image = Properties.Resources.icons8_search_80;
            pictureBoxSearchBird.Location = new Point(165, 395);
            pictureBoxSearchBird.Margin = new Padding(3, 2, 3, 2);
            pictureBoxSearchBird.Name = "pictureBoxSearchBird";
            pictureBoxSearchBird.Size = new Size(94, 70);
            pictureBoxSearchBird.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSearchBird.TabIndex = 20;
            pictureBoxSearchBird.TabStop = false;
            pictureBoxSearchBird.Click += pictureBoxSearchBird_Click;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label23.ForeColor = Color.White;
            label23.Location = new Point(165, 296);
            label23.Name = "label23";
            label23.Size = new Size(90, 23);
            label23.TabIndex = 7;
            label23.Text = "Gender:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label22.ForeColor = Color.White;
            label22.Location = new Point(143, 213);
            label22.Name = "label22";
            label22.Size = new Size(129, 23);
            label22.TabIndex = 6;
            label22.Text = "Hatch date:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label21.ForeColor = Color.White;
            label21.Location = new Point(149, 128);
            label21.Name = "label21";
            label21.Size = new Size(123, 23);
            label21.TabIndex = 5;
            label21.Text = "Subspecies:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.FromArgb(46, 51, 73);
            label20.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = Color.White;
            label20.Location = new Point(143, 58);
            label20.Name = "label20";
            label20.Size = new Size(134, 23);
            label20.TabIndex = 4;
            label20.Text = "Index of Bird:";
            // 
            // textBoxIndexSearch
            // 
            textBoxIndexSearch.BackColor = Color.White;
            textBoxIndexSearch.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIndexSearch.ForeColor = Color.Black;
            textBoxIndexSearch.Location = new Point(118, 91);
            textBoxIndexSearch.Name = "textBoxIndexSearch";
            textBoxIndexSearch.Size = new Size(181, 32);
            textBoxIndexSearch.TabIndex = 0;
            // 
            // panelHelp
            // 
            panelHelp.BackColor = Color.FromArgb(46, 51, 73);
            panelHelp.Controls.Add(dataGridViewQA);
            panelHelp.Controls.Add(panel5);
            panelHelp.Location = new Point(0, 29);
            panelHelp.Margin = new Padding(3, 2, 3, 2);
            panelHelp.Name = "panelHelp";
            panelHelp.Size = new Size(1282, 726);
            panelHelp.TabIndex = 1;
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
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(37, 42, 64);
            panel5.Controls.Add(textBoxQuestion);
            panel5.Controls.Add(pictureBoxSubmitQuestion);
            panel5.Controls.Add(pictureBox7);
            panel5.Controls.Add(labelSubmitHelp);
            panel5.Location = new Point(31, 118);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(410, 520);
            panel5.TabIndex = 5;
            // 
            // textBoxQuestion
            // 
            textBoxQuestion.BackColor = Color.FromArgb(46, 51, 73);
            textBoxQuestion.BorderStyle = BorderStyle.None;
            textBoxQuestion.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxQuestion.ForeColor = Color.White;
            textBoxQuestion.Location = new Point(15, 86);
            textBoxQuestion.Margin = new Padding(3, 2, 3, 2);
            textBoxQuestion.Multiline = true;
            textBoxQuestion.Name = "textBoxQuestion";
            textBoxQuestion.Size = new Size(374, 349);
            textBoxQuestion.TabIndex = 7;
            // 
            // pictureBoxSubmitQuestion
            // 
            pictureBoxSubmitQuestion.Image = Properties.Resources.icons8_submit_58;
            pictureBoxSubmitQuestion.Location = new Point(158, 452);
            pictureBoxSubmitQuestion.Margin = new Padding(3, 2, 3, 2);
            pictureBoxSubmitQuestion.Name = "pictureBoxSubmitQuestion";
            pictureBoxSubmitQuestion.Size = new Size(43, 29);
            pictureBoxSubmitQuestion.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSubmitQuestion.TabIndex = 5;
            pictureBoxSubmitQuestion.TabStop = false;
            pictureBoxSubmitQuestion.Click += PictureBoxSubmitQuestion_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.icons8_help_50;
            pictureBox7.Location = new Point(376, 2);
            pictureBox7.Margin = new Padding(3, 2, 3, 2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(31, 25);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 6;
            pictureBox7.TabStop = false;
            // 
            // labelSubmitHelp
            // 
            labelSubmitHelp.AutoSize = true;
            labelSubmitHelp.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelSubmitHelp.ForeColor = Color.White;
            labelSubmitHelp.Location = new Point(124, 52);
            labelSubmitHelp.Name = "labelSubmitHelp";
            labelSubmitHelp.Size = new Size(154, 20);
            labelSubmitHelp.TabIndex = 3;
            labelSubmitHelp.Text = "Submit Question:";
            // 
            // panelSearchCages
            // 
            panelSearchCages.BackColor = Color.FromArgb(46, 51, 73);
            panelSearchCages.Controls.Add(pictureBoxSearchCages);
            panelSearchCages.Controls.Add(comboBoxSearchCageMaterial);
            panelSearchCages.Controls.Add(label25);
            panelSearchCages.Controls.Add(checkBoxSearchCageMaterial);
            panelSearchCages.Controls.Add(checkBoxSearchIndexCage);
            panelSearchCages.Controls.Add(listViewSearchCages);
            panelSearchCages.Controls.Add(label28);
            panelSearchCages.Controls.Add(label29);
            panelSearchCages.Controls.Add(textBoxSearchCageIndex);
            panelSearchCages.Location = new Point(0, 29);
            panelSearchCages.Margin = new Padding(3, 2, 3, 2);
            panelSearchCages.Name = "panelSearchCages";
            panelSearchCages.Size = new Size(1282, 722);
            panelSearchCages.TabIndex = 3;
            // 
            // pictureBoxSearchCages
            // 
            pictureBoxSearchCages.Image = Properties.Resources.icons8_search_80;
            pictureBoxSearchCages.Location = new Point(165, 238);
            pictureBoxSearchCages.Margin = new Padding(3, 2, 3, 2);
            pictureBoxSearchCages.Name = "pictureBoxSearchCages";
            pictureBoxSearchCages.Size = new Size(94, 70);
            pictureBoxSearchCages.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSearchCages.TabIndex = 37;
            pictureBoxSearchCages.TabStop = false;
            pictureBoxSearchCages.Click += PictureBoxSearchCages_Click;
            // 
            // comboBoxSearchCageMaterial
            // 
            comboBoxSearchCageMaterial.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSearchCageMaterial.FormattingEnabled = true;
            comboBoxSearchCageMaterial.Items.AddRange(new object[] { "Iron", "Wood", "Plastic" });
            comboBoxSearchCageMaterial.Location = new Point(118, 170);
            comboBoxSearchCageMaterial.Margin = new Padding(3, 2, 3, 2);
            comboBoxSearchCageMaterial.Name = "comboBoxSearchCageMaterial";
            comboBoxSearchCageMaterial.Size = new Size(181, 31);
            comboBoxSearchCageMaterial.TabIndex = 36;
            comboBoxSearchCageMaterial.Text = "Select Material";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = Color.FromArgb(46, 51, 73);
            label25.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label25.ForeColor = Color.White;
            label25.Location = new Point(302, 60);
            label25.Name = "label25";
            label25.Size = new Size(142, 19);
            label25.TabIndex = 35;
            label25.Text = "Search Conditions: ";
            // 
            // checkBoxSearchCageMaterial
            // 
            checkBoxSearchCageMaterial.AutoSize = true;
            checkBoxSearchCageMaterial.Location = new Point(356, 180);
            checkBoxSearchCageMaterial.Name = "checkBoxSearchCageMaterial";
            checkBoxSearchCageMaterial.Size = new Size(18, 17);
            checkBoxSearchCageMaterial.TabIndex = 30;
            checkBoxSearchCageMaterial.UseVisualStyleBackColor = true;
            // 
            // checkBoxSearchIndexCage
            // 
            checkBoxSearchIndexCage.AutoSize = true;
            checkBoxSearchIndexCage.Location = new Point(356, 97);
            checkBoxSearchIndexCage.Name = "checkBoxSearchIndexCage";
            checkBoxSearchIndexCage.Size = new Size(18, 17);
            checkBoxSearchIndexCage.TabIndex = 29;
            checkBoxSearchIndexCage.UseVisualStyleBackColor = true;
            // 
            // listViewSearchCages
            // 
            listViewSearchCages.BackColor = Color.FromArgb(37, 42, 64);
            listViewSearchCages.BorderStyle = BorderStyle.None;
            listViewSearchCages.ForeColor = Color.White;
            listViewSearchCages.Location = new Point(508, 44);
            listViewSearchCages.Margin = new Padding(3, 2, 3, 2);
            listViewSearchCages.Name = "listViewSearchCages";
            listViewSearchCages.Size = new Size(719, 590);
            listViewSearchCages.TabIndex = 27;
            listViewSearchCages.UseCompatibleStateImageBehavior = false;
            listViewSearchCages.View = View.SmallIcon;
            listViewSearchCages.MouseDoubleClick += listViewSearchCages_MouseDoubleClick;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label28.ForeColor = Color.White;
            label28.Location = new Point(165, 132);
            label28.Name = "label28";
            label28.Size = new Size(94, 23);
            label28.TabIndex = 5;
            label28.Text = "Material:";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.BackColor = Color.FromArgb(46, 51, 73);
            label29.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label29.ForeColor = Color.White;
            label29.Location = new Point(140, 58);
            label29.Name = "label29";
            label29.Size = new Size(156, 23);
            label29.TabIndex = 4;
            label29.Text = "Index of Cage:";
            // 
            // textBoxSearchCageIndex
            // 
            textBoxSearchCageIndex.BackColor = Color.White;
            textBoxSearchCageIndex.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearchCageIndex.ForeColor = Color.Black;
            textBoxSearchCageIndex.Location = new Point(118, 91);
            textBoxSearchCageIndex.Name = "textBoxSearchCageIndex";
            textBoxSearchCageIndex.Size = new Size(181, 32);
            textBoxSearchCageIndex.TabIndex = 0;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label26.Location = new Point(72, 446);
            label26.Name = "label26";
            label26.Size = new Size(226, 23);
            label26.TabIndex = 28;
            label26.Text = "Add OffSprings To Bird:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_incubator_80;
            pictureBox1.Location = new Point(407, 505);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1282, 753);
            Controls.Add(PanelAddBird);
            Controls.Add(panelAddCage);
            Controls.Add(panelSearchCages);
            Controls.Add(panelSearch);
            Controls.Add(panelUser);
            Controls.Add(panelHome);
            Controls.Add(panelHelp);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            PanelAddBird.ResumeLayout(false);
            PanelAddBird.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEditBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAddBird).EndInit();
            panelUser.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)pictureBoxEditCage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAddCage).EndInit();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearchBird).EndInit();
            panelHelp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewQA).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSubmitQuestion).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panelSearchCages.ResumeLayout(false);
            panelSearchCages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearchCages).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBoxAddBird;
        private CheckBox checkBoxFemale;
        private CheckBox checkBoxMale;
        private ListView listViewBirds;
        private ComboBox comboBoxSubspecies;
        private ComboBox comboBoxBreed;
        private Panel panelHome;
        private Panel panelAddCage;
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
        private TextBox enter_index_cage;
        private ListView cage_listview;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label10;
        private Label label19;
        private ComboBox material_cage_list;
        private TextBox enter_height;
        private TextBox enter_width;
        private TextBox enter_length;
        private Label labelNumCages;
        private PictureBox pictureBoxAddCage;
        private DateTimePicker dateTimePicker2;
        private ListView listViewSearch;
        private ComboBox comboBoxSubSpeciesSearch;
        private PictureBox pictureBoxSearchBird;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private TextBox textBoxIndexSearch;
        private ComboBox ContainerBoxIndexCage;
        private CheckBox checkBoxSearchMale;
        private Label label24;
        private CheckBox checkBoxSearchFemale;
        private CheckBox checkBoxSearchByGender;
        private CheckBox checkBoxSearchByHatchDate;
        private CheckBox checkBoxSearchBySubSpecie;
        private CheckBox checkBoxSearchByIndex;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripButton toolStripButtonSearchCages;
        private Panel panelSearchCages;

        private Label label25;

        private CheckBox checkBox4;
        private CheckBox checkBoxSearchCageMaterial;
        private CheckBox checkBoxSearchIndexCage;

        private ListView listViewSearchCages;



        private Label label28;
        private Label label29;
        private TextBox textBoxSearchCageIndex;
        private ComboBox comboBoxSearchCageMaterial;
        private PictureBox pictureBoxSearchCages;
        private PictureBox pictureBoxEditBird;
        private PictureBox pictureBoxEditCage;
        private Label label26;
        private PictureBox pictureBox1;
    }
}