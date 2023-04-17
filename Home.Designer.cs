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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ButtonHome = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ButtonAddBird = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ButtonAddCage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ButtonSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ButtonHelp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ButtonSignOut = new System.Windows.Forms.ToolStripButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PanelAddBird = new System.Windows.Forms.Panel();
            this.listViewBirds = new System.Windows.Forms.ListView();
            this.comboBoxSubspecies = new System.Windows.Forms.ComboBox();
            this.comboBoxBreed = new System.Windows.Forms.ComboBox();
            this.checkBoxFemale = new System.Windows.Forms.CheckBox();
            this.checkBoxMale = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxIndexFatherofBird = new System.Windows.Forms.TextBox();
            this.textBoxIndexMotherofBird = new System.Windows.Forms.TextBox();
            this.textBoxIndexCage = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIndexNumber = new System.Windows.Forms.TextBox();
            this.panelUser = new System.Windows.Forms.Panel();
            this.labelBirdAnim = new System.Windows.Forms.Label();
            this.pictureBoxAnim = new System.Windows.Forms.PictureBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.panelHome = new System.Windows.Forms.Panel();
            this.plotSurface2d1 = new NPlot.Windows.PlotSurface2D();
            this.pictureBoxBirdFly = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBoxRefresh = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labelAmountUsers = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxListOfChores = new System.Windows.Forms.TextBox();
            this.pictureBoxSaveList = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.labelNumCages = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.labelTypeOfBirds = new System.Windows.Forms.Label();
            this.panelAddCage = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.material_cage_list = new System.Windows.Forms.ComboBox();
            this.enter_height = new System.Windows.Forms.TextBox();
            this.enter_width = new System.Windows.Forms.TextBox();
            this.enter_length = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.enter_index_cage = new System.Windows.Forms.TextBox();
            this.cage_listview = new System.Windows.Forms.ListView();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.panelHelp = new System.Windows.Forms.Panel();
            this.dataGridViewQA = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.pictureBoxSubmitQuestion = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.labelSubmitHelp = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.PanelAddBird.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBirdFly)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSaveList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelAddCage.SuspendLayout();
            this.panelHelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQA)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSubmitQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.ButtonHome,
            this.toolStripSeparator5,
            this.ButtonAddBird,
            this.toolStripSeparator6,
            this.ButtonAddCage,
            this.toolStripSeparator2,
            this.ButtonSearch,
            this.toolStripSeparator3,
            this.ButtonHelp,
            this.toolStripSeparator4,
            this.ButtonSignOut});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1282, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // ButtonHome
            // 
            this.ButtonHome.ForeColor = System.Drawing.Color.White;
            this.ButtonHome.Image = global::Birds_Mangmeant.Properties.Resources.icons8_home_24;
            this.ButtonHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Size = new System.Drawing.Size(74, 24);
            this.ButtonHome.Text = "Home";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // ButtonAddBird
            // 
            this.ButtonAddBird.ForeColor = System.Drawing.Color.White;
            this.ButtonAddBird.Image = global::Birds_Mangmeant.Properties.Resources.icons8_bird_24;
            this.ButtonAddBird.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonAddBird.Name = "ButtonAddBird";
            this.ButtonAddBird.Size = new System.Drawing.Size(92, 24);
            this.ButtonAddBird.Text = "Add Bird";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // ButtonAddCage
            // 
            this.ButtonAddCage.ForeColor = System.Drawing.Color.White;
            this.ButtonAddCage.Image = global::Birds_Mangmeant.Properties.Resources.icons8_cage_of_a_bird_24;
            this.ButtonAddCage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonAddCage.Name = "ButtonAddCage";
            this.ButtonAddCage.Size = new System.Drawing.Size(99, 24);
            this.ButtonAddCage.Text = "Add Cage";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.ForeColor = System.Drawing.Color.White;
            this.ButtonSearch.Image = global::Birds_Mangmeant.Properties.Resources.icons8_search_24;
            this.ButtonSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(77, 24);
            this.ButtonSearch.Text = "Search";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // ButtonHelp
            // 
            this.ButtonHelp.ForeColor = System.Drawing.Color.White;
            this.ButtonHelp.Image = global::Birds_Mangmeant.Properties.Resources.icons8_help_24;
            this.ButtonHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonHelp.Name = "ButtonHelp";
            this.ButtonHelp.Size = new System.Drawing.Size(65, 24);
            this.ButtonHelp.Text = "Help";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // ButtonSignOut
            // 
            this.ButtonSignOut.ForeColor = System.Drawing.Color.White;
            this.ButtonSignOut.Image = global::Birds_Mangmeant.Properties.Resources.icons8_logout_rounded_24;
            this.ButtonSignOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonSignOut.Name = "ButtonSignOut";
            this.ButtonSignOut.Size = new System.Drawing.Size(90, 24);
            this.ButtonSignOut.Text = "Sign Out";
            // 
            // PanelAddBird
            // 
            this.PanelAddBird.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.PanelAddBird.Controls.Add(this.listViewBirds);
            this.PanelAddBird.Controls.Add(this.comboBoxSubspecies);
            this.PanelAddBird.Controls.Add(this.comboBoxBreed);
            this.PanelAddBird.Controls.Add(this.checkBoxFemale);
            this.PanelAddBird.Controls.Add(this.checkBoxMale);
            this.PanelAddBird.Controls.Add(this.dateTimePicker1);
            this.PanelAddBird.Controls.Add(this.pictureBox1);
            this.PanelAddBird.Controls.Add(this.textBoxIndexFatherofBird);
            this.PanelAddBird.Controls.Add(this.textBoxIndexMotherofBird);
            this.PanelAddBird.Controls.Add(this.textBoxIndexCage);
            this.PanelAddBird.Controls.Add(this.label9);
            this.PanelAddBird.Controls.Add(this.label7);
            this.PanelAddBird.Controls.Add(this.label6);
            this.PanelAddBird.Controls.Add(this.label5);
            this.PanelAddBird.Controls.Add(this.label4);
            this.PanelAddBird.Controls.Add(this.label3);
            this.PanelAddBird.Controls.Add(this.label2);
            this.PanelAddBird.Controls.Add(this.label1);
            this.PanelAddBird.Controls.Add(this.textBoxIndexNumber);
            this.PanelAddBird.ForeColor = System.Drawing.Color.Cornsilk;
            this.PanelAddBird.Location = new System.Drawing.Point(0, 27);
            this.PanelAddBird.Name = "PanelAddBird";
            this.PanelAddBird.Size = new System.Drawing.Size(1282, 733);
            this.PanelAddBird.TabIndex = 2;
            // 
            // listViewBirds
            // 
            this.listViewBirds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.listViewBirds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewBirds.ForeColor = System.Drawing.Color.White;
            this.listViewBirds.Location = new System.Drawing.Point(669, 39);
            this.listViewBirds.Name = "listViewBirds";
            this.listViewBirds.Size = new System.Drawing.Size(585, 397);
            this.listViewBirds.TabIndex = 23;
            this.listViewBirds.UseCompatibleStateImageBehavior = false;
            this.listViewBirds.View = System.Windows.Forms.View.SmallIcon;
            // 
            // comboBoxSubspecies
            // 
            this.comboBoxSubspecies.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSubspecies.FormattingEnabled = true;
            this.comboBoxSubspecies.Items.AddRange(new object[] {
            "North America",
            "Center America",
            "South America",
            "Eastren Europe",
            "Western Europe",
            "Australian Center",
            "Australian City Beaches"});
            this.comboBoxSubspecies.Location = new System.Drawing.Point(48, 257);
            this.comboBoxSubspecies.Name = "comboBoxSubspecies";
            this.comboBoxSubspecies.Size = new System.Drawing.Size(201, 31);
            this.comboBoxSubspecies.TabIndex = 25;
            this.comboBoxSubspecies.Text = "Select Subspecies";
            // 
            // comboBoxBreed
            // 
            this.comboBoxBreed.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxBreed.FormattingEnabled = true;
            this.comboBoxBreed.Items.AddRange(new object[] {
            "American gouldian",
            "European gouldian",
            "Australian gouldian"});
            this.comboBoxBreed.Location = new System.Drawing.Point(48, 181);
            this.comboBoxBreed.Name = "comboBoxBreed";
            this.comboBoxBreed.Size = new System.Drawing.Size(201, 31);
            this.comboBoxBreed.TabIndex = 24;
            this.comboBoxBreed.Text = "Select Breed";
            // 
            // checkBoxFemale
            // 
            this.checkBoxFemale.AutoSize = true;
            this.checkBoxFemale.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxFemale.Location = new System.Drawing.Point(399, 85);
            this.checkBoxFemale.Name = "checkBoxFemale";
            this.checkBoxFemale.Size = new System.Drawing.Size(106, 27);
            this.checkBoxFemale.TabIndex = 22;
            this.checkBoxFemale.Text = "Female";
            this.checkBoxFemale.UseVisualStyleBackColor = true;
            // 
            // checkBoxMale
            // 
            this.checkBoxMale.AutoSize = true;
            this.checkBoxMale.Checked = true;
            this.checkBoxMale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMale.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxMale.Location = new System.Drawing.Point(312, 85);
            this.checkBoxMale.Name = "checkBoxMale";
            this.checkBoxMale.Size = new System.Drawing.Size(81, 27);
            this.checkBoxMale.TabIndex = 21;
            this.checkBoxMale.Text = "Male";
            this.checkBoxMale.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(48, 336);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(201, 32);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Birds_Mangmeant.Properties.Resources.icons8_add_new_50;
            this.pictureBox1.Location = new System.Drawing.Point(225, 396);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxIndexFatherofBird
            // 
            this.textBoxIndexFatherofBird.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxIndexFatherofBird.Location = new System.Drawing.Point(313, 336);
            this.textBoxIndexFatherofBird.Name = "textBoxIndexFatherofBird";
            this.textBoxIndexFatherofBird.Size = new System.Drawing.Size(201, 32);
            this.textBoxIndexFatherofBird.TabIndex = 16;
            // 
            // textBoxIndexMotherofBird
            // 
            this.textBoxIndexMotherofBird.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxIndexMotherofBird.Location = new System.Drawing.Point(313, 257);
            this.textBoxIndexMotherofBird.Name = "textBoxIndexMotherofBird";
            this.textBoxIndexMotherofBird.Size = new System.Drawing.Size(201, 32);
            this.textBoxIndexMotherofBird.TabIndex = 15;
            // 
            // textBoxIndexCage
            // 
            this.textBoxIndexCage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxIndexCage.Location = new System.Drawing.Point(313, 179);
            this.textBoxIndexCage.Name = "textBoxIndexCage";
            this.textBoxIndexCage.Size = new System.Drawing.Size(201, 32);
            this.textBoxIndexCage.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(313, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 23);
            this.label9.TabIndex = 10;
            this.label9.Text = "Gender of Bird:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(310, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "index Father of Bird:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(312, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Index Mother Of Bird:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(313, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Index Cage:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(48, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hatch date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(47, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Subspecies:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(47, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Breed of Bird:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(47, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Index Number:";
            // 
            // textBoxIndexNumber
            // 
            this.textBoxIndexNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxIndexNumber.Location = new System.Drawing.Point(48, 80);
            this.textBoxIndexNumber.Name = "textBoxIndexNumber";
            this.textBoxIndexNumber.Size = new System.Drawing.Size(201, 32);
            this.textBoxIndexNumber.TabIndex = 0;
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelUser.Controls.Add(this.labelBirdAnim);
            this.panelUser.Controls.Add(this.pictureBoxAnim);
            this.panelUser.Controls.Add(this.labelEmail);
            this.panelUser.Controls.Add(this.pictureBoxProfile);
            this.panelUser.Controls.Add(this.labelId);
            this.panelUser.Controls.Add(this.labelUserName);
            this.panelUser.Location = new System.Drawing.Point(0, 0);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(218, 730);
            this.panelUser.TabIndex = 1;
            // 
            // labelBirdAnim
            // 
            this.labelBirdAnim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBirdAnim.ForeColor = System.Drawing.Color.White;
            this.labelBirdAnim.Location = new System.Drawing.Point(3, 336);
            this.labelBirdAnim.Name = "labelBirdAnim";
            this.labelBirdAnim.Size = new System.Drawing.Size(227, 57);
            this.labelBirdAnim.TabIndex = 5;
            this.labelBirdAnim.Text = "Birds";
            // 
            // pictureBoxAnim
            // 
            this.pictureBoxAnim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pictureBoxAnim.Location = new System.Drawing.Point(11, 396);
            this.pictureBoxAnim.Name = "pictureBoxAnim";
            this.pictureBoxAnim.Size = new System.Drawing.Size(195, 215);
            this.pictureBoxAnim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAnim.TabIndex = 4;
            this.pictureBoxAnim.TabStop = false;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmail.ForeColor = System.Drawing.Color.White;
            this.labelEmail.Location = new System.Drawing.Point(3, 237);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(83, 16);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "User Email";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Image = global::Birds_Mangmeant.Properties.Resources.icons8_user_67;
            this.pictureBoxProfile.Location = new System.Drawing.Point(38, 49);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(133, 111);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelId.ForeColor = System.Drawing.Color.White;
            this.labelId.Location = new System.Drawing.Point(3, 215);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(59, 16);
            this.labelId.TabIndex = 2;
            this.labelId.Text = "User ID";
            this.labelId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(249)))));
            this.labelUserName.Location = new System.Drawing.Point(0, 179);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(103, 20);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "User Name";
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panelHome.Controls.Add(this.plotSurface2d1);
            this.panelHome.Controls.Add(this.pictureBoxBirdFly);
            this.panelHome.Controls.Add(this.panel7);
            this.panelHome.Controls.Add(this.panel6);
            this.panelHome.Controls.Add(this.panel4);
            this.panelHome.Controls.Add(this.panel3);
            this.panelHome.Controls.Add(this.panel2);
            this.panelHome.Controls.Add(this.panel1);
            this.panelHome.Location = new System.Drawing.Point(216, 27);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(1066, 729);
            this.panelHome.TabIndex = 0;
            // 
            // plotSurface2d1
            // 
            this.plotSurface2d1.AutoScaleAutoGeneratedAxes = false;
            this.plotSurface2d1.AutoScaleTitle = false;
            this.plotSurface2d1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.plotSurface2d1.DateTimeToolTip = false;
            this.plotSurface2d1.Legend = null;
            this.plotSurface2d1.LegendZOrder = -1;
            this.plotSurface2d1.Location = new System.Drawing.Point(479, 269);
            this.plotSurface2d1.Name = "plotSurface2d1";
            this.plotSurface2d1.RightMenu = null;
            this.plotSurface2d1.ShowCoordinates = true;
            this.plotSurface2d1.Size = new System.Drawing.Size(410, 340);
            this.plotSurface2d1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            this.plotSurface2d1.TabIndex = 10;
            this.plotSurface2d1.Text = "plotSurface2d1";
            this.plotSurface2d1.Title = "";
            this.plotSurface2d1.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.plotSurface2d1.XAxis1 = null;
            this.plotSurface2d1.XAxis2 = null;
            this.plotSurface2d1.YAxis1 = null;
            this.plotSurface2d1.YAxis2 = null;
            // 
            // pictureBoxBirdFly
            // 
            this.pictureBoxBirdFly.Image = global::Birds_Mangmeant.Properties.Resources.giphy;
            this.pictureBoxBirdFly.Location = new System.Drawing.Point(1000, 12);
            this.pictureBoxBirdFly.Name = "pictureBoxBirdFly";
            this.pictureBoxBirdFly.Size = new System.Drawing.Size(54, 39);
            this.pictureBoxBirdFly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBirdFly.TabIndex = 9;
            this.pictureBoxBirdFly.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel7.Controls.Add(this.label11);
            this.panel7.Location = new System.Drawing.Point(479, 607);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(410, 91);
            this.panel7.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(407, 91);
            this.label11.TabIndex = 4;
            this.label11.Text = "1: North America 2: Center America 3: South America 4: Eastren Europe 5: Western " +
    "Europe 6: Australian Center 7: Australian City Beaches";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel6.Controls.Add(this.pictureBoxRefresh);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.pictureBox6);
            this.panel6.Location = new System.Drawing.Point(479, 227);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(410, 44);
            this.panel6.TabIndex = 7;
            // 
            // pictureBoxRefresh
            // 
            this.pictureBoxRefresh.Image = global::Birds_Mangmeant.Properties.Resources.icons8_refresh_24;
            this.pictureBoxRefresh.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxRefresh.Name = "pictureBoxRefresh";
            this.pictureBoxRefresh.Size = new System.Drawing.Size(35, 33);
            this.pictureBoxRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRefresh.TabIndex = 10;
            this.pictureBoxRefresh.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(103, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(207, 20);
            this.label14.TabIndex = 9;
            this.label14.Text = "Graph of Breed Amount";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Birds_Mangmeant.Properties.Resources.icons8_combo_chart_24;
            this.pictureBox6.Location = new System.Drawing.Point(373, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(35, 33);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.labelAmountUsers);
            this.panel4.Location = new System.Drawing.Point(717, 69);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 125);
            this.panel4.TabIndex = 5;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Birds_Mangmeant.Properties.Resources.icons8_users_64;
            this.pictureBox5.Location = new System.Drawing.Point(215, 1);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 33);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(45, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Amount of Users";
            // 
            // labelAmountUsers
            // 
            this.labelAmountUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAmountUsers.ForeColor = System.Drawing.Color.White;
            this.labelAmountUsers.Location = new System.Drawing.Point(3, 3);
            this.labelAmountUsers.Name = "labelAmountUsers";
            this.labelAmountUsers.Size = new System.Drawing.Size(250, 125);
            this.labelAmountUsers.TabIndex = 2;
            this.labelAmountUsers.Text = "Number";
            this.labelAmountUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.textBoxListOfChores);
            this.panel3.Controls.Add(this.pictureBoxSaveList);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Location = new System.Drawing.Point(95, 229);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 448);
            this.panel3.TabIndex = 4;
            // 
            // textBoxListOfChores
            // 
            this.textBoxListOfChores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.textBoxListOfChores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxListOfChores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxListOfChores.ForeColor = System.Drawing.Color.White;
            this.textBoxListOfChores.Location = new System.Drawing.Point(27, 77);
            this.textBoxListOfChores.Multiline = true;
            this.textBoxListOfChores.Name = "textBoxListOfChores";
            this.textBoxListOfChores.Size = new System.Drawing.Size(198, 307);
            this.textBoxListOfChores.TabIndex = 7;
            // 
            // pictureBoxSaveList
            // 
            this.pictureBoxSaveList.Image = global::Birds_Mangmeant.Properties.Resources.icons8_save_50;
            this.pictureBoxSaveList.Location = new System.Drawing.Point(101, 400);
            this.pictureBoxSaveList.Name = "pictureBoxSaveList";
            this.pictureBoxSaveList.Size = new System.Drawing.Size(49, 39);
            this.pictureBoxSaveList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSaveList.TabIndex = 5;
            this.pictureBoxSaveList.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Birds_Mangmeant.Properties.Resources.icons8_notes_64;
            this.pictureBox4.Location = new System.Drawing.Point(215, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(59, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 20);
            this.label15.TabIndex = 3;
            this.label15.Text = "List of Chores";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.labelNumCages);
            this.panel2.Location = new System.Drawing.Point(406, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 125);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Birds_Mangmeant.Properties.Resources.icons8_cage_of_a_bird_50__1_;
            this.pictureBox2.Location = new System.Drawing.Point(215, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(45, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "Amount of Cages";
            // 
            // labelNumCages
            // 
            this.labelNumCages.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNumCages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(249)))));
            this.labelNumCages.Location = new System.Drawing.Point(62, 47);
            this.labelNumCages.Name = "labelNumCages";
            this.labelNumCages.Size = new System.Drawing.Size(120, 32);
            this.labelNumCages.TabIndex = 2;
            this.labelNumCages.Text = "Number";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.labelTypeOfBirds);
            this.panel1.Location = new System.Drawing.Point(95, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 125);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Birds_Mangmeant.Properties.Resources.icons8_quail_50;
            this.pictureBox3.Location = new System.Drawing.Point(213, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(43, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Amount of Birds";
            // 
            // labelTypeOfBirds
            // 
            this.labelTypeOfBirds.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTypeOfBirds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(249)))));
            this.labelTypeOfBirds.Location = new System.Drawing.Point(0, 0);
            this.labelTypeOfBirds.Name = "labelTypeOfBirds";
            this.labelTypeOfBirds.Size = new System.Drawing.Size(250, 125);
            this.labelTypeOfBirds.TabIndex = 2;
            this.labelTypeOfBirds.Text = "Number";
            this.labelTypeOfBirds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAddCage
            // 
            this.panelAddCage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panelAddCage.Controls.Add(this.label19);
            this.panelAddCage.Controls.Add(this.material_cage_list);
            this.panelAddCage.Controls.Add(this.enter_height);
            this.panelAddCage.Controls.Add(this.enter_width);
            this.panelAddCage.Controls.Add(this.enter_length);
            this.panelAddCage.Controls.Add(this.label18);
            this.panelAddCage.Controls.Add(this.label17);
            this.panelAddCage.Controls.Add(this.label16);
            this.panelAddCage.Controls.Add(this.label10);
            this.panelAddCage.Controls.Add(this.enter_index_cage);
            this.panelAddCage.Controls.Add(this.cage_listview);
            this.panelAddCage.Location = new System.Drawing.Point(0, 27);
            this.panelAddCage.Name = "panelAddCage";
            this.panelAddCage.Size = new System.Drawing.Size(1282, 726);
            this.panelAddCage.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label19.Location = new System.Drawing.Point(238, 324);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(156, 23);
            this.label19.TabIndex = 34;
            this.label19.Text = "Cage Material:";
            // 
            // material_cage_list
            // 
            this.material_cage_list.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.material_cage_list.FormattingEnabled = true;
            this.material_cage_list.Items.AddRange(new object[] {
            "Iron",
            "Wood",
            "Plastic"});
            this.material_cage_list.Location = new System.Drawing.Point(226, 359);
            this.material_cage_list.Name = "material_cage_list";
            this.material_cage_list.Size = new System.Drawing.Size(201, 31);
            this.material_cage_list.TabIndex = 33;
            this.material_cage_list.Text = "Select Material";
            // 
            // enter_height
            // 
            this.enter_height.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enter_height.Location = new System.Drawing.Point(499, 210);
            this.enter_height.Name = "enter_height";
            this.enter_height.Size = new System.Drawing.Size(102, 32);
            this.enter_height.TabIndex = 32;
            // 
            // enter_width
            // 
            this.enter_width.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enter_width.Location = new System.Drawing.Point(279, 210);
            this.enter_width.Name = "enter_width";
            this.enter_width.Size = new System.Drawing.Size(102, 32);
            this.enter_width.TabIndex = 31;
            // 
            // enter_length
            // 
            this.enter_length.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enter_length.Location = new System.Drawing.Point(68, 210);
            this.enter_length.Name = "enter_length";
            this.enter_length.Size = new System.Drawing.Size(102, 32);
            this.enter_length.TabIndex = 30;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label18.Location = new System.Drawing.Point(511, 184);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 23);
            this.label18.TabIndex = 29;
            this.label18.Text = "Height:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(299, 184);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 23);
            this.label17.TabIndex = 28;
            this.label17.Text = "Width:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(80, 182);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 23);
            this.label16.TabIndex = 27;
            this.label16.Text = "Length:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(262, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 23);
            this.label10.TabIndex = 26;
            this.label10.Text = "Index Cage:";
            // 
            // enter_index_cage
            // 
            this.enter_index_cage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enter_index_cage.Location = new System.Drawing.Point(225, 112);
            this.enter_index_cage.Name = "enter_index_cage";
            this.enter_index_cage.Size = new System.Drawing.Size(201, 32);
            this.enter_index_cage.TabIndex = 25;
            // 
            // cage_listview
            // 
            this.cage_listview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.cage_listview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cage_listview.ForeColor = System.Drawing.Color.White;
            this.cage_listview.Location = new System.Drawing.Point(669, 39);
            this.cage_listview.Name = "cage_listview";
            this.cage_listview.Size = new System.Drawing.Size(585, 397);
            this.cage_listview.TabIndex = 24;
            this.cage_listview.UseCompatibleStateImageBehavior = false;
            this.cage_listview.View = System.Windows.Forms.View.SmallIcon;
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panelSearch.Location = new System.Drawing.Point(0, 27);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1282, 731);
            this.panelSearch.TabIndex = 2;
            // 
            // panelHelp
            // 
            this.panelHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panelHelp.Controls.Add(this.dataGridViewQA);
            this.panelHelp.Controls.Add(this.panel5);
            this.panelHelp.Location = new System.Drawing.Point(0, 27);
            this.panelHelp.Name = "panelHelp";
            this.panelHelp.Size = new System.Drawing.Size(1282, 733);
            this.panelHelp.TabIndex = 1;
            // 
            // dataGridViewQA
            // 
            this.dataGridViewQA.AllowUserToAddRows = false;
            this.dataGridViewQA.AllowUserToDeleteRows = false;
            this.dataGridViewQA.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.dataGridViewQA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQA.Location = new System.Drawing.Point(471, 0);
            this.dataGridViewQA.Name = "dataGridViewQA";
            this.dataGridViewQA.ReadOnly = true;
            this.dataGridViewQA.RowHeadersWidth = 51;
            this.dataGridViewQA.RowTemplate.Height = 29;
            this.dataGridViewQA.Size = new System.Drawing.Size(811, 727);
            this.dataGridViewQA.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.textBoxQuestion);
            this.panel5.Controls.Add(this.pictureBoxSubmitQuestion);
            this.panel5.Controls.Add(this.pictureBox7);
            this.panel5.Controls.Add(this.labelSubmitHelp);
            this.panel5.Location = new System.Drawing.Point(0, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(469, 693);
            this.panel5.TabIndex = 5;
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.textBoxQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxQuestion.ForeColor = System.Drawing.Color.White;
            this.textBoxQuestion.Location = new System.Drawing.Point(17, 115);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(427, 465);
            this.textBoxQuestion.TabIndex = 7;
            // 
            // pictureBoxSubmitQuestion
            // 
            this.pictureBoxSubmitQuestion.Image = global::Birds_Mangmeant.Properties.Resources.icons8_submit_58;
            this.pictureBoxSubmitQuestion.Location = new System.Drawing.Point(181, 603);
            this.pictureBoxSubmitQuestion.Name = "pictureBoxSubmitQuestion";
            this.pictureBoxSubmitQuestion.Size = new System.Drawing.Size(49, 39);
            this.pictureBoxSubmitQuestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSubmitQuestion.TabIndex = 5;
            this.pictureBoxSubmitQuestion.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Birds_Mangmeant.Properties.Resources.icons8_help_50;
            this.pictureBox7.Location = new System.Drawing.Point(430, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(35, 33);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            // 
            // labelSubmitHelp
            // 
            this.labelSubmitHelp.AutoSize = true;
            this.labelSubmitHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSubmitHelp.ForeColor = System.Drawing.Color.White;
            this.labelSubmitHelp.Location = new System.Drawing.Point(142, 69);
            this.labelSubmitHelp.Name = "labelSubmitHelp";
            this.labelSubmitHelp.Size = new System.Drawing.Size(154, 20);
            this.labelSubmitHelp.TabIndex = 3;
            this.labelSubmitHelp.Text = "Submit Question:";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.PanelAddBird);
            this.Controls.Add(this.panelAddCage);
            this.Controls.Add(this.panelHelp);
            this.Controls.Add(this.panelSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.PanelAddBird.ResumeLayout(false);
            this.PanelAddBird.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.panelHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBirdFly)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSaveList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelAddCage.ResumeLayout(false);
            this.panelAddCage.PerformLayout();
            this.panelHelp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQA)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSubmitQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}