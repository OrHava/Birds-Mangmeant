using FireSharp.Interfaces;
using FireSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Exceptions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.Mime.MediaTypeNames;
using Birds_Mangmeant.Properties;
using System.Net;
using Image = System.Drawing.Image;
using FireSharp.Response;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Runtime.Intrinsics.X86;
using Google.Apis.Util;
using System.Windows.Forms;

using NPlot;
using RestSharp.Extensions;
using System.Collections;
using System.Timers;
using System.Diagnostics;

namespace Birds_Mangmeant
{
    public partial class Home : Form
    {
        List<Tuple<string, string, string, string, string, string, string, Tuple<string>>> BirdList = new List<Tuple<string, string, string, string, string, string, string, Tuple<string>>>();
        private System.Timers.Timer timer = new System.Timers.Timer();
        private int frameIndex = 0;

        List<Tuple<string, string, string, string, string, string, string, Tuple<string>>> BirdListSearch = new List<Tuple<string, string, string, string, string, string, string, Tuple<string>>>();



        private System.Timers.Timer timer1;
        private int x;

        public Home()
        {
            InitializeComponent();






            // Set up the timer for bird gif
            timer1 = new System.Timers.Timer();
            timer1.Interval = 50; // Change this value to adjust the speed of the animation
            timer1.Elapsed += Timer1_Elapsed;

            // Start the timer
            timer1.Start();













            // start the timer for birds image
            timer.Interval = 1000; // update every 100ms
            timer.Elapsed += Timer_Elapsed;
            timer.AutoReset = true;
            timer.Enabled = true;




            pictureBoxProfile.ImageLocation = Properties.Settings.Default.PictureProfile;


            if (labelUserName.Text != null)
            {
                labelUserName.Text = "User Name: " + Login.currentusername;
            }

            labelTypeOfBirds.Text = amountofBirds().ToString();
            labelId.Text = "User ID: " + userId();
            labelEmail.Text = "User Email: " + userEmail();
            textBoxListOfChores.Text = getChores();
            labelAmountUsers.Text = amountofUsers().ToString();
            loadQAList();
            createGraph();


        }





        private void Timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            // Move the bird to the left by changing its X coordinate
            x -= 5; // Change this value to adjust the distance the bird moves each tick

            // If the bird goes off the left edge of the screen, wrap it around to the right edge
            if (x + pictureBoxBirdFly.Width < 0)
            {
                if (pictureBoxBirdFly.Parent == panelUser) // Check if pictureBoxBirdFly is on panelUser
                {
                    x = panelUser.Width - pictureBoxBirdFly.Width; // Set x to the right edge of panelUser
                }
                else // If pictureBoxBirdFly is not on panelUser, wrap it around to the right edge of the form
                {
                    x = this.ClientSize.Width;
                }
            }

            // Update the bird's position on the UI thread
            Task.Run(() =>
            {
                if (pictureBoxBirdFly.InvokeRequired)
                {
                    pictureBoxBirdFly.Invoke(new Action(() =>
                    {
                        pictureBoxBirdFly.Location = new Point(x, pictureBoxBirdFly.Location.Y);
                    }));
                }
                else
                {
                    pictureBoxBirdFly.Location = new Point(x, pictureBoxBirdFly.Location.Y);
                }
            });
        }


        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            // increment the frame index and wrap around
            frameIndex = (frameIndex + 1) % 7;

            // get the image and bird name for the current frame index
            (string birdName, Image image) = GetFrame(frameIndex);

            // update the image and bird name in the picture box and label
            if (pictureBoxAnim.IsHandleCreated)
            {
                pictureBoxAnim.Invoke(new Action(() =>
                {
                    pictureBoxAnim.Image = image;
                }));
            }

            if (labelBirdAnim.IsHandleCreated)
            {
                labelBirdAnim.Invoke(new Action(() =>
                {
                    labelBirdAnim.Text = "Bird Name: " + birdName;
                }));
            }
        }



        // get the image and bird name for the given frame index
        private (string, Image) GetFrame(int index)
        {
            Image image = null;
            string birdName = "";

            switch (index)
            {
                case 0:
                    image = Properties.Resources.CentrelAmerica;
                    birdName = "Central America";
                    break;
                case 1:
                    image = Properties.Resources.NorthAmerica;
                    birdName = "North America";
                    break;
                case 2:
                    image = Properties.Resources.South_America;
                    birdName = "South America";
                    break;
                case 3:
                    image = Properties.Resources.Eastren_Europe;
                    birdName = "Eastern Europe";
                    break;
                case 4:
                    image = Properties.Resources.Western_Europe;
                    birdName = "Western Europe";
                    break;
                case 5:
                    image = Properties.Resources.Australian_Center;
                    birdName = "Australian Center";
                    break;
                case 6:
                    image = Properties.Resources.Australian_City_Beachs;
                    birdName = "Australian City Beaches";
                    break;
                default:
                    break;
            }

            return (birdName, image);
        }




        public void createGraph()
        {


            plotSurface2d1.Title = "You dont have birds yet to show their breeds and amount.";
            plotSurface2d1.Enabled = false;

            try
            {
                client = new FireSharp.FirebaseClient(config);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Check Your connection!");
            }



            FirebaseResponse response2 = client.Get("users/" + Login.currentusername + "/Birds/");
            Dictionary<string, Bird> data = response2.ResultAs<Dictionary<string, Bird>>();


            if (data != null)
            {
                List<Bird> birds = data.Values.ToList();

                int northAmericaCount = 0;
                int centerAmericaCount = 0;
                int southAmericaCount = 0;
                int easternEuropeCount = 0;
                int westernEuropeCount = 0;
                int australianCenterCount = 0;
                int australianCityBeachesCount = 0;

                foreach (var bird in birds)
                {


                    if (bird.Subspecies == "North America")
                    {
                        northAmericaCount++;
                    }
                    else if (bird.Subspecies == "Center America")
                    {
                        centerAmericaCount++;
                    }
                    else if (bird.Subspecies == "South America")
                    {
                        southAmericaCount++;
                    }
                    else if (bird.Subspecies == "Eastren Europe")
                    {
                        easternEuropeCount++;
                    }
                    else if (bird.Subspecies == "Western Europe")
                    {
                        westernEuropeCount++;
                    }
                    else if (bird.Subspecies == "Australian Center")
                    {
                        australianCenterCount++;
                    }
                    else if (bird.Subspecies == "Australian City Beaches")
                    {
                        australianCityBeachesCount++;
                    }

                }



                string[] birdBreeds2 = { "1", "2", "3", "4", "5", "6", "7" };
                int[] birdAmounts = { northAmericaCount, centerAmericaCount, southAmericaCount, easternEuropeCount, westernEuropeCount, australianCenterCount, australianCityBeachesCount };






                LinePlot birdPlot = new LinePlot();

                birdPlot.AbscissaData = birdBreeds2;
                birdPlot.OrdinateData = birdAmounts;
                birdPlot.Pen = new Pen(Color.FromArgb(37, 42, 64), 5);


                plotSurface2d1.Clear();
                plotSurface2d1.Add(birdPlot);
                plotSurface2d1.XAxis1.Color = Color.White;
                plotSurface2d1.YAxis1.Color = Color.White;

                plotSurface2d1.Refresh();
            }







        }

        public string userId()
        {

            string id = "";
            try
            {
                client = new FireSharp.FirebaseClient(config);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Check Your connection!");
            }

            FirebaseResponse response2 = client.Get("users/" + Login.currentusername + "/ID");

            id = response2.ResultAs<String>();
            return id;

        }

        public string userEmail()
        {

            string Email = "";
            try
            {
                client = new FireSharp.FirebaseClient(config);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Check Your connection!");
            }

            FirebaseResponse response2 = client.Get("users/" + Login.currentusername + "/Email");


            Email = response2.ResultAs<String>();
            return Email;


        }

        public string getChores()
        {

            string chores = "";
            try
            {
                client = new FireSharp.FirebaseClient(config);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Check Your connection!");
            }


            FirebaseResponse response2 = client.Get("users/" + Login.currentusername + "/Chores");
            if (response2 != null && response2.ResultAs<string>() != null)
            {


                // rest of the code
                chores = response2.ResultAs<String>();
            }




            return chores;

        }
        public int amountofBirds()
        {
            int childCount = 0;
            try
            {
                client = new FireSharp.FirebaseClient(config);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Check Your connection!");
            }

            FirebaseResponse response2 = client.Get("users/" + Login.currentusername + "/Birds");
            if (response2 != null && response2.ResultAs<Dictionary<string, object>>() != null)
            {


                // rest of the code
                childCount = response2.ResultAs<Dictionary<string, object>>().Count;
            }




            return childCount;



        }

        public int amountofUsers()
        {
            int childCount = 0;
            try
            {
                client = new FireSharp.FirebaseClient(config);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Check Your connection!");
            }
            FirebaseResponse response2 = client.Get("users/");
            if (response2 != null && response2.ResultAs<Dictionary<string, object>>() != null)
            {

                // rest of the code
                childCount = response2.ResultAs<Dictionary<string, object>>().Count;
            }




            return childCount;



        }


        private void loadQAList()
        {



            dataGridViewQA.AutoGenerateColumns = false;
            dataGridViewQA.RowHeadersVisible = false;
            dataGridViewQA.MultiSelect = false;
            dataGridViewQA.ColumnHeadersVisible = false;
            dataGridViewQA.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewQA.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewQA.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewQA.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Questions",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 25
            });
            dataGridViewQA.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Answers",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 75
            });

            dataGridViewQA.Rows.Add(new String[] { "Question 1: What are Gouldian birds?",
                             "Answer 1: Gouldian birds, also known as Gouldian finches, are a species of small, brightly colored birds native to Australia." });

            dataGridViewQA.Rows.Add(new String[] { "Question 2: What are the different breeds of Gouldian birds?",
                             "Answer 2: There are three recognized breeds of Gouldian birds: black-headed, red-headed, and yellow-headed." });

            dataGridViewQA.Rows.Add(new String[] { "Question 3: What is the difference between the three breeds of Gouldian birds?",
                             "Answer 3: The primary difference between the three breeds of Gouldian birds is the color of their head feathers. Black-headed Gouldian birds have a black head, red-headed Gouldian birds have a red head, and yellow-headed Gouldian birds have a yellow head." });

            dataGridViewQA.Rows.Add(new String[] { "Question 4: What is the average lifespan of a Gouldian bird?",
                             "Answer 4: The average lifespan of a Gouldian bird is approximately 6-8 years." });

            dataGridViewQA.Rows.Add(new String[] { "Question 5: What is the ideal diet for Gouldian birds?",
                             "Answer 5: The ideal diet for Gouldian birds consists of a high-quality seed mix, fresh fruits and vegetables, and a source of protein such as boiled eggs or mealworms." });

            dataGridViewQA.Rows.Add(new String[] { "Question 6: How many eggs does a Gouldian bird lay at a time?",
                             "Answer 6:  Gouldian birds typically lay 4-6 eggs in each clutch." });

            dataGridViewQA.Rows.Add(new String[] { "Question 7: What is the incubation period for Gouldian bird eggs?",
                             "Answer 7: The incubation period for Gouldian bird eggs is approximately 14 days." });

            dataGridViewQA.Rows.Add(new String[] { "Question 8: Can Gouldian birds be kept in cages with other bird species?",
                             "Answer 8: Gouldian birds can be kept in cages with other bird species as long as they are of similar size and temperament." });

            dataGridViewQA.Rows.Add(new String[] { "Question 9: What is the best type of cage for Gouldian birds?",
                             "Answer 9: he best type of cage for Gouldian birds is a large, spacious cage that allows them to fly and exercise." });

            dataGridViewQA.Rows.Add(new String[] { "Question 10: How can you tell the gender of a Gouldian bird?",
                             "Answer 10: The gender of a Gouldian bird can be determined by the color of their beak. Males have a darker, more vibrant color than females." });

            dataGridViewQA.Rows.Add(new String[] { "Question 11: What is the name of the program for managing Gouldian birds?",
                             "Answer 11: The name of the program for managing Gouldian birds is Birds Mangmeant." });

            dataGridViewQA.Rows.Add(new String[] { "Question 12: What are the main features of the Gouldian Manager program?",
                             "Answer 12: The main features of the Gouldian Manager program include the ability to add and manage information about Gouldian birds and their cages, track breeding cycles and clutch information, and generate reports and analytics." });

            dataGridViewQA.Rows.Add(new String[] { "Question 13: s the Gouldian Manager program easy to use?",
                             "Answer 13: Yes, the Gouldian Manager program is designed to be user-friendly and easy to navigate." });

            dataGridViewQA.Rows.Add(new String[] { "Question 14: s the Gouldian Manager program available for both Windows and Mac operating systems?",
                             "Answer 14: No, the Gouldian Manager program is available for Windows only and not to Mac operating systems." });

            dataGridViewQA.Rows.Add(new String[] { "Question 15: Can the Gouldian Manager program be used on mobile devices?",
                             "Answer 15: No, the Gouldian Manager program is not currently available for use on mobile devices." });

            dataGridViewQA.Rows.Add(new String[] { "Question 16: Is the Gouldian Manager program free to download and use?",
                             "Answer 16: No, the Gouldian Manager program is not free. It is available for purchase on the developer's website." });

            dataGridViewQA.Rows.Add(new String[] { "Question 17: Can multiple users access the Gouldian Manager program at the same time?",
                             "Answer 17: Yes, the Gouldian Manager program supports multiple user accounts and can be accessed by multiple users simultaneously." });

            dataGridViewQA.Rows.Add(new String[] { "Question 18: Is the Gouldian Manager program customizable?",
                             "Answer 18: Yes, the Gouldian Manager program is highly customizable and can be tailored to meet the specific needs of the user." });

            dataGridViewQA.Rows.Add(new String[] { "Question 19: Is technical support available for the Gouldian Manager program?",
                             "Answer 19: Yes, technical support is available for the Gouldian Manager program through the developer's website and help form." });

            dataGridViewQA.Rows.Add(new String[] { "Question 20: Can the Gouldian Manager program be integrated with other software programs?",
                             "Answer 20: No, as of now." });


            foreach (DataGridViewRow row in dataGridViewQA.Rows)
            {
                foreach (DataGridViewColumn col in dataGridViewQA.Columns)
                {
                    dataGridViewQA.Rows[row.Index].Cells[col.Index].Style.BackColor = Color.FromArgb(37, 42, 64);
                    dataGridViewQA.Rows[row.Index].Cells[col.Index].Style.ForeColor = Color.White;

                }
            }
        }



        private void loadBirdsList()
        {
            listViewBirds.Clear();
            BirdList.Clear();

            try
            {
                client = new FireSharp.FirebaseClient(config);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Check Your connection!");
            }


            FirebaseResponse response2 = client.Get("users/" + Login.currentusername + "/Birds");
            Dictionary<string, Bird> result2;
            try
            {
                result2 = response2.ResultAs<Dictionary<string, Bird>>();
            }
            catch (Newtonsoft.Json.JsonSerializationException ex)
            {
                MessageBox.Show("Error deserializing JSON string: " + ex.Message);
                result2 = new Dictionary<string, Bird>();
            }

            if (result2 != null)
            {
                foreach (var get in result2)
                {
                    BirdList.Add(Tuple.Create(

                        get.Value.IndexNumber,
                        get.Value.Breed_of_Bird,
                        item3: get.Value.Subspecies,
                        get.Value.HatchDate,
                        get.Value.IndexCage,
                        get.Value.IndexMother,
                        get.Value.IndexFather,
                        get.Value.Gender




                    ));
                }

            }











            // Load the image from resources

            Image image = Resources.icons8_puffin_bird_50;
            Image image1 = Resources.CentrelAmerica;
            Image image2 = Resources.NorthAmerica;
            Image image3 = Resources.South_America;
            Image image4 = Resources.Eastren_Europe;
            Image image5 = Resources.Western_Europe;
            Image image6 = Resources.Australian_City_Beachs;
            Image image7 = Resources.Australian_Center;
            // Add the image to the ImageList control
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(32, 32); // Set the size of the images in the list


            int i = 0;
            // Example of how to access the items in BirdsList

            if (BirdList != null)
            {
                foreach (var birdTuple in BirdList)
                {
                    string indexNumber = birdTuple.Item1;
                    string breedOfBird = birdTuple.Item2;
                    string subspecies = birdTuple.Item3;
                    string hatchDate = birdTuple.Item4;
                    string indexCage = birdTuple.Item5;
                    string indexMother = birdTuple.Item6;
                    string indexFather = birdTuple.Item7;
                    string gender = birdTuple.Rest.Item1;

                    // Do something with the birdTuple items...








                    if (subspecies == "North America")
                    {

                        imageList.Images.Add(image2);
                    }
                    else if (subspecies == "Center America")
                    {
                        imageList.Images.Add(image1);
                    }

                    else if (subspecies == "South America")
                    {
                        imageList.Images.Add(image3);
                    }

                    else if (subspecies == "Eastren Europe")
                    {
                        imageList.Images.Add(image4);
                    }

                    else if (subspecies == "Western Europe")
                    {
                        imageList.Images.Add(image5);
                    }
                    else if (subspecies == "Australian Center")
                    {
                        imageList.Images.Add(image7);
                    }

                    else if (subspecies == "Australian City Beaches")
                    {
                        imageList.Images.Add(image6);
                    }
                    else
                    {
                        imageList.Images.Add(image);
                    }





                    listViewBirds.SmallImageList = imageList;

                    // Create a new ListViewItem and set its ImageIndex property to the index of the image in the ImageList
                    ListViewItem item = new ListViewItem("indexNumber: " + indexNumber + ", breedOfBird: " + breedOfBird + ", subspecies: " + subspecies + ", hatchDate: " + hatchDate + ", indexCage: " + indexCage + ", indexMother: " + indexMother + ", indexFather: " + indexFather + ", Gender: " + gender);
                    item.ImageIndex = i;
                    i++;
                    // Add the ListViewItem to the ListView control
                    listViewBirds.Items.Add(item);
                }

            }






            listViewBirds.GridLines = true;
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
                // Create a copy of the collection of open forms
                List<Form> openForms = new List<Form>(System.Windows.Forms.Application.OpenForms.Count);
                foreach (Form form in System.Windows.Forms.Application.OpenForms)
                {
                    openForms.Add(form);
                }

                // Close all open forms except the main form
                foreach (Form form in openForms)
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





        private void checkBoxMale_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMale.Checked == true)
            {
                checkBoxFemale.Checked = false;
            }
        }

        private void checkBoxFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFemale.Checked == true)
            {
                checkBoxMale.Checked = false;
            }

        }


        private void listViewBirds_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int index = listViewBirds.FocusedItem.Index;
            if (!BirdList[index].Equals(null))
            {

                textBoxIndexNumber.Text = BirdList[index].Item1;
                comboBoxBreed.Text = BirdList[index].Item2;
                comboBoxSubspecies.Text = BirdList[index].Item3;
                dateTimePicker1.Text = BirdList[index].Item4;
                textBoxIndexCage.Text = BirdList[index].Item5;
                textBoxIndexMotherofBird.Text = BirdList[index].Item6;
                textBoxIndexFatherofBird.Text = BirdList[index].Item7;

                if (BirdList[index].Rest.Item1 == "Male")
                {
                    checkBoxMale.Checked = true;
                }
                else
                {
                    checkBoxMale.Checked = false;
                }

                if (BirdList[index].Rest.Item1 == "Female")
                {
                    checkBoxFemale.Checked = true;
                }
                else
                {
                    checkBoxFemale.Checked = false;
                }


            }
        }



        private void ButtonAddBird_Click(object sender, EventArgs e)
        {
            panelHome.Visible = false;
            panelHome.Hide();

            panelAddCage.Visible = false;
            panelAddCage.Hide();
            panelSearch.Visible = false;


            panelHelp.Visible = false;
            panelHelp.Hide();
            panelSearch.Hide();

            panelUser.Visible = false;
            panelUser.Hide();

            PanelAddBird.Show();
            PanelAddBird.Visible = true;
            PanelAddBird.BringToFront();
            PanelAddBird.Enabled = true;
            loadBirdsList();

        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            PanelAddBird.Visible = false;
            PanelAddBird.Hide();

            panelHome.Visible = false;
            panelHome.Hide();


            panelHome.Visible = false;
            panelHome.Hide();

            panelSearch.Visible = false;
            panelSearch.Hide();

            panelUser.Visible = false;
            panelUser.Hide();


            panelHelp.Show();
            panelHelp.Visible = true;
            panelHelp.BringToFront();
        }

        private void ButtonSignOut_Click_1(object sender, EventArgs e)
        {
            Login hm = new Login();
            this.Hide();

            hm.ShowDialog();
            this.Close();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            PanelAddBird.Visible = false;
            PanelAddBird.Hide();

            panelHome.Visible = false;
            panelHome.Hide();


            panelHome.Visible = false;
            panelHome.Hide();

            panelHelp.Visible = false;
            panelHelp.Hide();

            panelUser.Visible = false;
            panelUser.Hide();


            panelSearch.Show();
            panelSearch.Visible = true;
            panelSearch.BringToFront();
        }

        private void ButtonAddCage_Click(object sender, EventArgs e)
        {

            PanelAddBird.Visible = false;
            PanelAddBird.Hide();

            panelHome.Visible = false;
            panelHome.Hide();

            panelSearch.Visible = false;
            panelSearch.Hide();

            panelHelp.Visible = false;
            panelHelp.Hide();



            panelUser.Visible = false;
            panelUser.Hide();
            panelAddCage.Show();
            panelAddCage.Visible = true;
            panelAddCage.BringToFront();
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            PanelAddBird.Visible = false;
            PanelAddBird.Hide();

            panelAddCage.Visible = false;
            panelAddCage.Hide();
            panelSearch.Visible = false;
            panelSearch.Hide();

            panelHelp.Visible = false;
            panelHelp.Hide();




            panelUser.Show();
            panelUser.Visible = true;
            panelUser.BringToFront();
            panelUser.Enabled = true;

            panelHome.Show();
            panelHome.Visible = true;
            panelHome.BringToFront();
            panelHome.Enabled = true;
            labelTypeOfBirds.Text = amountofBirds().ToString();
            createGraph();
        }







        private void pictureBoxProfile_Click_1(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxProfile.ImageLocation = openFileDialog.FileName;

                    Properties.Settings.Default.PictureProfile = openFileDialog.FileName;
                }
            }
        }







        private void pictureBoxSaveList_Click_1(object sender, EventArgs e)
        {
            IFirebaseClient client = new FirebaseClient(config);



            try
            {

                client.Set("users/" + Login.currentusername + "/Chores", textBoxListOfChores.Text);
                MessageBox.Show("You saved Succefully Chores.");

                this.ActiveControl = null;
            }
            catch (FirebaseException)
            {
                // handle failure ...
            }
        }


        private void pictureBoxSubmitQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                string timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff"); // generate a unique timestamp
                client.Set("QuestionsFromUsers/" + Login.currentusername + "/" + timestamp, textBoxQuestion.Text); // use the timestamp as part of the key
                MessageBox.Show("You submit Succefully a question: " + textBoxQuestion.Text);

                this.ActiveControl = null;
                textBoxQuestion.Clear();
            }
            catch (FirebaseException)
            {
                // handle failure ...
            }
        }


        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            createGraph();
        }



        private void listViewBirds_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string message = "Do you want to remove this bird?";
            string title = "Delete Bird";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {

                try
                {
                    client = new FireSharp.FirebaseClient(config);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "Check Your connection!");
                    return; // stop execution if client couldn't be created
                }

                if (listViewBirds.SelectedItems.Count == 0)
                {
                    MessageBox.Show("No bird selected!");
                    return; // stop execution if no bird is selected
                }

                int index = listViewBirds.FocusedItem.Index;
                if (index >= BirdList.Count)
                {
                    MessageBox.Show("Invalid bird index!");
                    return; // stop execution if index is out of range
                }

                string indexBird = BirdList[index].Item1;

                if (client != null)
                {
                    FirebaseResponse response2 = client.Delete("users/" + Login.currentusername + "/Birds/" + indexBird);
                    loadBirdsList();
                }
                else
                {
                    MessageBox.Show("Firebase client is null!");
                }





            }

            else
            {
                // Do something  

            }
        }





        private void pictureBoxAddBird_Click(object sender, EventArgs e)
        {
            bool isNumeric = Regex.IsMatch(textBoxIndexNumber.Text, @"^\d+$");
            bool isNumeric2 = Regex.IsMatch(textBoxIndexFatherofBird.Text, @"^\d+$");
            bool isNumeric3 = Regex.IsMatch(textBoxIndexMotherofBird.Text, @"^\d+$");

            if (!isNumeric)
            {
                MessageBox.Show("Index Number of Bird can only contain numbers.");
            }
            else if (!isNumeric2)
            {
                MessageBox.Show("Index Number of Father of Bird can only contain numbers.");
            }
            else if (!isNumeric3)
            {
                MessageBox.Show("Index Number of Mother of Bird can only contain numbers.");
            }


            else if (comboBoxBreed.Text == "American gouldian" && (comboBoxSubspecies.Text == "Eastren Europe" || comboBoxSubspecies.Text == "Western Europe" || comboBoxSubspecies.Text == "Australian Center" || comboBoxSubspecies.Text == "Australian City Beaches"))
            {
                MessageBox.Show("Breed and Subspecies Dont match.");
            }

            else if (comboBoxBreed.Text != "American gouldian" && comboBoxBreed.Text != "European gouldian" && comboBoxBreed.Text != "Australian gouldian")
            {
                MessageBox.Show("Please Select Breed.");
            }

            else if (comboBoxSubspecies.Text != "Eastren Europe" && comboBoxSubspecies.Text != "Western Europe" && comboBoxSubspecies.Text != "Australian Center" && comboBoxSubspecies.Text != "Australian City Beaches" && comboBoxSubspecies.Text != "North America" && comboBoxSubspecies.Text != "Center America" && comboBoxSubspecies.Text != "South America")
            {
                MessageBox.Show("Please Select Subspecies.");
            }
            else if (comboBoxBreed.Text == "Select Breed" && comboBoxSubspecies.Text == "Select Subspecies")
            {
                MessageBox.Show("Please Select Breed and Subspecies.");
            }


            else if (comboBoxBreed.Text == "European gouldian" && (comboBoxSubspecies.Text == "North America" || comboBoxSubspecies.Text == "Center America" || comboBoxSubspecies.Text == "South America" || comboBoxSubspecies.Text == "Australian Center" || comboBoxSubspecies.Text == "Australian City Beaches"))
            {
                MessageBox.Show("Breed and Subspecies Dont match.");
            }


            else if (comboBoxBreed.Text == "Australian gouldian" && (comboBoxSubspecies.Text == "Eastren Europe" || comboBoxSubspecies.Text == "Western Europe" || comboBoxSubspecies.Text == "North America" || comboBoxSubspecies.Text == "Center America" || comboBoxSubspecies.Text == "South America"))
            {
                MessageBox.Show("Breed and Subspecies Dont match.");
            }

            else
            {

                string maleorfemale = "Male";

                if (checkBoxMale.Checked == true)
                {
                    maleorfemale = "Male";
                }
                else if (checkBoxFemale.Checked == true)
                {
                    maleorfemale = "Female";
                }
                IFirebaseClient client = new FirebaseClient(config);
                var Bird = new Bird
                {
                    IndexNumber = textBoxIndexNumber.Text,
                    Breed_of_Bird = comboBoxBreed.Text,
                    Subspecies = comboBoxSubspecies.Text,
                    HatchDate = dateTimePicker1.Value.ToString("yyyy-MM-dd"),
                    IndexCage = textBoxIndexCage.Text,
                    IndexMother = textBoxIndexMotherofBird.Text,
                    IndexFather = textBoxIndexFatherofBird.Text,
                    Gender = maleorfemale,

                };


                try
                {

                    client.Set("users/" + Login.currentusername + "/Birds/" + textBoxIndexNumber.Text, Bird);
                    MessageBox.Show("You Add Succefully Bird Number Index: " + textBoxIndexNumber.Text);
                    loadBirdsList();

                }
                catch (FirebaseException)
                {
                    // handle failure ...
                }

            }
        }

        private void pictureBoxSearchBird_Click(object sender, EventArgs e)
        {
            listViewSearch.Clear();
            BirdListSearch.Clear();

            try
            {
                client = new FireSharp.FirebaseClient(config);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Check Your connection!");
            }


            FirebaseResponse response2 = client.Get("users/" + Login.currentusername + "/Birds");
            Dictionary<string, Bird> result2;
            try
            {
                result2 = response2.ResultAs<Dictionary<string, Bird>>();
            }
            catch (Newtonsoft.Json.JsonSerializationException ex)
            {
                MessageBox.Show("Error deserializing JSON string: " + ex.Message);
                result2 = new Dictionary<string, Bird>();
            }



            if (result2 != null)
            {
                foreach (var get in result2)
                {

                    if (textBoxIndexSearch.Text == get.Value.IndexNumber && textBoxGenderSearch.Text == get.Value.Gender && comboBoxSubSpeciesSearch.Text == get.Value.Subspecies && dateTimePicker2.Value.ToString("yyyy-MM-dd") == get.Value.HatchDate)
                    {

                        BirdListSearch.Add(Tuple.Create(

                            get.Value.IndexNumber,
                            get.Value.Breed_of_Bird,
                            item3: get.Value.Subspecies,
                            get.Value.HatchDate,
                            get.Value.IndexCage,
                            get.Value.IndexMother,
                            get.Value.IndexFather,
                            get.Value.Gender




                        ));
                    }



                }

            }











            // Load the image from resources

            Image image = Resources.icons8_puffin_bird_50;
            Image image1 = Resources.CentrelAmerica;
            Image image2 = Resources.NorthAmerica;
            Image image3 = Resources.South_America;
            Image image4 = Resources.Eastren_Europe;
            Image image5 = Resources.Western_Europe;
            Image image6 = Resources.Australian_City_Beachs;
            Image image7 = Resources.Australian_Center;
            // Add the image to the ImageList control
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(32, 32); // Set the size of the images in the list


            int i = 0;
            // Example of how to access the items in BirdsList

            if (BirdListSearch != null)
            {
                foreach (var birdTuple in BirdListSearch)
                {
                    string indexNumber = birdTuple.Item1;
                    string breedOfBird = birdTuple.Item2;
                    string subspecies = birdTuple.Item3;
                    string hatchDate = birdTuple.Item4;
                    string indexCage = birdTuple.Item5;
                    string indexMother = birdTuple.Item6;
                    string indexFather = birdTuple.Item7;
                    string gender = birdTuple.Rest.Item1;

                    // Do something with the birdTuple items...








                    if (subspecies == "North America")
                    {

                        imageList.Images.Add(image2);
                    }
                    else if (subspecies == "Center America")
                    {
                        imageList.Images.Add(image1);
                    }

                    else if (subspecies == "South America")
                    {
                        imageList.Images.Add(image3);
                    }

                    else if (subspecies == "Eastren Europe")
                    {
                        imageList.Images.Add(image4);
                    }

                    else if (subspecies == "Western Europe")
                    {
                        imageList.Images.Add(image5);
                    }
                    else if (subspecies == "Australian Center")
                    {
                        imageList.Images.Add(image7);
                    }

                    else if (subspecies == "Australian City Beaches")
                    {
                        imageList.Images.Add(image6);
                    }
                    else
                    {
                        imageList.Images.Add(image);
                    }





                    listViewSearch.SmallImageList = imageList;

                    // Create a new ListViewItem and set its ImageIndex property to the index of the image in the ImageList
                    ListViewItem item = new ListViewItem("indexNumber: " + indexNumber + ", breedOfBird: " + breedOfBird + ", subspecies: " + subspecies + ", hatchDate: " + hatchDate + ", indexCage: " + indexCage + ", indexMother: " + indexMother + ", indexFather: " + indexFather + ", Gender: " + gender);
                    item.ImageIndex = i;
                    i++;
                    // Add the ListViewItem to the ListView control
                    listViewSearch.Items.Add(item);
                }

            }






            listViewSearch.GridLines = true;
        }
    }
}

