
using FireSharp;
using FireSharp.Exceptions;
using Birds_Mangmeant.Properties;
using Image = System.Drawing.Image;
using FireSharp.Response;
using System.Text.RegularExpressions;
using NPlot;
using Newtonsoft.Json;
using FireSharp.Config;


namespace Birds_Mangmeant
{
    public partial class Home : Form
    {
        Dictionary<string, Tuple<string, string, string, string, string, string, string, Tuple<Tuple<string, string, string, string>>>> BirdList = new Dictionary<string, Tuple<string, string, string, string, string, string, string, Tuple<Tuple<string, string, string, string>>>>();
        private System.Timers.Timer timer = new System.Timers.Timer();
        private int frameIndex = 0;

        List<Tuple<string, string, string, string, string, string, string, Tuple<Tuple<string, string, string, string>>>> BirdListSearch = new List<Tuple<string, string, string, string, string, string, string, Tuple<Tuple<string, string, string, string>>>>();

        List<Tuple<string, string, string, string, string, int, string, Tuple<string>>> CageListSearch = new List<Tuple<string, string, string, string, string, int, string, Tuple<string>>>();


        List<Tuple<string, string, string, string, string, int, Dictionary<string, Bird>?, Tuple<string>>> CageList = new List<Tuple<string, string, string, string, string, int, Dictionary<string, Bird>?, Tuple<string>>>();
        List<Tuple<string, string, string, string, string, int, string, Tuple<string>>> sortedList = new List<Tuple<string, string, string, string, string, int, string, Tuple<string>>>();

        //private System.Timers.Timer timer1;
        //private int x;
        private static FirebaseClient client;

        public Home()
        {
            InitializeComponent();



            // Initialize Firebase client
            var config = new FirebaseConfig
            {
                AuthSecret = "X0ef9KE6sIzPgMR7rlUj52AWMITXNJXPEIMNKHF9",
                BasePath = "https://birds-mannagemeant-default-rtdb.firebaseio.com/"

            };

            client = new FirebaseClient(config);


            //// Set up the timer for bird gif but make code very slow in the start
            //timer1 = new System.Timers.Timer();
            //timer1.Interval = 50; // Change this value to adjust the speed of the animation
            //timer1.Elapsed += Timer1_Elapsed;

            //// Start the timer
            //timer1.Start();













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
            labelId.Text = "User ID: " + UserId();
            labelEmail.Text = "User Email: " + UserEmail();
            textBoxListOfChores.Text = getChores();
            labelAmountUsers.Text = amountofUsers().ToString();
            labelNumCages.Text = amountofCages().ToString();
            loadQAList();
            createGraph();


        }





        //private void Timer1_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        //{
        //    // Move the bird to the left by changing its X coordinate
        //    x -= 5; // Change this value to adjust the distance the bird moves each tick

        //    // If the bird goes off the left edge of the screen, wrap it around to the right edge
        //    if (x + pictureBoxBirdFly.Width < 0)
        //    {
        //        if (pictureBoxBirdFly.Parent == panelUser) // Check if pictureBoxBirdFly is on panelUser
        //        {
        //            x = panelUser.Width - pictureBoxBirdFly.Width; // Set x to the right edge of panelUser
        //        }
        //        else // If pictureBoxBirdFly is not on panelUser, wrap it around to the right edge of the form
        //        {
        //            x = this.ClientSize.Width;
        //        }
        //    }

        //    // Update the bird's position on the UI thread
        //    Task.Run(() =>
        //    {
        //        if (pictureBoxBirdFly.InvokeRequired)
        //        {
        //            pictureBoxBirdFly.Invoke(new Action(() =>
        //            {
        //                pictureBoxBirdFly.Location = new Point(x, pictureBoxBirdFly.Location.Y);
        //            }));
        //        }
        //        else
        //        {
        //            pictureBoxBirdFly.Location = new Point(x, pictureBoxBirdFly.Location.Y);
        //        }
        //    });
        //}


        private void Timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            // increment the frame index and wrap around
            frameIndex = (frameIndex + 1) % 7;

            // get the image and bird name for the current frame index
            (string? birdName, Image? image) = GetFrame(frameIndex);

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
        private (string?, Image?) GetFrame(int index)
        {
            Image? image = null;
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






                    LinePlot birdPlot = new LinePlot
                    {
                        AbscissaData = birdBreeds2,
                        OrdinateData = birdAmounts,
                        Pen = new Pen(Color.FromArgb(37, 42, 64), 5)
                    };


                    plotSurface2d1.Clear();
                    plotSurface2d1.Add(birdPlot);
                    plotSurface2d1.XAxis1.Color = Color.White;
                    plotSurface2d1.YAxis1.Color = Color.White;

                    plotSurface2d1.Refresh();
                }





            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }






        }

        public string UserId()
        {
            //try
            //{
            //    client = new FireSharp.FirebaseClient(config);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message + "Check Your connection!");
            //}

            FirebaseResponse response2 = client.Get("users/" + Login.currentusername + "/ID");

            string id = response2.ResultAs<string>();
            return id;

        }

        public string UserEmail()
        {
            //try
            //{
            //    client = new FireSharp.FirebaseClient(config);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message + "Check Your connection!");
            //}

            FirebaseResponse response2 = client.Get("users/" + Login.currentusername + "/Email");


            string Email = response2.ResultAs<string>();
            return Email;


        }

        public string getChores()
        {

            string chores = "";
            //try
            //{
            //    client = new FireSharp.FirebaseClient(config);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message + "Check Your connection!");
            //}


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


            FirebaseResponse response2 = client.Get("users/" + Login.currentusername + "/Birds/");

            if (!string.IsNullOrEmpty(response2.Body))
            {
                if (response2.Body.StartsWith("["))
                {
                    // handle the case where the response body is an array
                    var birdsList = JsonConvert.DeserializeObject<List<Bird>>(response2.Body);
                    if (birdsList != null)
                    {
                        childCount = birdsList.Count;
                    }
                }
                else
                {
                    // handle the case where the response body is an object
                    var birdsDict = response2.ResultAs<Dictionary<string, Bird>>();
                    if (birdsDict != null)
                    {
                        childCount = birdsDict.Count;
                    }
                }
            }
            else
            {
                // handle the case where there is no data in the Firebase path
            }












            return childCount;



        }

        public int amountofCages()
        {
            int childCount = 0;
            //try
            //{
            //    client = new FireSharp.FirebaseClient(config);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message + "Check Your connection!");
            //}


            try
            {
                FirebaseResponse response2 = client.Get("users/" + Login.currentusername + "/Cages");
                if (response2.Body != null)
                {
                    var birdsDict = response2.ResultAs<Dictionary<string, Cage>>();
                    if (birdsDict != null)
                    {
                        childCount = birdsDict.Count;
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }










            return childCount;



        }





        public int amountofUsers()
        {
            int childCount = 0;
            try
            {
                //client = new FireSharp.FirebaseClient(config);
                FirebaseResponse response2 = client.Get("users/");

                if (response2.Body != "null" && response2.ResultAs<Dictionary<string, object>>() != null)
                {
                    childCount = response2.ResultAs<Dictionary<string, object>>().Count;
                }
                else
                {
                    // handle the case where there is no data in the Firebase path
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Check Your connection!");
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

            FirebaseResponse response2 = client.Get("users/" + Login.currentusername + "/Birds");






            string json = response2.Body;

            if (!string.IsNullOrEmpty(json) && json != null)
            {
                Dictionary<string, Bird>? result2 = JsonConvert.DeserializeObject<Dictionary<string, Bird>>(json);

                // rest of the code

                if (result2 != null)
                {
                    foreach (var get in result2)
                    {

                        BirdList.Add(get.Key, Tuple.Create(

                            get.Value.IndexNumber!,
                            get.Value.Breed_of_Bird!,
                            get.Value.Subspecies!,
                            get.Value.HatchDate!,
                            get.Value.IndexCage!,
                            get.Value.IndexMother!,
                            get.Value.IndexFather!,
                                Tuple.Create(
                               get.Value.Gender!,
                               get.Value.ColorHead!,
                               get.Value.ColorBreast!,
                               get.Value.ColorBody!
                               )

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
            ImageList imageList = new ImageList
            {
                ImageSize = new Size(32, 32) // Set the size of the images in the list
            };


            int i = 0;
            // Example of how to access the items in BirdsList

            if (BirdList != null)
            {
                foreach (var birdTuple in BirdList)
                {
                    string indexNumber = birdTuple.Value.Item1;
                    string breedOfBird = birdTuple.Value.Item2;
                    string subspecies = birdTuple.Value.Item3;
                    string hatchDate = birdTuple.Value.Item4;
                    string indexCage = birdTuple.Value.Item5;
                    string indexMother = birdTuple.Value.Item6;
                    string indexFather = birdTuple.Value.Item7;
                    string gender = birdTuple.Value.Rest.Item1.Item1;
                    string headcolor = birdTuple.Value.Rest.Item1.Item2;
                    string breastcolor = birdTuple.Value.Rest.Item1.Item3;
                    string bodycolor = birdTuple.Value.Rest.Item1.Item4;
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
                    ListViewItem item = new ListViewItem("indexNumber: " + indexNumber + ", breedOfBird: " + breedOfBird + ", subspecies: " + subspecies + ", hatchDate: " + hatchDate + ", indexCage: " + indexCage + ", indexMother: " + indexMother + ", indexFather: " + indexFather + ", Gender: " + gender + ", Head color: " + headcolor + ", Breast Color: " + breastcolor + ", Body Color: " + bodycolor)
                    {
                        ImageIndex = i
                    };
                    i++;
                    // Add the ListViewItem to the ListView control
                    listViewBirds.Items.Add(item);
                }

            }






            listViewBirds.GridLines = true;
        }




        private void ShowCagesListinBird()
        {







            ContainerBoxIndexCage.Items.Clear();





            FirebaseResponse response2 = client.Get("users/" + Login.currentusername + "/Cages");
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
                ContainerBoxIndexCage.Items.Clear();
                foreach (var get in result2)
                {



                    if (get.Value != null && get.Key != null && get.Value.IndexNumber != null)
                    {
                        string indexNumber = get.Value.IndexNumber;
                        string keyValue = get.Key;

                        // Create a new ContainerBoxItem object with the first value
                        var item = new ContainerBoxItem { DisplayText = indexNumber, HiddenValue = keyValue };

                        // Add the ContainerBoxItem object to the container box
                        ContainerBoxIndexCage.Items.Add(item);
                    }





                }

            }









        }
        public class ContainerBoxItem
        {
            public string DisplayText { get; set; } = "";
            public string HiddenValue { get; set; } = "";

            public override string ToString()
            {
                return DisplayText;
            }
        }
        public string GetBirdsInfoAsString(Dictionary<string, Bird>? Birds)
        {
            var sb = new System.Text.StringBuilder();
            sb.AppendLine($"Number of birds in cage: {(Birds?.Count ?? 0)}");
            sb.AppendLine();

            if (Birds != null)
            {
                foreach (var bird in Birds.Values.OrderBy(b =>
                {
                    if (string.IsNullOrEmpty(b.IndexNumber))
                    {
                        return 0; // Or any other default value you want to use
                    }
                    else
                    {
                        return int.Parse(b.IndexNumber);
                    }
                }))
                {
                    sb.AppendLine($"{bird.GetBirdInfoAsString()}");
                    sb.AppendLine();
                }

            }

            return sb.ToString();
        }




        private void loadCagesList()
        {
            cage_listview.Clear();
            CageList.Clear();





            FirebaseResponse response2 = client.Get("users/" + Login.currentusername + "/Cages/");







            string json = response2.Body;
            if (!string.IsNullOrEmpty(json))
            {
                Dictionary<string, Cage>? result2 = JsonConvert.DeserializeObject<Dictionary<string, Cage>>(json);
                // rest of the code

                if (result2 != null)
                {
                    foreach (var get in result2)
                    {

                        FirebaseResponse response3 = client.Get("/users/" + Login.currentusername + "/Cages/" + get.Key! + "/BirdsOfCage");
                        string json2 = response3.Body;
                        Dictionary<string, Bird>? result3 = JsonConvert.DeserializeObject<Dictionary<string, Bird>>(json2);
                        int count = 0;
                        if (result3 != null)
                        {
                            count = result3.Count;
                        }


                        CageList.Add(Tuple.Create(
                            get.Value.IndexNumber!,
                            get.Value.Length!,
                            get.Value.Width!,
                            get.Value.Height!,
                            get.Value.Material!,
                            count,
                           result3,
                           get.Key



                        ));

                    }

                }

            }
            else
            {
                // handle null or empty JSON string
            }





            // Load the image from resources

            Image image = Resources.Woodcage;
            Image image2 = Resources.ironcage;
            Image image3 = Resources.plasticcage;

            // Add the image to the ImageList control
            ImageList imageList = new ImageList
            {
                ImageSize = new Size(32, 32) // Set the size of the images in the list
            };


            int i = 0;
            // Example of how to access the items in CagesList

            if (CageList != null)
            {
                foreach (var CageTuple in CageList)
                {
                    string indexNumber = CageTuple.Item1;
                    string Length = CageTuple.Item2;
                    string Width = CageTuple.Item3;
                    string Height = CageTuple.Item4;
                    string Material = CageTuple.Item5;
                    string Count = CageTuple.Item6.ToString();


                    // Do something with the cageTuple items...

                    if (Material == "Wood")
                    {

                        imageList.Images.Add(image);
                    }
                    else if (Material == "Iron")
                    {
                        imageList.Images.Add(image2);
                    }

                    else if (Material == "Plastic")
                    {
                        imageList.Images.Add(image3);
                    }
                    else
                    {
                        imageList.Images.Add(image);
                    }





                    cage_listview.SmallImageList = imageList;

                    // Create a new ListViewItem and set its ImageIndex property to the index of the image in the ImageList
                    ListViewItem item = new ListViewItem("indexNumber: " + indexNumber + ", length: " + Length + ", width: " + Width + ", height: " + Height + ", material: " + Material + ", Birds Amount: " + Count)
                    {
                        ImageIndex = i
                    };
                    i++;
                    // Add the ListViewItem to the ListView control
                    cage_listview.Items.Add(item);
                }

            }






            cage_listview.GridLines = true;
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

        private void ToolStripButton4_Click(object sender, EventArgs e)
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

            if (!BirdList.ElementAt(index).Equals(null))
            {

                textBoxIndexNumber.Text = BirdList.ElementAt(index).Value.Item1;
                comboBoxBreed.Text = BirdList.ElementAt(index).Value.Item2;
                comboBoxSubspecies.Text = BirdList.ElementAt(index).Value.Item3;
                dateTimePicker1.Text = BirdList.ElementAt(index).Value.Item4;
                ContainerBoxIndexCage.Text = BirdList.ElementAt(index).Value.Item5;
                textBoxIndexMotherofBird.Text = BirdList.ElementAt(index).Value.Item6;
                textBoxIndexFatherofBird.Text = BirdList.ElementAt(index).Value.Item7;

                comboBoxHeadColor.Text = BirdList.ElementAt(index).Value.Rest.Item1.Item2;
                comboBoxBreastColor.Text = BirdList.ElementAt(index).Value.Rest.Item1.Item3;
                comboBoxBodyColor.Text = BirdList.ElementAt(index).Value.Rest.Item1.Item4;

                if (BirdList.ElementAt(index).Value.Rest.Item1.Item1 == "Male")
                {
                    checkBoxMale.Checked = true;
                }
                else
                {
                    checkBoxMale.Checked = false;
                }

                if (BirdList.ElementAt(index).Value.Rest.Item1.Item1 == "Female")
                {
                    checkBoxFemale.Checked = true;
                }
                else
                {
                    checkBoxFemale.Checked = false;
                }


            }

            ShowBirdsListToMate();

        }




        private void ButtonAddBird_Click(object sender, EventArgs e)
        {
            panelHome.Visible = false;
            panelHome.Hide();

            panelAddCage.Visible = false;
            panelAddCage.Hide();
            panelSearch.Visible = false;

            panelSearchCages.Visible = false;
            panelSearchCages.Hide();
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
            ShowCagesListinBird();

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

            panelSearchCages.Visible = false;
            panelSearchCages.Hide();
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
            panelSearchCages.Visible = false;
            panelSearchCages.Hide();

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

            panelSearchCages.Visible = false;
            panelSearchCages.Hide();

            panelUser.Visible = false;
            panelUser.Hide();


            panelAddCage.Show();
            panelAddCage.Visible = true;
            panelAddCage.BringToFront();
            loadCagesList();
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

            panelSearchCages.Visible = false;
            panelSearchCages.Hide();


            panelUser.Show();
            panelUser.Visible = true;
            panelUser.BringToFront();
            panelUser.Enabled = true;

            panelHome.Show();
            panelHome.Visible = true;
            panelHome.BringToFront();
            panelHome.Enabled = true;
            labelTypeOfBirds.Text = amountofBirds().ToString();
            labelNumCages.Text = amountofCages().ToString();
            createGraph();
        }



        private void ToolStripButtonSearchCages_Click(object sender, EventArgs e)
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




            panelSearchCages.Show();
            panelSearchCages.Visible = true;
            panelSearchCages.BringToFront();
            panelSearchCages.Enabled = true;
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
            //IFirebaseClient client = new FirebaseClient(config);



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


        private void PictureBoxSubmitQuestion_Click(object sender, EventArgs e)
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

                // string indexBird = BirdList.[index].Item1;

                var selectedItem = ContainerBoxIndexCage.Items
                       .Cast<ContainerBoxItem>()
                        .FirstOrDefault(item => item.DisplayText == ContainerBoxIndexCage.Text);

                string hiddenValue = selectedItem?.HiddenValue ?? "";




                string indexBird = BirdList.ElementAt(index).Key;
                if (client != null)
                {
                    FirebaseResponse response2 = client.Delete("users/" + Login.currentusername + "/Birds/" + indexBird);
                    FirebaseResponse response3 = client.Delete("users/" + Login.currentusername + "/Cages/" + hiddenValue + "/BirdsOfCage/" + indexBird);

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


            bool isAlphanumeric = Regex.IsMatch(ContainerBoxIndexCage.Text, "^[a-zA-Z0-9]+$");

            bool containsOnlyLetters = Regex.IsMatch(ContainerBoxIndexCage.Text, @"^[a-zA-Z]+$");
            bool containsOnlyNumbers = Regex.IsMatch(ContainerBoxIndexCage.Text, @"^[0-9]+$");



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

            else if (containsOnlyLetters || !isAlphanumeric || containsOnlyNumbers)
            {
                MessageBox.Show("Index Cage should contain numbers and letters.");

            }
            else if (comboBoxHeadColor.Text == "Red DF" && checkBoxFemale.Checked == true)
            {

                MessageBox.Show("Red DF is only for Male Birds.");
            }

            else if (comboBoxHeadColor.Text == "Black DF" && checkBoxFemale.Checked == true)
            {
                MessageBox.Show("Black DF is only for Male Birds.");

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

            else if (ContainerBoxIndexCage.SelectedIndex == -1)
            {
                MessageBox.Show("Chooce Option of Cage.");
            }

            else if (comboBoxHeadColor.SelectedIndex == -1)
            {
                MessageBox.Show("Chooce Option of Head Color.");
            }

            else if (comboBoxBreastColor.SelectedIndex == -1)
            {
                MessageBox.Show("Chooce Option of Breast Color.");
            }

            else if (comboBoxBodyColor.SelectedIndex == -1)
            {
                MessageBox.Show("Chooce Option of Body Color.");
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



                FirebaseResponse birdsResponse = client.Get("users/" + Login.currentusername + "/Birds");
                Dictionary<string, Bird> birds = birdsResponse.ResultAs<Dictionary<string, Bird>>();

                // Check if bird with the same index number already exists in the list
                if (birds != null && birds.Any(x => x.Value.IndexNumber == textBoxIndexNumber.Text))
                {
                    MessageBox.Show("Bird with the same index number already exists");
                }

                else
                {
                    var Bird = new Bird
                    {
                        IndexNumber = textBoxIndexNumber.Text,
                        Breed_of_Bird = comboBoxBreed.Text,
                        Subspecies = comboBoxSubspecies.Text,
                        HatchDate = dateTimePicker1.Value.ToString("yyyy-MM-dd"),
                        IndexCage = ContainerBoxIndexCage.Text,
                        IndexMother = textBoxIndexMotherofBird.Text,
                        IndexFather = textBoxIndexFatherofBird.Text,
                        Gender = maleorfemale,
                        ColorBody = comboBoxBodyColor.Text,
                        ColorBreast = comboBoxBreastColor.Text,
                        ColorHead = comboBoxHeadColor.Text

                    };


                    try
                    {

                        string birdId = Guid.NewGuid().ToString();
                        Bird.IndexKey = birdId;

                        var selectedItem = ContainerBoxIndexCage.Items
                              .Cast<ContainerBoxItem>()
                               .FirstOrDefault(item => item.DisplayText == ContainerBoxIndexCage.Text);


                        if (selectedItem != null)
                        {
                            string hiddenValue = selectedItem.HiddenValue;

                            client.Set("users/" + Login.currentusername + "/Birds/" + birdId, Bird);
                            client.Set("users/" + Login.currentusername + "/Cages/" + hiddenValue + "/BirdsOfCage/" + birdId, Bird);
                            MessageBox.Show("You Add Succefully Bird Number Index: " + textBoxIndexNumber.Text);
                            loadBirdsList();
                        }
                        else
                        {
                            MessageBox.Show("Cage not found");
                        }







                    }
                    catch (FirebaseException)
                    {
                        // handle failure ...
                    }

                }





            }
        }

        private void pictureBoxSearchBird_Click(object sender, EventArgs e)
        {
            listViewSearch.Clear();
            BirdListSearch.Clear();



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
                string maleorfemale = "Male";
                if (checkBoxSearchMale.Checked == true && checkBoxSearchFemale.Checked == false)
                {
                    maleorfemale = "Male";
                }
                else if (checkBoxSearchFemale.Checked == true && checkBoxSearchMale.Checked == false)
                {
                    maleorfemale = "Female";
                }

                foreach (var get in result2)
                {
                    bool match = true;

                    if (checkBoxSearchByIndex.Checked && textBoxIndexSearch.Text != get.Value.IndexNumber)
                        match = false;

                    if (checkBoxSearchByGender.Checked && maleorfemale != get.Value.Gender)
                        match = false;

                    if (checkBoxSearchByHatchDate.Checked && dateTimePicker2.Value.ToString("yyyy-MM-dd") != get.Value.HatchDate)
                        match = false;

                    if (checkBoxSearchBySubSpecie.Checked && comboBoxSubSpeciesSearch.Text != get.Value.Subspecies)
                        match = false;

                    if (match)
                    {
                        BirdListSearch.Add(Tuple.Create(

                             get.Value.IndexNumber!,
                             get.Value.Breed_of_Bird!,
                             get.Value.Subspecies!,
                             get.Value.HatchDate!,
                             get.Value.IndexCage!,
                             get.Value.IndexMother!,
                             get.Value.IndexFather!,
                                 Tuple.Create(
                                get.Value.Gender!,
                                get.Value.ColorHead!,
                                get.Value.ColorBreast!,
                                get.Value.ColorBody!
                                )

                         ));
                        //BirdListSearch.Add(valuesToAdd);
                    }
                }



            }










            List<Tuple<string, string, string, string, string, string, string, Tuple<Tuple<string, string, string, string>>>> sortedList = BirdListSearch.OrderBy(b => int.Parse(b.Item1)).ToList();

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
            ImageList imageList = new ImageList
            {
                ImageSize = new Size(32, 32) // Set the size of the images in the list
            };


            int i = 0;
            // Example of how to access the items in BirdsList

            if (sortedList != null)
            {
                foreach (var birdTuple in sortedList)
                {
                    string indexNumber = birdTuple.Item1;
                    string breedOfBird = birdTuple.Item2;
                    string subspecies = birdTuple.Item3;
                    string hatchDate = birdTuple.Item4;
                    string indexCage = birdTuple.Item5;
                    string indexMother = birdTuple.Item6;
                    string indexFather = birdTuple.Item7;
                    string gender = birdTuple.Rest.Item1.Item1;
                    string headcolor = birdTuple.Rest.Item1.Item2;
                    string breastcolor = birdTuple.Rest.Item1.Item3;
                    string bodycolor = birdTuple.Rest.Item1.Item4;
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
                    ListViewItem item = new ListViewItem("indexNumber: " + indexNumber + ", breedOfBird: " + breedOfBird + ", subspecies: " + subspecies + ", hatchDate: " + hatchDate + ", indexCage: " + indexCage + ", indexMother: " + indexMother + ", indexFather: " + indexFather + ", Gender: " + gender + ", Head color: " + headcolor + ", Breast Color: " + breastcolor + ", Body Color: " + bodycolor)
                    {
                        ImageIndex = i
                    };
                    i++;
                    // Add the ListViewItem to the ListView control
                    listViewSearch.Items.Add(item);
                }

            }






            listViewSearch.GridLines = true;
        }

        private void pictureBoxAddCage_Click(object sender, EventArgs e)
        {

            bool isAlphanumeric = Regex.IsMatch(enter_index_cage.Text, "^[a-zA-Z0-9]+$");

            bool containsOnlyLetters = Regex.IsMatch(enter_index_cage.Text, @"^[a-zA-Z]+$");
            bool containsOnlyNumbers = Regex.IsMatch(enter_index_cage.Text, @"^[0-9]+$");

            bool containsOnlyNumbers2 = Regex.IsMatch(enter_length.Text, @"^[0-9]+$");

            bool containsOnlyNumbers3 = Regex.IsMatch(enter_width.Text, @"^[0-9]+$");

            bool containsOnlyNumbers4 = Regex.IsMatch(enter_height.Text, @"^[0-9]+$");
            if (containsOnlyLetters || !isAlphanumeric || containsOnlyNumbers)
            {
                MessageBox.Show("Index Cage should contain numbers and letters.");

            }

            else if (!containsOnlyNumbers2)
            {
                MessageBox.Show("Length can only be numbers.");

            }
            else if (!containsOnlyNumbers3)
            {
                MessageBox.Show("Width can only be numbers.");
            }
            else if (!containsOnlyNumbers4)
            {
                MessageBox.Show("Height can only be numbers.");
            }

            else if (!(material_cage_list.Text == "Iron" || material_cage_list.Text == "Wood" || material_cage_list.Text == "Plastic"))
            {
                MessageBox.Show("U can only choose Iron,Wood,Plastic from the list");
            }

            else
            {




                FirebaseResponse birdsResponse = client.Get("users/" + Login.currentusername + "/Cages");
                Dictionary<string, Cage> Cages = birdsResponse.ResultAs<Dictionary<string, Cage>>();

                // Check if bird with the same index number already exists in the list
                if (Cages != null && Cages.Any(x => x.Value.IndexNumber == enter_index_cage.Text))
                {
                    MessageBox.Show("Cage with the same index number already exists");
                }
                else
                {

                    //IFirebaseClient client = new FirebaseClient(config);
                    var Cage = new Cage
                    {
                        IndexNumber = enter_index_cage.Text,
                        Length = enter_length.Text,
                        Width = enter_width.Text,
                        Height = enter_height.Text,
                        Material = material_cage_list.Text,
                        BirdsOfCage = new Dictionary<string, Bird>(),
                    };




                    try
                    {
                        string cageId = Guid.NewGuid().ToString();
                        Cage.IndexKey = cageId;
                        client.Set("users/" + Login.currentusername + "/Cages/" + cageId, Cage);
                        MessageBox.Show("You Add Succefully Cage Number Index: " + enter_index_cage.Text);
                        loadCagesList();

                    }
                    catch (FirebaseException)
                    {
                        // handle failure ...
                    }

                }

            }


        }

        private void cage_listview_MouseClick(object sender, MouseEventArgs e)
        {

            int index = cage_listview.FocusedItem.Index;

            string BirdInfo = GetBirdsInfoAsString(CageList[index].Item7);


            // DialogResult result = MessageBox.Show(BirdInfo, title);

            // Show a custom MessageBox
            ShowBirds messageBox = new ShowBirds(BirdInfo);

            // Show the form as a dialog and check the DialogResult
            if (messageBox.ShowDialog() == DialogResult.OK)
            {
                // User clicked the OK button
            }
            else
            {
                // User clicked the Cancel button or closed the form
            }

        }

        private void checkBoxSearchMale_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSearchMale.Checked)
            {
                checkBoxSearchFemale.Checked = false;
            }
        }

        private void checkBoxSearchFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSearchFemale.Checked)
            {
                checkBoxSearchMale.Checked = false;
            }
        }

        private void checkBoxMale_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBoxMale.Checked)
            {
                checkBoxFemale.Checked = false;
            }
        }

        private void checkBoxFemale_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBoxFemale.Checked)
            {
                checkBoxMale.Checked = false;
            }
        }

        private void PictureBoxSearchCages_Click(object sender, EventArgs e)
        {
            listViewSearchCages.Clear();
            CageListSearch.Clear();



            FirebaseResponse response2 = client.Get("users/" + Login.currentusername + "/Cages");
            Dictionary<string, Cage> result2;
            try
            {
                result2 = response2.ResultAs<Dictionary<string, Cage>>();
            }
            catch (Newtonsoft.Json.JsonSerializationException ex)
            {
                MessageBox.Show("Error deserializing JSON string: " + ex.Message);
                result2 = new Dictionary<string, Cage>();
            }



            if (result2 != null)
            {






                foreach (var get in result2)
                {
                    FirebaseResponse response3 = client.Get("/users/" + Login.currentusername + "/Cages/" + get.Key! + "/BirdsOfCage");
                    string json2 = response3.Body;
                    Dictionary<string, Bird>? result3 = JsonConvert.DeserializeObject<Dictionary<string, Bird>>(json2);
                    int count = 0;
                    if (result3 != null)
                    {
                        count = result3.Count;
                    }


                    bool match = true;

                    if (checkBoxSearchIndexCage.Checked && textBoxSearchCageIndex.Text != get.Value.IndexNumber)
                        match = false;

                    if (checkBoxSearchCageMaterial.Checked && comboBoxSearchCageMaterial.Text != get.Value.Material)
                        match = false;



                    if (match)
                    {
                        var valuesToAdd = Tuple.Create(
                          get.Value.IndexNumber!,
                          get.Value.Length!,
                          get.Value.Width!,
                          get.Value.Height!,
                          get.Value.Material!,
                           count,
                           GetBirdsInfoAsString(result3),
                            get.Key


                        );

                        CageListSearch.Add(valuesToAdd);
                    }
                }



            }










            sortedList = CageListSearch.OrderBy(b =>
            {
                string indexStr = new string(b.Item1.Where(char.IsDigit).ToArray()); // extract only digits from the index string
                return int.TryParse(indexStr, out int index) ? index : int.MaxValue; // try to parse the numeric value, return int.MaxValue if parsing fails
            }).ToList();


            // Load the image from resources

            Image image = Resources.Woodcage;
            Image image2 = Resources.ironcage;
            Image image3 = Resources.plasticcage;

            // Add the image to the ImageList control
            ImageList imageList = new ImageList
            {
                ImageSize = new Size(32, 32) // Set the size of the images in the list
            };


            int i = 0;
            // Example of how to access the items in CagesList

            if (sortedList != null)
            {
                foreach (var CageTuple in sortedList)
                {
                    string indexNumber = CageTuple.Item1;
                    string Length = CageTuple.Item2;
                    string Width = CageTuple.Item3;
                    string Height = CageTuple.Item4;
                    string Material = CageTuple.Item5;
                    string Count = CageTuple.Item6.ToString();


                    // Do something with the cageTuple items...

                    if (Material == "Wood")
                    {

                        imageList.Images.Add(image);
                    }
                    else if (Material == "Iron")
                    {
                        imageList.Images.Add(image2);
                    }

                    else if (Material == "Plastic")
                    {
                        imageList.Images.Add(image3);
                    }
                    else
                    {
                        imageList.Images.Add(image);
                    }





                    listViewSearchCages.SmallImageList = imageList;

                    // Create a new ListViewItem and set its ImageIndex property to the index of the image in the ImageList
                    ListViewItem item = new ListViewItem("indexNumber: " + indexNumber + ", length: " + Length + ", width: " + Width + ", height: " + Height + ", material: " + Material + ", Birds Amount: " + Count)
                    {
                        ImageIndex = i
                    };
                    i++;
                    // Add the ListViewItem to the ListView control
                    listViewSearchCages.Items.Add(item);
                }

            }




            listViewSearch.GridLines = true;
        }

        private void listViewSearchCages_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listViewSearchCages.FocusedItem.Index;

            if (sortedList[index] != null)
            {
                string BirdInfo = sortedList[index].Item7;

                // DialogResult result = MessageBox.Show(BirdInfo, title);

                // Show a custom MessageBox
                ShowBirds messageBox = new ShowBirds(BirdInfo);

                // Show the form as a dialog and check the DialogResult
                if (messageBox.ShowDialog() == DialogResult.OK)
                {
                    // User clicked the OK button
                }

            }
            else
            {
                // handle the case where sortedList[index] is null
            }


        }

        private void pictureBoxEditBird_Click(object sender, EventArgs e)
        {
            bool isNumeric = Regex.IsMatch(textBoxIndexNumber.Text, @"^\d+$");
            bool isNumeric2 = Regex.IsMatch(textBoxIndexFatherofBird.Text, @"^\d+$");
            bool isNumeric3 = Regex.IsMatch(textBoxIndexMotherofBird.Text, @"^\d+$");


            bool isAlphanumeric = Regex.IsMatch(ContainerBoxIndexCage.Text, "^[a-zA-Z0-9]+$");

            bool containsOnlyLetters = Regex.IsMatch(ContainerBoxIndexCage.Text, @"^[a-zA-Z]+$");
            bool containsOnlyNumbers = Regex.IsMatch(ContainerBoxIndexCage.Text, @"^[0-9]+$");



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

            else if (containsOnlyLetters || !isAlphanumeric || containsOnlyNumbers)
            {
                MessageBox.Show("Index Cage should contain numbers and letters.");

            }
            else if (comboBoxHeadColor.Text == "Red DF" && checkBoxFemale.Checked == true)
            {

                MessageBox.Show("Red DF is only for Male Birds.");
            }

            else if (comboBoxHeadColor.Text == "Black DF" && checkBoxFemale.Checked == true)
            {
                MessageBox.Show("Black DF is only for Male Birds.");

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

            else if (ContainerBoxIndexCage.SelectedIndex == -1)
            {
                MessageBox.Show("Chooce Option of Cage.");
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


                int index2 = listViewBirds.FocusedItem.Index;
                string birdId2 = BirdList.ElementAt(index2).Key;
                client.Delete("users/" + Login.currentusername + "/Birds/" + birdId2);

                FirebaseResponse birdsResponse = client.Get("users/" + Login.currentusername + "/Birds");
                Dictionary<string, Bird> birds = birdsResponse.ResultAs<Dictionary<string, Bird>>();

                // Check if bird with the same index number already exists in the list
                if (birds != null && birds.Any(x => x.Value.IndexNumber == textBoxIndexNumber.Text))
                {
                    MessageBox.Show("Bird with the same index number already exists");
                }

                else
                {

                    var Bird = new Bird
                    {
                        IndexNumber = textBoxIndexNumber.Text,
                        Breed_of_Bird = comboBoxBreed.Text,
                        Subspecies = comboBoxSubspecies.Text,
                        HatchDate = dateTimePicker1.Value.ToString("yyyy-MM-dd"),
                        IndexCage = ContainerBoxIndexCage.Text,
                        IndexMother = textBoxIndexMotherofBird.Text,
                        IndexFather = textBoxIndexFatherofBird.Text,
                        Gender = maleorfemale,
                        ColorBody = comboBoxBodyColor.Text,
                        ColorBreast = comboBoxBreastColor.Text,
                        ColorHead = comboBoxHeadColor.Text

                    };


                    try
                    {

                        if (listViewBirds.FocusedItem != null && listViewBirds.FocusedItem.Focused)
                        {
                            // The focused item is currently focused
                            int index = listViewBirds.FocusedItem.Index;

                            string birdId = BirdList.ElementAt(index).Key;


                            Bird.IndexKey = birdId;

                            var selectedItem = ContainerBoxIndexCage.Items
                                  .Cast<ContainerBoxItem>()
                                   .FirstOrDefault(item => item.DisplayText == ContainerBoxIndexCage.Text);


                            if (selectedItem != null)
                            {
                                string hiddenValue = selectedItem.HiddenValue;

                                client.Set("users/" + Login.currentusername + "/Birds/" + birdId, Bird);
                                client.Set("users/" + Login.currentusername + "/Cages/" + hiddenValue + "/BirdsOfCage/" + birdId, Bird);
                                MessageBox.Show("You Edit Succefully Bird Number Index: " + textBoxIndexNumber.Text);
                                loadBirdsList();
                            }
                            else
                            {
                                MessageBox.Show("Cage not found");
                            }


                        }
                        else
                        {
                            MessageBox.Show("Chooce Bird to Edit.");
                        }









                    }
                    catch (FirebaseException)
                    {
                        // handle failure ...
                    }

                }


            }
        }

        private void cage_listview_SelectedIndexChanged(object sender, EventArgs e)
        {


            int index = cage_listview.FocusedItem.Index;

            if (!CageList.ElementAt(index).Equals(null))
            {

                enter_index_cage.Text = CageList.ElementAt(index).Item1;
                enter_length.Text = CageList.ElementAt(index).Item2;
                enter_width.Text = CageList.ElementAt(index).Item3;
                enter_height.Text = CageList.ElementAt(index).Item4;
                material_cage_list.Text = CageList.ElementAt(index).Item5;



            }

        }

        private void pictureBoxEditCage_Click(object sender, EventArgs e)
        {
            bool isAlphanumeric = Regex.IsMatch(enter_index_cage.Text, "^[a-zA-Z0-9]+$");

            bool containsOnlyLetters = Regex.IsMatch(enter_index_cage.Text, @"^[a-zA-Z]+$");
            bool containsOnlyNumbers = Regex.IsMatch(enter_index_cage.Text, @"^[0-9]+$");

            bool containsOnlyNumbers2 = Regex.IsMatch(enter_length.Text, @"^[0-9]+$");

            bool containsOnlyNumbers3 = Regex.IsMatch(enter_width.Text, @"^[0-9]+$");

            bool containsOnlyNumbers4 = Regex.IsMatch(enter_height.Text, @"^[0-9]+$");
            if (containsOnlyLetters || !isAlphanumeric || containsOnlyNumbers)
            {
                MessageBox.Show("Index Cage should contain numbers and letters.");

            }

            else if (!containsOnlyNumbers2)
            {
                MessageBox.Show("Length can only be numbers.");

            }
            else if (!containsOnlyNumbers3)
            {
                MessageBox.Show("Width can only be numbers.");
            }
            else if (!containsOnlyNumbers4)
            {
                MessageBox.Show("Height can only be numbers.");
            }

            else if (!(material_cage_list.Text == "Iron" || material_cage_list.Text == "Wood" || material_cage_list.Text == "Plastic"))
            {
                MessageBox.Show("U can only choose Iron,Wood,Plastic from the list");
            }

            else
            {

                int index2 = cage_listview.FocusedItem.Index;
                string cageid2 = CageList.ElementAt(index2).Rest.Item1;

                client.Delete("users/" + Login.currentusername + "/Cages/" + cageid2);
                FirebaseResponse birdsResponse = client.Get("users/" + Login.currentusername + "/Cages");
                Dictionary<string, Cage> Cages = birdsResponse.ResultAs<Dictionary<string, Cage>>();

                // Check if bird with the same index number already exists in the list
                if (Cages != null && Cages.Any(x => x.Value.IndexNumber == enter_index_cage.Text))
                {
                    MessageBox.Show("Cage with the same index number already exists");
                }

                else
                {

                    var Cage = new Cage
                    {
                        IndexNumber = enter_index_cage.Text,
                        Length = enter_length.Text,
                        Width = enter_width.Text,
                        Height = enter_height.Text,
                        Material = material_cage_list.Text,
                    };





                    if (cage_listview.FocusedItem != null && cage_listview.FocusedItem.Focused)
                    {
                        // The focused item is currently focused
                        int index = cage_listview.FocusedItem.Index;

                        string cageid = CageList.ElementAt(index).Rest.Item1;


                        Cage.IndexKey = cageid;
                        Cage.BirdsOfCage = CageList.ElementAt(index).Item7;






                        client.Set("users/" + Login.currentusername + "/Cages/" + cageid, Cage);
                        MessageBox.Show("You Edit Succefully Cage Number Index: " + enter_index_cage.Text);
                        loadCagesList();



                    }
                    else
                    {
                        MessageBox.Show("Chooce Cage to Edit.");
                    }

                }





            }
        }

        private void ShowBirdsListToMate()
        {

            comboBoxChooceBirdToMate.Items.Clear();



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
                string maleorfemale = "Male";
                if (checkBoxMale.Checked == true && checkBoxFemale.Checked == false)
                {
                    maleorfemale = "Male";
                }
                else if (checkBoxFemale.Checked == true && checkBoxMale.Checked == false)
                {
                    maleorfemale = "Female";
                }

                foreach (var get in result2)
                {
                    bool match = true;

                    if (textBoxIndexNumber.Text == get.Value.IndexNumber)
                        match = false;

                    if (maleorfemale == get.Value.Gender)
                        match = false;


                    if (comboBoxSubspecies.Text != get.Value.Subspecies)
                        match = false;

                    if (ContainerBoxIndexCage.Text != get.Value.IndexCage)
                        match = false;

                    if (match)
                    {
                        var valuesToAdd = Tuple.Create(
                            get.Value.IndexNumber!,
                            get.Value.Breed_of_Bird!,
                            get.Value.Subspecies!,
                            get.Value.HatchDate!,
                            get.Value.IndexCage!,
                            get.Value.IndexMother!,
                            get.Value.IndexFather!,
                            Tuple.Create(get.Value.Gender!,
                            get.Value.ColorHead!,
                            get.Value.ColorBreast,
                            get.Value.ColorBody)


                        );

                        comboBoxChooceBirdToMate.Items.Add(valuesToAdd);
                    }
                }
            }








        }

        private void pictureBoxAddNewOffspring_Click(object sender, EventArgs e)
        {

            string maleorfemale;
            string indexOfFirstParent;
            string today = DateTime.Now.ToString("yyyy-MM-dd");
            string indexOfSecondParent;
            // Create a random number generator
            Random random = new Random();

            // Generate a random number between 0 and 1
            double randomNumber = random.NextDouble();

            // Set maleorfemale based on the random number
            if (randomNumber < 0.5)
            {
                maleorfemale = "Male";
            }
            else
            {
                maleorfemale = "Female";
            }




            string HeadColorParentMother;
            string HeadColorParentFather;

            string BreastColorParentMother;
            string BreastColorParentFather;

            string BodyColorParentMother;
            string BodyColorParentFather;

            string searchIndexNumber = textBoxIndexNumberOffSpring.Text;
            bool exists = false;

            foreach (KeyValuePair<string, Tuple<string, string, string, string, string, string, string, Tuple<Tuple<string, string, string, string>>>> entry in BirdList)
            {
                if (entry.Value.Item1 == searchIndexNumber)
                {
                    exists = true;
                    break;
                }
            }

            // Get the selected item index
            int selectedIndex = comboBoxChooceBirdToMate.FindStringExact(comboBoxChooceBirdToMate.Text);
            bool isNumeric = Regex.IsMatch(textBoxIndexNumberOffSpring.Text, @"^\d+$");
            if (!isNumeric)
            {
                MessageBox.Show("Index Number of Bird can only contain numbers.");
            }
            else if (exists)
            {
                MessageBox.Show("Index Number of Bird already exists.");
            }
            else
            {

                if (selectedIndex != -1)
                {
                    // Get the selected item tuple
                    var selectedItem = (Tuple<string, string, string, string, string, string, string, Tuple<Tuple<string, string, string, string>>>)comboBoxChooceBirdToMate.Items[selectedIndex];



                    if (checkBoxMale.Checked == true && checkBoxFemale.Checked == false)
                    {
                        // Get the index of the mother
                        HeadColorParentMother = selectedItem.Rest.Item1.Item2;
                        BreastColorParentMother = selectedItem.Rest.Item1.Item3;
                        BodyColorParentMother = selectedItem.Rest.Item1.Item4;

                        HeadColorParentFather = comboBoxHeadColor.Text;
                        BreastColorParentFather = comboBoxBreastColor.Text;
                        BodyColorParentFather = comboBoxBodyColor.Text;

                        indexOfSecondParent = selectedItem.Item1;
                        indexOfFirstParent = textBoxIndexNumber.Text;
                        var Bird = new Bird
                        {
                            IndexNumber = textBoxIndexNumberOffSpring.Text,
                            Breed_of_Bird = comboBoxBreed.Text,
                            Subspecies = comboBoxSubspecies.Text,
                            HatchDate = today,
                            IndexCage = ContainerBoxIndexCage.Text,
                            IndexMother = indexOfSecondParent,
                            IndexFather = indexOfFirstParent,
                            Gender = maleorfemale,
                            ColorHead = GetOffspringColorHead(HeadColorParentFather, HeadColorParentMother, maleorfemale),
                            ColorBreast = GetOffspringColorBreast(BreastColorParentFather, BreastColorParentMother, maleorfemale),
                            ColorBody = GetOffspringColorBody(BodyColorParentFather, HeadColorParentMother, BodyColorParentMother)


                        };
                        addBird(Bird);
                        loadBirdsList();
                    }
                    else if (checkBoxFemale.Checked == true && checkBoxMale.Checked == false)
                    {

                        HeadColorParentFather = selectedItem.Rest.Item1.Item2;
                        BreastColorParentFather = selectedItem.Rest.Item1.Item3;
                        BodyColorParentFather = selectedItem.Rest.Item1.Item4;

                        HeadColorParentMother = comboBoxHeadColor.Text;
                        BreastColorParentMother = comboBoxBreastColor.Text;
                        BodyColorParentMother = comboBoxBodyColor.Text;

                        indexOfFirstParent = textBoxIndexNumber.Text;
                        // Get the index of the father
                        indexOfSecondParent = selectedItem.Item1;
                        var Bird = new Bird
                        {
                            IndexNumber = textBoxIndexNumberOffSpring.Text,
                            Breed_of_Bird = comboBoxBreed.Text,
                            Subspecies = comboBoxSubspecies.Text,
                            HatchDate = today,
                            IndexCage = ContainerBoxIndexCage.Text,
                            IndexMother = indexOfFirstParent,
                            IndexFather = indexOfSecondParent,
                            Gender = maleorfemale,
                            ColorHead = GetOffspringColorHead(HeadColorParentFather, HeadColorParentMother, maleorfemale),
                            ColorBreast = GetOffspringColorBreast(BreastColorParentFather, BreastColorParentMother, maleorfemale),
                            ColorBody = GetOffspringColorBody(BodyColorParentFather, HeadColorParentMother, BodyColorParentMother)

                        };
                        addBird(Bird);
                        loadBirdsList();
                    }
                }


            }











        }

        public static string GetOffspringColorBody(string fatherColor, string motherColor, string offspringGender)
        {
            string offspringColor = "";
            Random random = new Random();

            if (fatherColor == "Green" && motherColor == "Green")
            {
                offspringColor = "Green";
            }
            else if (fatherColor == "SFYB" && motherColor == "Green")
            {
                if (offspringGender == "Male")
                {
                    if (random.Next(2) == 0)
                    {
                        offspringColor = "Green";
                    }
                    else
                    {
                        offspringColor = "SFYB";
                    }
                }
                else
                {
                    if (random.Next(2) == 0)
                    {
                        offspringColor = "Green";
                    }
                    else
                    {
                        offspringColor = "Yellow";
                    }
                }
            }
            else if (fatherColor == "DFYB" && motherColor == "Green")
            {
                if (offspringGender == "Male")
                {
                    offspringColor = "SFYB";
                }
                else
                {
                    offspringColor = "Yellow";
                }
            }
            else if (fatherColor == "Green" && motherColor == "Yellow")
            {
                if (offspringGender == "Male")
                {
                    offspringColor = "SFYB";
                }
                else
                {
                    offspringColor = "Green";
                }
            }
            else if (fatherColor == "SFYB" && motherColor == "Yellow")
            {
                if (offspringGender == "Male")
                {
                    if (random.Next(2) == 0)
                    {
                        offspringColor = "SFYB";
                    }
                    else
                    {
                        offspringColor = "DFYB";
                    }
                }
                else
                {
                    if (random.Next(2) == 0)
                    {
                        offspringColor = "Green";
                    }
                    else
                    {
                        offspringColor = "Yellow";
                    }
                }
            }
            else if (fatherColor == "DFYB" && motherColor == "Yellow")
            {
                if (offspringGender == "Male")
                {
                    offspringColor = "DFYB";

                }
                else
                {
                    offspringColor = "Yellow";

                }
            }
            else if (fatherColor == "DF-blue" && motherColor == "DF-blue")
            {
                offspringColor = "DF-blue";
            }
            else if ((fatherColor == "DF-blue" && (motherColor == "SF-blue" || motherColor == "/blue")) || ((fatherColor == "SF-blue" || fatherColor == "/blue") && motherColor == "DF-blue"))
            {
                if (random.Next(2) == 0)
                {
                    offspringColor = "DF-blue";
                }
                else
                {
                    offspringColor = "SF-blue";
                }
            }
            else if ((fatherColor == "SF-blue" || fatherColor == "/blue") && (motherColor == "SF-blue" || motherColor == "/blue"))
            {
                if (random.Next(4) == 0)
                {
                    offspringColor = "DF-blue";
                }
                else if (random.Next(4) == 1)
                {
                    offspringColor = "non-blue";
                }
                else
                {
                    offspringColor = "SF-blue";
                }
            }
            else if ((fatherColor == "DF-blue" || fatherColor == "/blue") && motherColor == "non-blue" || (motherColor == "DF-blue" || motherColor == "/blue") && fatherColor == "non-blue")
            {
                if (random.Next(2) == 0)
                {
                    offspringColor = "SF-blue";
                }
                else
                {
                    offspringColor = "non-blue";
                }
            }
            else if (fatherColor == "DF-blue" && motherColor == "non-blue" || motherColor == "DF-blue" && fatherColor == "non-blue")
            {
                if (random.Next(2) == 0)
                {
                    offspringColor = "SF-blue";
                }
                else
                {
                    offspringColor = "/blue";
                }
            }
            else
            {
                return "Invalid Option";
            }
            return offspringColor;

        }

        public static string GetOffspringColorBreast(string fatherColor, string motherColor, string offspringGender)
        {

            //options : 
            // DFPB(Purple breasted)
            //DFLB(Lilac breasted)
            //DFWB (White breasted)
            //SFPB SFLB(Purple breasted "split" for lilac breast)
            // SFPB SFWB(Purple breasted "split" for white breast)
            // SFLB SFWB(Lilac breasted "split" for white breast)
            Random random = new Random();
            double chance = random.NextDouble();

            if (fatherColor == "Purple" && motherColor == "Purple")
            {
                return "Purple";
            }
            else if (fatherColor == "Lilac" && motherColor == "Lilac")
            {
                return "Lilac";
            }
            else if (fatherColor == "White" && motherColor == "White")
            {
                return "White";
            }
            else if ((fatherColor == "Purple" && motherColor == "Lilac") || (fatherColor == "Lilac" && motherColor == "Purple"))
            {
                return "Purple breasted \"split\" for lilac breast";
            }
            else if ((fatherColor == "Purple" && motherColor == "White") || (fatherColor == "White" && motherColor == "Purple"))
            {
                if (chance < 0.5)
                {
                    return "Purple breasted \"split\" for white breast";
                }
                else
                {
                    return "White";
                }
            }
            //options : 
            // DFPB(Purple breasted)
            //DFLB(Lilac breasted)
            //DFWB (White breasted)
            //SFPB SFLB(Purple breasted "split" for lilac breast)
            // SFPB SFWB(Purple breasted "split" for white breast)
            // SFLB SFWB(Lilac breasted "split" for white breast)
            else if ((fatherColor == "Purple" || fatherColor == "White" && motherColor == "White") || (fatherColor == "White" && motherColor == "Purple" || motherColor == "White"))
            {
                if (chance < 0.5)
                {
                    return "Purple breasted \"split\" for white breast";
                }
                else
                {
                    return "White";
                }
            }
            else if ((fatherColor == "Lilac" && motherColor == "White") || (fatherColor == "White" && motherColor == "Lilac"))
            {
                return "Lilac breasted \"split\" for white breast";
            }
            else if ((fatherColor == "Lilac/White" || fatherColor == "Lilac/White" && motherColor == "White") || (fatherColor == "White" && motherColor == "White" || motherColor == "Lilac"))
            {
                if (chance < 0.5)
                {
                    return "Lilac breasted \"split\" for white breast";
                }
                else
                {
                    return "White";
                }
            }
            //options : 
            // DFPB(Purple breasted)
            //DFLB(Lilac breasted)
            //DFWB (White breasted)
            //SFPB SFLB(Purple breasted "split" for lilac breast)
            // SFPB SFWB(Purple breasted "split" for white breast)
            // SFLB SFWB(Lilac breasted "split" for white breast)
            else if (fatherColor == "Lilac" || fatherColor == "White" && motherColor == "Lilac" || motherColor == "White")
            {
                if (chance < 0.25)
                {
                    return "Lilac";
                }
                else if (chance >= 0.25 && chance < 0.75)
                {
                    return "Lilac breasted \"split\" for white breast";
                }
                else
                {
                    return "White";
                }
            }
            else if ((fatherColor == "Purple" && (motherColor == "Purple" || motherColor == "Lilac")) || ((fatherColor == "Purple" || fatherColor == "Lilac") && motherColor == "Purple"))
            {
                if (chance < 0.5)
                {
                    return "Purple";
                }
                else
                {
                    return "Purple breasted \"split\" for lilac breast";
                }
            }

            else if ((fatherColor == "Lilac" && (motherColor == "Purple" || motherColor == "Lilac")) || ((fatherColor == "Purple" || fatherColor == "Lilac") && motherColor == "Lilac"))
            {
                if (chance < 0.5)
                {
                    return "Lilac";
                }
                else
                {
                    return "Purple breasted \"split\" for lilac breast";
                }
            }

            else if ((fatherColor == "Purple" && (motherColor == "Purple" || motherColor == "White")) || ((fatherColor == "Purple" || fatherColor == "White") && motherColor == "Purple"))
            {
                if (chance < 0.5)
                {
                    return "Purple";
                }
                else
                {
                    return "Purple breasted \"split\" for white breast";
                }
            }
            else if ((fatherColor == "Purple" || fatherColor == "White") && (motherColor == "Purple" || motherColor == "White"))
            {
                if (chance < 0.25)
                {
                    return "Purple";
                }
                else if (chance >= 0.25 && chance < 0.75)
                {
                    return "Purple breasted \"split\" for white breast";
                }
                else
                {
                    return "White";
                }
            }
            else if ((fatherColor == "Purple" || fatherColor == "Lilac") && (motherColor == "Purple" || motherColor == "White") || (motherColor == "Purple" || motherColor == "Lilac") && (fatherColor == "Purple" || fatherColor == "White"))
            {
                if (chance < 0.25)
                {
                    return "Purple";
                }
                else if (chance >= 0.25 && chance < 0.50)
                {
                    return "Purple breasted \"split\" for lilac breasted";
                }
                else if (chance >= 0.50 && chance < 0.75)
                {
                    return "Purple breasted \"split\" for white breasted";
                }
                else
                {
                    return "Lilac breasted \"split\" for white breasted";
                }
            }

            //options : 
            // DFPB(Purple breasted)
            //DFLB(Lilac breasted)
            //DFWB (White breasted)
            //SFPB SFLB(Purple breasted "split" for lilac breast)
            // SFPB SFWB(Purple breasted "split" for white breast)
            // SFLB SFWB(Lilac breasted "split" for white breast)

            //PB /LB cock × PB /LB hen /////////////////////////////////////////////////////////////////////////////////////////////
            else if ((fatherColor == "Purple" || fatherColor == "Lilac") && (motherColor == "Purple" || motherColor == "Lilac"))
            {

                if (chance < 0.25)
                {
                    return "Purple";
                }
                else if (chance >= 0.25 && chance < 0.75)
                {
                    return "Purple breasted \"split\" for lilac breast";
                }
                else
                {
                    return "Lilac";
                }
            }
            //PB /WB cock × LB /WB hen (or vise versa)
            else if ((fatherColor == "Purple" || fatherColor == "White") && (motherColor == "Lilac" || motherColor == "White") || (motherColor == "Purple" || motherColor == "White") && (fatherColor == "Lilac" || fatherColor == "White"))

            {
                if (chance < 0.25)
                {
                    return "Purple breasted \"split\" for lilac breasted";
                }
                else if (chance >= 0.25 && chance < 0.50)
                {
                    return "Lilac breasted \"split\" for white breasted";
                }
                else if (chance >= 0.50 && chance < 0.75)
                {
                    return "Purple breasted \"split\" for white breasted";
                }
                else
                {
                    return "White";
                }
            }
            //LB cock × PB /WB hen (or vise versa)
            else if ((fatherColor == "Lilac" && (motherColor == "Purple" || motherColor == "White") || (motherColor == "Lilac") && (fatherColor == "Purple" || fatherColor == "White")))

            {
                if (chance < 0.5)
                {
                    return "Purple breasted \"split\" for lilac breasted";
                }
                else
                {
                    return "Lilac breasted \"split\" for white breasted";
                }
            }

            //PB cock × LB /WB hen (or vise versa)
            else if ((fatherColor == "Purple" && (motherColor == "Lilac" || motherColor == "White") || (motherColor == "Purple") && (fatherColor == "Lilac" || fatherColor == "White")))
            {
                if (chance < 0.5)
                {
                    return "Purple breasted \"split\" for lilac breasted";
                }
                else
                {
                    return "Purple breasted \"split\" for white breast";
                }
            }

            //PB /LB cock × WB hen (or vise versa)
            else if ((fatherColor == "White" && (motherColor == "Lilac" || motherColor == "Purple") || (motherColor == "White") && (fatherColor == "Purple" || fatherColor == "Lilac")))

            {
                if (chance < 0.5)
                {
                    return "Purple breasted \"split\" for white breast";
                }
                else
                {
                    return "Lilac breasted \"split\" for white breasted";
                }
            }
            //PB /LB cock × LB /WB hen (or vise versa)
            else if ((fatherColor == "Purple" || fatherColor == "Lilac") && (motherColor == "Lilac" || motherColor == "White") || (motherColor == "Purple" || motherColor == "Lilac") && (fatherColor == "Lilac" || fatherColor == "White"))
            {
                if (chance < 0.25)
                {
                    return "Purple breasted \"split\" for lilac breasted";
                }
                else if (chance >= 0.25 && chance < 0.50)
                {
                    return "Purple breasted \"split\" for white breasted";
                }
                else if (chance >= 0.50 && chance < 0.75)
                {
                    return "Lilac";
                }
                else
                {
                    return "Lilac breasted \"split\" for white breasted";
                }
            }

            //LB cock × LB /WB hen (or vise versa)
            else if ((fatherColor == "Lilac" && (motherColor == "Lilac" || motherColor == "White") || (motherColor == "Lilac") && (fatherColor == "Lilac" || fatherColor == "White")))
            {

                if (chance < 0.5)
                {
                    return "Lilac";
                }
                else
                {
                    return "lilac breasted \"split\" for white breasted";
                }
            }


            else
            {
                return "Invalid Option";
            }
        }


        public static string GetOffspringColorHead(string fatherColor, string motherColor, string offspringGender)
        {

            if (fatherColor == "Red DF" && motherColor == "Red SF")
            {
                if (offspringGender == "Male")
                {
                    return "Red DF";
                }
                else
                {
                    return "Red SF";
                }
            }
            else if (fatherColor == "Red SF" && motherColor == "Red SF")
            {

                // Create a random number generator
                Random random = new Random();

                // Generate a random number between 0 and 1
                double randomNumber = random.NextDouble();



                if (offspringGender == "Male")
                {
                    // Set maleorfemale based on the random number
                    if (randomNumber < 0.5)
                    {
                        return "Red DF";
                    }
                    else
                    {
                        return "Red SF";
                    }


                }
                else
                {
                    // Set maleorfemale based on the random number
                    if (randomNumber < 0.5)
                    {
                        return "Red SF";
                    }
                    else
                    {
                        return "Black SF";
                    }

                }
            }

            else if (fatherColor == "Black SF" && motherColor == "Red SF")
            {

                if (offspringGender == "Male")
                {
                    return "Red SF";
                }
                else
                {
                    return "Black SF";
                }
            }

            else if (fatherColor == "Red DF" && motherColor == "Black SF")
            {

                if (offspringGender == "Male")
                {
                    return "Red SF";
                }
                else
                {
                    return "Red SF";
                }
            }

            else if (fatherColor == "Red SF" && motherColor == "Black SF")
            {

                // Create a random number generator
                Random random = new Random();

                // Generate a random number between 0 and 1
                double randomNumber = random.NextDouble();



                if (offspringGender == "Male")
                {
                    // Set maleorfemale based on the random number
                    if (randomNumber < 0.5)
                    {
                        return "Red SF";
                    }
                    else
                    {
                        return "Black SF";
                    }


                }
                else
                {
                    // Set maleorfemale based on the random number
                    if (randomNumber < 0.5)
                    {
                        return "Red SF";
                    }
                    else
                    {
                        return "Black SF";
                    }

                }
            }

            else if (fatherColor == "Black SF" && motherColor == "Black SF")
            {

                return "Black SF";
            }
            else if (fatherColor == "Yellow" && motherColor == "Yellow")
            {
                return "Yellow DF";
            }


            else if (fatherColor == "Yellow" && motherColor == "Yellow SF /YH" || motherColor == "Yellow DF" && fatherColor == "Yellow SF /YH")
            {
                Random random = new Random();
                double randomNumber = random.NextDouble();
                if (randomNumber < 0.5)
                {
                    return "Yellow DF";
                }
                else
                {
                    return "Yellow /YH";
                }
            }

            else if (fatherColor == "Yellow SF /YH" && motherColor == "Yellow SF /YH")
            {
                Random random = new Random();
                double randomNumber = random.NextDouble();
                if (randomNumber < 0.25)
                {
                    return "Yellow DF";
                }
                else if (randomNumber >= 0.25 && randomNumber < 0.5)
                {
                    Random random2 = new Random();
                    double randomNumber2 = random.NextDouble();
                    if (randomNumber2 < 0.5)
                    {
                        if (offspringGender == "Male")
                        {
                            if (randomNumber2 <= 0.25)
                            {
                                return "Black DF";

                            }
                            else
                            {
                                return "Black SF";
                            }

                        }
                        else
                        {
                            return "Black SF";
                        }

                    }

                    else
                    {

                        if (offspringGender == "Male")
                        {
                            if (randomNumber2 <= 0.25)
                            {
                                return "Red DF";

                            }
                            else
                            {
                                return "Red SF";
                            }

                        }
                        else
                        {
                            return "Red SF";
                        }
                    }


                }

                else
                {
                    return "Yellow SF /YH";
                }
            }

            else if ((fatherColor == "Yellow SF /YH" && ((motherColor == "Red SF") || (motherColor == "Black SF"))) || (motherColor == "Yellow SF /YH" && ((fatherColor == "Red SF") || (fatherColor == "Black SF") || (fatherColor == "Red DF") || (fatherColor == "Black DF"))))
            {
                Random random = new Random();
                double randomNumber = random.NextDouble();
                if (randomNumber < 0.50)
                {
                    return "Yellow DF";
                }
                else
                {


                    Random random2 = new Random();
                    double randomNumber2 = random.NextDouble();
                    if (randomNumber2 < 0.5)
                    {
                        if (offspringGender == "Male")
                        {
                            if (randomNumber2 <= 0.25)
                            {
                                return "Black DF";

                            }
                            else
                            {
                                return "Black SF";
                            }

                        }
                        else
                        {
                            return "Black SF";
                        }

                    }

                    else
                    {

                        if (offspringGender == "Male")
                        {
                            if (randomNumber2 <= 0.25)
                            {
                                return "Red DF";

                            }
                            else
                            {
                                return "Red SF";
                            }

                        }
                        else
                        {
                            return "Red SF";
                        }
                    }
                }


            }
            else if ((fatherColor == "Yellow" && ((motherColor == "Red SF") || (motherColor == "Black SF"))) || (motherColor == "Yellow" && ((fatherColor == "Red SF") || (fatherColor == "Black SF") || (fatherColor == "Red DF") || (fatherColor == "Black DF"))))
            {


                return "Yellow SF /YH";
            }

            else
            {
                Random random = new Random();
                double randomNumber = random.NextDouble();
                Random random2 = new Random();
                double randomNumber2 = random.NextDouble();
                if (randomNumber2 < 0.5)
                {
                    if (offspringGender == "Male")
                    {
                        if (randomNumber2 <= 0.25)
                        {
                            return "Black DF";

                        }
                        else
                        {
                            return "Black SF";
                        }

                    }
                    else
                    {
                        return "Black SF";
                    }

                }

                else
                {

                    if (offspringGender == "Male")
                    {
                        if (randomNumber2 <= 0.25)
                        {
                            return "Red DF";

                        }
                        else
                        {
                            return "Red SF";
                        }

                    }
                    else
                    {
                        return "Red SF";
                    }
                }
            }
        }



        public void addBird(Bird bird)
        {
            try
            {

                string birdId = Guid.NewGuid().ToString();
                bird.IndexKey = birdId;

                var selectedItem = ContainerBoxIndexCage.Items
                      .Cast<ContainerBoxItem>()
                       .FirstOrDefault(item => item.DisplayText == ContainerBoxIndexCage.Text);


                if (selectedItem != null)
                {
                    string hiddenValue = selectedItem.HiddenValue;

                    client.Set("users/" + Login.currentusername + "/Birds/" + birdId, bird);
                    client.Set("users/" + Login.currentusername + "/Cages/" + hiddenValue + "/BirdsOfCage/" + birdId, bird);
                    MessageBox.Show("You Add Succefully Bird Number Index: " + textBoxIndexNumberOffSpring.Text);
                    loadBirdsList();
                }
                else
                {
                    MessageBox.Show("Cage not found");
                }







            }
            catch (FirebaseException)
            {
                // handle failure ...
            }
        }
    }
}