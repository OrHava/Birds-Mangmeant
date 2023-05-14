using FireSharp.Response;
using RestSharp.Extensions;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System;

using System.Text.RegularExpressions;
using FireSharp;
using FireSharp.Interfaces;
using FireSharp.Exceptions;

namespace Birds_Mangmeant
{
    public partial class Login : Form
    {

#pragma warning disable CS8603 // Possible null reference return.
        public static string currentusername { get => currentusername1; set => currentusername1 = value; }
#pragma warning restore CS8603 // Possible null reference return.
        static string currentuserpassword = "";


        public Login()
        {


            InitializeComponent();
            this.MaximizeBox = false;
            PanelRegister.Height = 0;
            PanelLoginSave.Location = new Point(300, 0);

            if (Properties.Settings.Default.UserName != string.Empty && Properties.Settings.Default.CheckBoxDef == "true")
            {
                txtLoginUserName.Text = Properties.Settings.Default.UserName;
                txtLoginPassword.Text = Properties.Settings.Default.Password;
                checkBoxRememberMe.Checked = true;
            }
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


            txtRegName.BackColor = Color.White;
            panelUsername.BackColor = Color.White;

            panelEmail.BackColor = SystemColors.Control;
            TxtRegEmail.BackColor = SystemColors.Control;

            if (string.IsNullOrEmpty(TxtRegEmail.Text))
            {
                TxtRegEmail.Text = "Enter Email";
            }
            if (string.IsNullOrEmpty(txtRegPassword.Text))
            {
                txtRegPassword.Text = "Enter Password";

            }

            if (string.IsNullOrEmpty(txtRegRePassword.Text))
            {
                txtRegRePassword.Text = "Re - Enter Password";
            }
            if (string.IsNullOrEmpty(txtRegId.Text))
            {
                txtRegId.Text = "Enter ID";
            }






            panelID.BackColor = SystemColors.Control;
            txtRegId.BackColor = SystemColors.Control;


            panelPassword.BackColor = SystemColors.Control;
            txtRegPassword.BackColor = SystemColors.Control;

            panelRePassword.BackColor = SystemColors.Control;
            txtRegRePassword.BackColor = SystemColors.Control;



            if (!textDeleted && txtRegName.Text == "Enter UserName")
            {
                txtRegName.Text = "";
                textDeleted = true;
            }
            textDeleted = false;
        }



        private void textBox2_Click_1(object sender, EventArgs e)
        {



            if (string.IsNullOrEmpty(txtRegName.Text))
            {

                txtRegName.Text = "Enter UserName";
            }
            if (string.IsNullOrEmpty(txtRegPassword.Text))
            {
                txtRegPassword.Text = "Enter Password";

            }

            if (string.IsNullOrEmpty(txtRegRePassword.Text))
            {
                txtRegRePassword.Text = "Re - Enter Password";
            }
            if (string.IsNullOrEmpty(txtRegId.Text))
            {
                txtRegId.Text = "Enter ID";
            }







            panelEmail.BackColor = Color.White;
            TxtRegEmail.BackColor = Color.White;

            txtRegName.BackColor = SystemColors.Control;
            panelUsername.BackColor = SystemColors.Control;


            panelID.BackColor = SystemColors.Control;
            txtRegId.BackColor = SystemColors.Control;

            panelPassword.BackColor = SystemColors.Control;
            txtRegPassword.BackColor = SystemColors.Control;

            panelRePassword.BackColor = SystemColors.Control;
            txtRegRePassword.BackColor = SystemColors.Control;

            if (!textDeleted1 && TxtRegEmail.Text == "Enter Email")
            {
                TxtRegEmail.Text = "";
                textDeleted1 = true;
            }
            textDeleted1 = false;

        }

        private void textBox1_Click_1(object sender, EventArgs e)


        {

            if (string.IsNullOrEmpty(txtRegName.Text))
            {

                txtRegName.Text = "Enter UserName";
            }
            if (string.IsNullOrEmpty(TxtRegEmail.Text))
            {

                TxtRegEmail.Text = "Enter Email";


            }

            if (string.IsNullOrEmpty(txtRegRePassword.Text))
            {
                txtRegRePassword.Text = "Re - Enter Password";
            }
            if (string.IsNullOrEmpty(txtRegId.Text))
            {
                txtRegId.Text = "Enter ID";
            }




            panelPassword.BackColor = Color.White;
            txtRegPassword.BackColor = Color.White;


            panelEmail.BackColor = SystemColors.Control;
            TxtRegEmail.BackColor = SystemColors.Control;



            txtRegName.BackColor = SystemColors.Control;
            panelUsername.BackColor = SystemColors.Control;


            panelID.BackColor = SystemColors.Control;
            txtRegId.BackColor = SystemColors.Control;


            panelRePassword.BackColor = SystemColors.Control;
            txtRegRePassword.BackColor = SystemColors.Control;


            if (!textDeleted2 && txtRegPassword.Text == "Enter Password")
            {
                txtRegPassword.Text = "";
                textDeleted2 = true;
            }
            textDeleted2 = false;
        }

        private void textBox8_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtRegName.Text))
            {

                txtRegName.Text = "Enter UserName";
            }
            if (string.IsNullOrEmpty(TxtRegEmail.Text))
            {

                TxtRegEmail.Text = "Enter Email";


            }

            if (string.IsNullOrEmpty(txtRegPassword.Text))
            {
                txtRegPassword.Text = "Enter Password";
            }
            if (string.IsNullOrEmpty(txtRegId.Text))
            {
                txtRegId.Text = "Enter ID";
            }



            panelRePassword.BackColor = Color.White;
            txtRegRePassword.BackColor = Color.White;

            panelEmail.BackColor = SystemColors.Control;
            TxtRegEmail.BackColor = SystemColors.Control;

            txtRegName.BackColor = SystemColors.Control;
            panelUsername.BackColor = SystemColors.Control;


            panelID.BackColor = SystemColors.Control;
            txtRegId.BackColor = SystemColors.Control;

            panelPassword.BackColor = SystemColors.Control;
            txtRegPassword.BackColor = SystemColors.Control;


            if (!textDeleted3 && txtRegRePassword.Text == "Re - Enter Password")
            {
                txtRegRePassword.Text = "";
                textDeleted3 = true;
            }
            textDeleted3 = false;
        }

        private void txtRegId_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtRegName.Text))
            {

                txtRegName.Text = "Enter UserName";
            }
            if (string.IsNullOrEmpty(TxtRegEmail.Text))
            {

                TxtRegEmail.Text = "Enter Email";


            }

            if (string.IsNullOrEmpty(txtRegPassword.Text))
            {
                txtRegPassword.Text = "Enter Password";
            }
            if (string.IsNullOrEmpty(txtRegRePassword.Text))
            {

                txtRegRePassword.Text = "Re - Enter Password";
            }




            panelID.BackColor = Color.White;
            txtRegId.BackColor = Color.White;

            panelEmail.BackColor = SystemColors.Control;
            TxtRegEmail.BackColor = SystemColors.Control;


            txtRegName.BackColor = SystemColors.Control;
            panelUsername.BackColor = SystemColors.Control;




            panelPassword.BackColor = SystemColors.Control;
            txtRegPassword.BackColor = SystemColors.Control;

            panelRePassword.BackColor = SystemColors.Control;
            txtRegRePassword.BackColor = SystemColors.Control;
            if (!textDeleted4 && txtRegId.Text == "Enter ID")
            {
                txtRegId.Text = "";
                textDeleted4 = true;
            }
            textDeleted4 = false;
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

        public static string? email;

        private static string? currentusername1;

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
                MessageBox.Show("User name can only contain the most two numbers.");

            }
            else
            {
                var register = new register
                {
                    Name = txtRegName.Text,
                    Password = txtRegPassword.Text,
                    Email = TxtRegEmail.Text,
                    ID = txtRegId.Text,
                    RememberMe = false,

                };
                FirebaseResponse response = client.Set("users/" + txtRegName.Text, register);
                register res = response.ResultAs<register>();
                register todo = new register()
                {
                    Email = TxtRegEmail.Text,
                };





                string message = "Do you want to enter your account?";
                string title = "Registered succesfully";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {

                    List<Tuple<string, string>> usernameres = new List<Tuple<string, string>>();
                    FirebaseResponse response2 = client.Get("users/");
                    Dictionary<string, register> result2 = response2.ResultAs<Dictionary<string, register>>();

                    foreach (var get in result2)
                    {

                        if (get.Value!=null) {
                            usernameres.Add(Tuple.Create(get.Value.Name ?? "", get.Value.Password ?? "" ));
                        }
                        

                    }



                    if (usernameres.Contains(Tuple.Create(txtRegName.Text, txtRegPassword.Text)))
                    {
                        MessageBox.Show("Welcome " + txtRegName.Text);
                        currentusername = txtRegName.Text;
                        currentuserpassword = txtRegPassword.Text;
                        Home hm = new Home();
                        this.Hide();

                        hm.ShowDialog();
                        this.Close();

                    }
                    this.Close();


                }
                else
                {
                    // Do something  

                }


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
              //  Dictionary<string, register> result = response.ResultAs<Dictionary<string, register>>();
                Dictionary<string, register> result;

                if (response.Body != null)
                {
                    // rest of the code
                    var birdsDict = response.ResultAs<Dictionary<string, register>>();
                    if (birdsDict != null)
                    {
                        result = birdsDict;

                        foreach (var get in result)
                        {

                            if (get.Value!=null) {
                                usernameres.Add(Tuple.Create(get.Value.Name ?? "", get.Value.Password ?? ""));
                            }

                         

                        }
                    }
                }
                else
                {
                    // handle the case where there is no data in the Firebase path
                }




                if (checkBoxRememberMe.Checked)
                {
                    IFirebaseClient client = new FirebaseClient(config);



                    try
                    {

                        client.Set("users/" + txtLoginUserName.Text + "/RememberMe", true);

                    }
                    catch (FirebaseException)
                    {
                        // handle failure ...
                    }


                    Properties.Settings.Default.UserName = txtLoginUserName.Text;
                    Properties.Settings.Default.Password = txtLoginPassword.Text;
                    Properties.Settings.Default.CheckBoxDef = "true";
                    Properties.Settings.Default.Save();

                }

                if (!checkBoxRememberMe.Checked)
                {
                    IFirebaseClient client = new FirebaseClient(config);



                    try
                    {

                        client.Set("users/" + txtLoginUserName.Text + "/RememberMe", false);

                    }
                    catch (FirebaseException)
                    {
                        // handle failure ...
                    }
                    Properties.Settings.Default.CheckBoxDef = "false";



                }



                if (usernameres.Contains(Tuple.Create(txtLoginUserName.Text, txtLoginPassword.Text)))
                {

                    currentusername = txtLoginUserName.Text;
                    currentuserpassword = txtLoginPassword.Text;
                    MessageBox.Show("Welcome " + txtLoginUserName.Text);






                    Home hm = new Home();
                    this.Hide();

                    hm.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Username or password dont match in the system.");
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


                FirebaseResponse response2 = client.Get("users/");
                Dictionary<string, register> result = response2.ResultAs<Dictionary<string, register>>();

                foreach (var get in result)
                {

                    if (get.Value.Name == txtLoginUserName.Text && get.Value.Email != null && get.Value.Password != null)
                    {


                        sendEMail(get.Value.Email, get.Value.Name, get.Value.Password);

                        break;
                    }


                }



            }

        }


        //private void Login_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    // Check if the user clicked the exit button
        //    if (e.CloseReason == CloseReason.UserClosing)
        //    {
        //        // Close all open forms except the main form
        //        foreach (Form form in Application.OpenForms)
        //        {
        //            if (form != this)
        //            {
        //                form.Close();
        //            }
        //        }
        //    }
        //}

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
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

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            PanelRegister.Height = 0;

            PanelLoginSave.Location = new Point(300, 0);
        }

        private void btnRegisterSave_Click_1(object sender, EventArgs e)
        {


            PanelRegister.Height = PanelLoginSave.Height;

            PanelLoginSave.Location = new Point(300, 0);

        }
    }
}