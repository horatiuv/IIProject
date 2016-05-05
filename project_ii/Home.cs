using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_II
{
    public partial class Home : Form
    {

        public static int id_category;
        private DBConnect con;
        //connection to the db
       // static CTask task_class;

        public Home()
        {
            InitializeComponent();
            con = new DBConnect("localhost", "plutodb", "root", "");
            displayGreeting();
            p_notes.Visible = false;

            //today button appearance
            btnToday.FlatAppearance.BorderColor = Color.DarkGray;
            btnToday.FlatAppearance.BorderSize = 1;
            b_notes.FlatAppearance.BorderColor = Color.DarkGray;
            b_notes.FlatAppearance.BorderSize = 1;

            //populate tasks list
            listViewToday.Columns.Add("");
            listViewToday.Columns.Add("Task description");
            listViewToday.Columns.Add("Location");
            listViewToday.Columns.Add("Date/Hour");
            listViewToday.Columns.Add("Status");
            CTask.populateTaskList(listViewToday, today);

            //populate next list
            listViewNext.Columns.Add("");
            listViewNext.Columns.Add("task description");
            listViewNext.Columns.Add("location");
            listViewNext.Columns.Add("date/hour");
            listViewNext.Columns.Add("status");
            CTask.populateNextTasksList(listViewNext);

            //write the number of tasks for today
            int todayTasks = CTask.countTodayTasks();
            btnToday.Text = "Today(" + todayTasks + ")";

            //populate category list
            categories.MouseDown += new MouseEventHandler(categories_MouseDown);
            CCategory.populateCategoryList(categories);

            //create right and left click for tasks
            listViewToday.MouseDown += new MouseEventHandler(listViewToday_MouseDown);
            //listViewToday.MouseDown += new MouseEventHandler(listViewToday_Click);

            ///------------------------------------------------------------------------------
            ///Populate the bottom panel from home
            string currentDate = DateTime.Now.DayOfWeek.ToString();
            if (con.OpenConnection() == true)
            {
                int indexQuotes = 1;
                indexQuotes = DateTime.Now.Day % 10 + 1;

                MySqlCommand cmd = con.connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM quotes WHERE id_quotes=?index_Quotes";
                cmd.Parameters.AddWithValue("?index_Quotes", indexQuotes);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    labelQuote.Text = "\"" + reader["quote"].ToString() + "\"";
                    labelQuoteAuthor.Text = reader["author"].ToString();
                }


                con.CloseConnection(); // !!!!
            }

            //change the task color based on the task priority
            /* foreach (ListViewItem lvw in listViewToday.Items)
             {
                 if (Convert.ToInt32(lvw.SubItems[2].Text) > 2)
                 {
                     lvw.BackColor = Color.Red;
                 }
                 else
                 {
                     lvw.BackColor = Color.LightBlue;
                 }
             }*/

        }
        private void listViewToday_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Login.h.listViewToday.SelectedItems.Count > 0)
                {
                    CTask.doneTask(Login.h.listViewToday);
                    Login.h.listViewToday.SelectedItems.Clear();
                }
            }
            if (e.Button == MouseButtons.Right)
            {

                if (Login.h.listViewToday.SelectedItems.Count > 0)
                {
                    contextMenuStripListViewToday.Show(Cursor.Position);
                    // Login.h.listViewToday.SelectedItems.Clear();
                    // MessageBox.Show("YEEEEY");                   
                }
            }
        }
        //Update ContextMenuStrip for tasks - ListViewToday
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string task_ID_str = Login.h.listViewToday.SelectedItems[0].SubItems[5].Text;
            int task_ID = Int32.Parse(task_ID_str);
            int user_ID = Login.user_class.getUserId();
            FormUpdateTask upt = new FormUpdateTask(user_ID,task_ID);
            upt.Show();

        }

        //Delete ContextMenuStrip for tasks - ListViewToday
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string task_ID_str = Login.h.listViewToday.SelectedItems[0].SubItems[5].Text;
            int task_ID = Int32.Parse(task_ID_str);
            FormDeleteTask del = new FormDeleteTask(task_ID);
            del.Show();
        }
        private void displayGreeting()
        {
            //get the curent date
            date.Text = DateTime.Now.ToString("dd/MM/yyyy");

            //get the current time of the day
            string l_greeting;
            int l_currHour = DateTime.Now.TimeOfDay.Hours;
            if (l_currHour > 22 || l_currHour <= 7)
            {
                l_greeting = "Good Night, ";
            }
            else
                if (l_currHour > 7 && l_currHour <= 11)
                {
                    l_greeting = "Good Morning, ";
                }
                else
                    if (l_currHour > 11 && l_currHour <= 17)
                    {
                        l_greeting = "Hello, ";
                    }
                    else
                    {
                        l_greeting = "Good Evening, ";
                    }
            //set the greeting according to the day time and the current user
            //set the greeting according to the day time and the current user
            lB_greet.Text = l_greeting;
            linkLabel_user.Text = Login.user_class.getUsername();
            linkLabel_user.Location = new Point(lB_greet.Size.Width, 30);
        }

        private void btnAddaTaskHomeForm_Click(object sender, EventArgs e)
        {
            FormAddTask h = new FormAddTask(Login.user_class.getUserId());
            h.Show();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            categories.ClearSelected();
            listViewToday.ResetText();
            CTask.populateTaskList(listViewToday, today);
            panel1.Visible = true;
            p_profile.Visible = false;
            p_notes.Visible = false;
        }

        string defaultCategoryText = "Add a new category...";
        private void newCategory_GotFocus(object sender, EventArgs e)
        {
            if (newCategory.Text.Equals(defaultCategoryText))
                newCategory.Clear();
            newCategory.BackColor = System.Drawing.Color.White;
            newCategory.ForeColor = System.Drawing.Color.Black;
        }

        private void newCategory_LostFocus(object sender, EventArgs e)
        {
            newCategory.Text = newCategory.Text == string.Empty ? defaultCategoryText : newCategory.Text;
            newCategory.BackColor = System.Drawing.SystemColors.MenuBar;
            newCategory.ForeColor = System.Drawing.Color.Gray;
        }

        bool m_categoryIsAdded = false;
        private void newCategory_TextChanged(object sender, EventArgs e)
        {
            newCategory.BackColor = System.Drawing.Color.White;
            newCategory.ForeColor = System.Drawing.Color.Black;
            if (m_categoryIsAdded == false)
            {
                this.newCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckKeys);
                m_categoryIsAdded = true;
            }
        }

        private void newCategory_Click(object sender, EventArgs e)
        {
            newCategory.Text = "";
        }

        private void CheckKeys(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //check if is pressed Enter
            if (e.KeyChar == (char)13)
            {
                string newCategName = newCategory.Text;
                CCategory.createNewCategory(newCategName);
            }
        }

        private void categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categories.SelectedItems.Count > 0)
            {
                //show the tasks from selected category
                string categorySelected = categories.SelectedItem.ToString();
                char[] delimiterChars = { '(' };
                string[] words = categorySelected.Split(delimiterChars);

                int categoryId = CCategory.getCategoryId(words[0]);

                listViewToday.ResetText();
                Login.h.today.Text = words[0];
                CCategory.populateTasksFromCategory(listViewToday, categoryId);
                panel1.Visible = true;
                p_notes.Visible = false;
                p_profile.Visible = false;
            }
        }

        public void listViewToday_Click(object sender, EventArgs e)
        {
            /*if (Login.h.listViewToday.SelectedItems.Count> 0)
            {
                CTask.doneTask(Login.h.listViewToday);
            }*/

           // ListViewHitTestInfo info = this.listViewToday.HitTest(0,0);
            //MessageBox.Show(info.SubItem.Text + " clicked!");
        }


        public void listViewNext_Click(object sender, EventArgs e)
        {
            if (Login.h.listViewNext.SelectedItems.Count > 0)
            {
                CTask.doneTask(Login.h.listViewNext);
            }
                
        }

        private void categories_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (categories.SelectedItems.Count > 0)
                {
                    //show the tasks from selected category
                    string categorySelected = categories.SelectedItem.ToString();
                    char[] delimiterChars = { '(' };
                    string[] words = categorySelected.Split(delimiterChars);

                    id_category = CCategory.getCategoryId(words[0]);

                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            UpdateCategoryForm c = new UpdateCategoryForm();
            c.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBConnect con; //connection to the db
            con = new DBConnect("localhost", "plutodb", "root", "");
            //try to open the connection to db
            if (con.OpenConnection() == true)
            {
                //verify if there are any tasks in the category
                MySqlCommand cmdTasks = con.connection.CreateCommand();
                cmdTasks.CommandText = "SELECT * FROM tasks WHERE categories_id_category = @id_cat";
                cmdTasks.Parameters.AddWithValue("@id_cat", Home.id_category);

                //Create a data reader and execute the command
                MySqlDataReader dataReader = cmdTasks.ExecuteReader();
                if (dataReader.HasRows)
                {
                    DialogResult resultTasksDelete = MessageBox.Show("Are you sure you want to delete the category and all it's tasks?", "Confirmation", MessageBoxButtons.YesNo);
                    if (resultTasksDelete == DialogResult.Yes)
                    {
                        con.CloseConnection();
                        con.OpenConnection();

                        //delete tasks from category
                        MySqlCommand cmdDeleteTasks = con.connection.CreateCommand();
                        cmdDeleteTasks.CommandText = "DELETE FROM tasks WHERE categories_id_category = @id_cat";
                        cmdDeleteTasks.Parameters.AddWithValue("@id_cat", Home.id_category);
                        cmdDeleteTasks.ExecuteNonQuery();
                    }
                }

                con.CloseConnection();
                con.OpenConnection();

                //create command to delete category
                MySqlCommand cmd = con.connection.CreateCommand();
                cmd.CommandText = "DELETE FROM categories WHERE id_category = @id_cat";
                cmd.Parameters.AddWithValue("@id_cat", Home.id_category);

                cmd.ExecuteNonQuery();
            }

            CCategory.populateCategoryList(Login.h.categories);
            CTask.populateTaskList(Login.h.listViewToday, Login.h.today);
            CTask.populateNextTasksList(Login.h.listViewNext);

            con.CloseConnection();
        }


        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBoxClose ms = new MessageBoxClose();
            ms.Show();
            e.Cancel = true;
        }


        private void linkLabel_user_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            categories.ClearSelected();
            p_profile.Visible = true;
            p_notes.Visible = false;
            l_profile_user.Text = Login.user_class.getUsername();
            l_profile_email.Text = Login.user_class.getEmail();
        }

        private void tB_profile_pass_TextChanged(object sender, EventArgs e)
        {
            if (tB_profile_pass.Text.Length < 5)
            {
                //call SetError on the errorProvider
                errorProvider1.SetError(tB_profile_pass, "password should be at least 5 characters long");
            }
            else
            {
                errorProvider1.Clear();
            }
            tB_profile_pass.PasswordChar = '*';
        }

        private void tB_profile_pass2_TextChanged(object sender, EventArgs e)
        {
            if (!tB_profile_pass2.Text.Equals(tB_profile_pass.Text))
            {
                //call SetError on the errorProvider
                errorProvider2.SetError(tB_profile_pass2, "passwords don't match");
            }
            else
            {
                errorProvider2.Clear();
            }
            tB_profile_pass2.PasswordChar = '*';
        }

        private void b_profile_update_Click(object sender, EventArgs e)
        {
            string pass = tB_profile_pass.Text;

            bool valid = true;
            string errorMsg = string.Empty;

            if (errorProvider1.GetError(tB_profile_pass).Length > 0 ||
                errorProvider2.GetError(tB_profile_pass2).Length > 0)
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
                    cmd.CommandText = "UPDATE users SET password=?pass WHERE id_user=?id";
                    cmd.Parameters.AddWithValue("?pass", pass);
                    cmd.Parameters.AddWithValue("?id", Login.user_class.getUserId());
                    //Execute command
                    try
                    {
                        cmd.ExecuteNonQuery();
                        string msg = "Password has been sucessfully changed!";
                        string caption = "Password change";
                        MessageBox.Show(msg, caption);


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
                errorMsg += errorProvider1.GetError(tB_profile_pass) + "\n" +
                            errorProvider2.GetError(tB_profile_pass2) + "\n";
                string caption = "Something is wrong!";
                MessageBox.Show(errorMsg, caption);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void b_notes_Click(object sender, EventArgs e)
        {
            categories.ClearSelected();
            p_notes.Visible = true;
            p_profile.Visible = false;
            panel1.Visible = false;


            ColumnHeader title, note;
            lw_notes.Width = 575;
            title = new ColumnHeader();
            note = new ColumnHeader();
            // Set the text, alignment and width for each column header.
            title.Text = "Title";
            title.Width = 150;
            note.Text = "Note";
            note.Width = 350;
            lw_notes.Columns.Add(title);
            lw_notes.Columns.Add(note);
            //CTask.populateNotesList(lw_notes);
        }

    }
}
