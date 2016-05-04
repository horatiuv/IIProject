using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //mysql library
using System.ComponentModel.DataAnnotations; //used for email validation
using System.Text;
using System.Security.Cryptography;

namespace Project_II
{
    public partial class Login : Form
    {
        private DBConnect con; //connection to the db
        public static Home h; 
        public static CUser user_class; //object to store info about current user

        public Login()
        {
            InitializeComponent();
            this.AcceptButton = B_signin; //enter key to sign in
            con = new DBConnect("localhost", "plutodb", "root", "");
        }

        //SIGN IN panel (start screen) -----------------------------------------------------
        private const string defaultUserLoginText = "enter your email/username";
        private const string defaultPassLoginText = "enter your password";

        //user TextBox
        private void tB_user_GotFocus(object sender, EventArgs e)
        {
            if (tB_user.Text.Equals(defaultUserLoginText))
                tB_user.Clear();
            tB_user.BackColor = System.Drawing.Color.White;
            tB_user.ForeColor = System.Drawing.Color.Black;
        }

        private void tB_user_LostFocus(object sender, EventArgs e)
        {
            tB_user.Text = tB_user.Text == string.Empty ? defaultUserLoginText : tB_user.Text;
            tB_user.BackColor = System.Drawing.SystemColors.MenuBar;
            tB_user.ForeColor = System.Drawing.Color.Gray;
        }

        private void tB_user_TextChanged(object sender, EventArgs e)
        {
            tB_user.BackColor = System.Drawing.Color.White;
            tB_user.ForeColor = System.Drawing.Color.Black;
        }

        //pass TextBox
        private void tB_pass_GotFocus(object sender, EventArgs e)
        {
            if (tB_pass.Text.Equals(defaultPassLoginText))
                tB_pass.Clear();
            tB_pass.BackColor = System.Drawing.Color.White;
            tB_pass.ForeColor = System.Drawing.Color.Black;
            tB_pass.PasswordChar = '*';
        }

        private void tB_pass_LostFocus(object sender, EventArgs e)
        {
            tB_pass.Text = tB_pass.Text == string.Empty ? defaultPassLoginText : tB_pass.Text;
            tB_pass.BackColor = System.Drawing.SystemColors.MenuBar;
            tB_pass.ForeColor = System.Drawing.Color.Gray;
        }

        private void tB_pass_TextChanged(object sender, EventArgs e)
        {
            tB_pass.BackColor = System.Drawing.Color.White;
            tB_pass.ForeColor = System.Drawing.Color.Black;
        }

        //sign in Button
        private void B_signin_Click(object sender, EventArgs e)
        {
            //check contents entered by user
            string user = tB_user.Text;
            string pass = tB_pass.Text;

            bool valid = true;
            string errorMsg = string.Empty;

            if (user.Equals(defaultUserLoginText) || pass.Equals(defaultPassLoginText))
            {
                valid = false;
                errorMsg = "you have to complete all fields\n";
            }
            else
            {
                //escape special characters only if the input is USERNAME, not EMAIL
                if (!(new EmailAddressAttribute().IsValid(tB_user.Text))) //checking not to be EMAIL
                {
                    bool notAllowedChars = false; //there are no chars that are not allowed;
                                                  //everything is fine
                    foreach (char c in tB_user.Text)
                    {
                        if (!((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_'))
                        {
                            valid = false;
                            notAllowedChars = true;
                        }
                    }
                    if (notAllowedChars)
                        errorMsg += "username can only contain letters,numbers, points and underscores";
                }
            }


            if (valid) //from the structural point of view (good format for email/username)
            {

                MySqlCommand cmd = con.connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM users WHERE email = @email OR username = @username";
                cmd.Parameters.AddWithValue("@email", user);
                cmd.Parameters.AddWithValue("@username", user);

                bool ok = true;
                string passFromDB = String.Empty;

                //try to open the connection to db
                try
                {
                    con.OpenConnection();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            passFromDB = reader["password"].ToString();
                            pass = con.hashPassword(pass);
                            if (!pass.Equals(passFromDB))
                            {
                                ok = false;
                                errorMsg += "password is incorrect\n";
                            }
                        }
                    }
                    else
                    {
                        ok = false;
                        errorMsg += "username is incorrect";
                    }

                    //populate the user_class object
                    if (ok)
                    {
                        //get info about user 
                        int id_userDB = int.Parse(reader["id_user"].ToString());
                        string type_userDB = reader["type_user"].ToString();
                        string userDB = reader["username"].ToString();
                        string passDB = reader["password"].ToString();
                        string emailDB = reader["email"].ToString();
                        user_class = new CUser(id_userDB, type_userDB, userDB, passDB, emailDB);
                    }
                    reader.Close();
                    con.CloseConnection();

                    if (ok)
                    {
                        h = new Home();
                        h.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(errorMsg);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("could not connect to the database\n" + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show(errorMsg);
            }

        }

        //Don't have an account? "Sign up now!" LinkLabel
        private void lL_signupnow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            resetSignUp();
            p_signup.Visible = true;
        }

        //"Forgot your password?" LinkLabel
        private void lL_forgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            p_forgot.Visible = true;
        }
        //endOf SIGN IN panel
        //----------------------------------------------------------------------

        //FORGOT PASSWORD Panel ------------------------------------------------------
        private void lL_signin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            p_forgot.Visible = false;
        }

        private void tB_forgot_email_Click(object sender, EventArgs e)
        {
            tB_forgot_email.Clear();
            tB_forgot_email.BackColor = System.Drawing.Color.White;
            tB_forgot_email.ForeColor = System.Drawing.Color.Black;
        }

        private void tB_forgot_email_TextChanged(object sender, EventArgs e)
        {
            tB_forgot_email.BackColor = System.Drawing.Color.White;
            tB_forgot_email.ForeColor = System.Drawing.Color.Black;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            p_signup.Visible = false;
            resetSignUp();
        }

        //SIGN UP Panel -------------------------------------------------------
        private const string defaultUsernameText = "choose your username";
        private const string defaultEmailText = "enter your email";
        private const string defaultPasswordText = "enter your password";
        private const string defaultPassword2Text = "re-enter your password";

        //username TextBox
        private void tB_username_GotFocus(object sender, EventArgs e)
        {
            if (tB_username.Text.Equals(defaultUsernameText))
                tB_username.Clear();
            tB_username.BackColor = System.Drawing.Color.White;
            tB_username.ForeColor = System.Drawing.Color.Black;
        }

        private void tB_username_LostFocus(object sender, EventArgs e)
        {
            tB_username.Text = tB_username.Text == string.Empty ? defaultUsernameText : tB_username.Text;
            tB_username.BackColor = System.Drawing.SystemColors.MenuBar;
            tB_username.ForeColor = System.Drawing.Color.Gray;
        }

        private void tB_username_TextChanged(object sender, EventArgs e)
        {
            tB_username.BackColor = System.Drawing.Color.White;
            tB_username.ForeColor = System.Drawing.Color.Black;
            if (tB_username.Text.Length < 6)
            {
                //call SetError on the errorProvider
                errorP_username.SetError(tB_username, "username should have at least 6 characters");
            }
            else
            {
                int k = 0;
                foreach (char c in tB_username.Text)
                {
                    if (!((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_'))
                    {
                        //call SetError on the errorProvider
                        k = 1;
                        errorP_username.SetError(tB_username, "username can only contain letters,numbers, points and underscores");
                    }
                }
                if (k == 0) errorP_username.Clear();
            }


        }

        //email TextBox
        private void tB_email_GotFocus(object sender, EventArgs e)
        {
            if (tB_email.Text.Equals(defaultEmailText))
                tB_email.Clear();
            tB_email.BackColor = System.Drawing.Color.White;
            tB_email.ForeColor = System.Drawing.Color.Black;
        }

        private void tB_email_LostFocus(object sender, EventArgs e)
        {
            tB_email.Text = tB_email.Text == string.Empty ? defaultEmailText : tB_email.Text;
            tB_email.BackColor = System.Drawing.SystemColors.MenuBar;
            tB_email.ForeColor = System.Drawing.Color.Gray;
        }

        private void tB_email_TextChanged(object sender, EventArgs e)
        {
            tB_email.BackColor = System.Drawing.Color.White;
            tB_email.ForeColor = System.Drawing.Color.Black;
            if (!(new EmailAddressAttribute().IsValid(tB_email.Text)))
            {
                //call SetError on the errorProvider
                errorP_email.SetError(tB_email, "the email address you entered is not valid");
            }
            else
            {
                errorP_email.Clear();
            }
        }

        //password TextBox
        private void tB_password_GotFocus(object sender, EventArgs e)
        {
            if (tB_password.Text.Equals(defaultPasswordText))
                tB_password.Clear();
            tB_password.BackColor = System.Drawing.Color.White;
            tB_password.ForeColor = System.Drawing.Color.Black;
            tB_password.PasswordChar = '*';
        }

        private void tB_password_LostFocus(object sender, EventArgs e)
        {
            tB_password.Text = tB_password.Text == string.Empty ? defaultPasswordText : tB_password.Text;
            tB_password.BackColor = System.Drawing.SystemColors.MenuBar;
            tB_password.ForeColor = System.Drawing.Color.Gray;
        }

        private void tB_password_TextChanged(object sender, EventArgs e)
        {
            tB_password.BackColor = System.Drawing.Color.White;
            tB_password.ForeColor = System.Drawing.Color.Black;
            if (tB_password.Text.Length < 5)
            {
                //call SetError on the errorProvider
                errorP_password.SetError(tB_password, "password should be at least 5 characters long");
            }
            else
            {
                errorP_password.Clear();
            }
        }

        //password2 (re-enter) TextBox
        private void tB_password2_GotFocus(object sender, EventArgs e)
        {
            if (tB_password2.Text.Equals(defaultPassword2Text))
                tB_password2.Clear();
            tB_password2.BackColor = System.Drawing.Color.White;
            tB_password2.ForeColor = System.Drawing.Color.Black;
            tB_password2.PasswordChar = '*';
        }

        private void tB_password2_LostFocus(object sender, EventArgs e)
        {
            tB_password2.Text = tB_password2.Text == string.Empty ? defaultPassword2Text : tB_password2.Text;
            tB_password2.BackColor = System.Drawing.SystemColors.MenuBar;
            tB_password2.ForeColor = System.Drawing.Color.Gray;
        }

        private void tB_password2_TextChanged(object sender, EventArgs e)
        {
            tB_password2.BackColor = System.Drawing.Color.White;
            tB_password2.ForeColor = System.Drawing.Color.Black;
            if (!tB_password2.Text.Equals(tB_password.Text))
            {
                //call SetError on the errorProvider
                errorP_password2.SetError(tB_password2, "passwords don't match");
            }
            else
            {
                errorP_password2.Clear();
            }
        }

        //signup Button
        private void B_signup_Click(object sender, EventArgs e)
        {

            //check contents entered by user
            string username = tB_username.Text;
            string email = tB_email.Text;
            string pass = tB_password.Text;
            string pass2 = tB_password2.Text;

            //validation on the form
            bool valid = true;
            string errorMsg = string.Empty;

            if (username.Equals(defaultUsernameText) ||
                email.Equals(defaultEmailText) ||
                pass.Equals(defaultPasswordText) ||
                pass2.Equals(defaultPassword2Text))
            {
                valid = false;
                errorMsg = "you have to complete all fields\n";
            }

            if (errorP_username.GetError(tB_username).Length > 0 ||
                 errorP_email.GetError(tB_email).Length > 0 ||
                 errorP_password.GetError(tB_password).Length > 0 ||
                 errorP_password2.GetError(tB_password2).Length > 0)
            {
                valid = false;
            }

            if (valid)
            {
                //hash password
                pass = con.hashPassword(pass);

                //open connection
                if (con.OpenConnection() == true)
                {
                    //create command
                    MySqlCommand cmd = con.connection.CreateCommand();
                    cmd.CommandText = "INSERT INTO users (type_user, username, password, email) VALUES(?type_user, ?username, ?password, ?email)";
                    cmd.Parameters.AddWithValue("?type_user", "user");
                    cmd.Parameters.AddWithValue("?username", username);
                    cmd.Parameters.AddWithValue("?password", pass);
                    cmd.Parameters.AddWithValue("?email", email);
                    //Execute command
                    try
                    {
                        cmd.ExecuteNonQuery();
                        string msg = username + ", you have successfully signed up!";
                        string caption = "Signed up successfully!";
                        MessageBox.Show(msg, caption);
                        //hide signup panel and go back to login
                        p_signup.Visible = false;
                        //reset all the modified fields in signup panel
                        resetSignUp();


                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                    //close connection
                    con.CloseConnection();
                }
            }
            else
            {
                errorMsg += errorP_username.GetError(tB_username) + "\n" +
                            errorP_email.GetError(tB_email) + "\n" +
                            errorP_password.GetError(tB_password) + "\n" +
                            errorP_password2.GetError(tB_password2);
                string caption = "Something is wrong!";
                MessageBox.Show(errorMsg, caption);
            }
        }

        private void resetSignUp()
        {
            tB_username.BackColor = System.Drawing.SystemColors.MenuBar;
            tB_username.ForeColor = System.Drawing.Color.Gray;
            tB_username.Text = defaultUsernameText;

            tB_email.BackColor = System.Drawing.SystemColors.MenuBar;
            tB_email.ForeColor = System.Drawing.Color.Gray;
            tB_email.Text = defaultEmailText;

            tB_password.BackColor = System.Drawing.SystemColors.MenuBar;
            tB_password.ForeColor = System.Drawing.Color.Gray;
            tB_password.Text = defaultPasswordText;

            tB_password2.BackColor = System.Drawing.SystemColors.MenuBar;
            tB_password2.ForeColor = System.Drawing.Color.Gray;
            tB_password2.Text = defaultPassword2Text;

            errorP_username.Clear();
            errorP_email.Clear();
            errorP_password.Clear();
            errorP_password2.Clear();
        }
        //endOf SIGN UP panel
        //----------------------------------------------------------------------

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
