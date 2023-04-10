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

namespace Birds_Mangmeant
{
	public partial class Home : Form
	{
		List<Tuple<string, string, string, string, string, string, string, Tuple<string>>> BirdList = new List<Tuple<string, string, string, string, string, string, string, Tuple<string>>>();


		public Home()
		{
			InitializeComponent();
			loadBirdsList();










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
						get.Value.Subspecies,
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
				// Close all open forms except the main form
				foreach (Form form in System.Windows.Forms.Application.OpenForms)
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

		private void pictureBox1_Click(object sender, EventArgs e)


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

		private void listViewBirds_SelectedIndexChanged(object sender, EventArgs e)
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
			panelSearch.Hide();
			PanelAddBird.Show();
			PanelAddBird.Visible = true;
			PanelAddBird.BringToFront();
			PanelAddBird.Enabled = true;


		}

		private void ButtonHome_Click(object sender, EventArgs e)
		{

			PanelAddBird.Visible = false;
			PanelAddBird.Hide();

			panelAddCage.Visible = false;
			panelAddCage.Hide();
			panelSearch.Visible = false;
			panelSearch.Hide();

			panelHome.Show();
			panelHome.Visible = true;
			panelHome.BringToFront();
		}

		private void ButtonAddCage_Click(object sender, EventArgs e)
		{

			PanelAddBird.Visible = false;
			PanelAddBird.Hide();

			panelHome.Visible = false;
			panelHome.Hide();

			panelSearch.Visible = false;
			panelSearch.Hide();

			panelAddCage.Show();
			panelAddCage.Visible = true;
			panelAddCage.BringToFront();

		}

		private void ButtonSearch_Click(object sender, EventArgs e)
		{

			PanelAddBird.Visible = false;
			PanelAddBird.Hide();

			panelHome.Visible = false;
			panelHome.Hide();


			panelHome.Visible = false;
			panelHome.Hide();

			panelSearch.Show();
			panelSearch.Visible = true;
			panelSearch.BringToFront();

		}
	}
}
