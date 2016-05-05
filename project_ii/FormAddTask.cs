using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //mysql library
//using System.Data.SqlClient; 

namespace Project_II
{
    public partial class FormAddTask : Form
    {
        //Connection to the db
        private DBConnect con; 
        //Declare the variables which will be used to enter the information in database
        private string fTaskTitle;
        private int fTaskPriorityInt;
        private string fTaskDataTimeString;
        private int userID;
        private int fTaskIDCategory;
        private string fRecurrentDays = "0000000";
        private int fTaskDone = 0;
        //Declare auxiliary variables that will help to construct the above variables
        private string fCategory;               
        private string fTaskLocation;
        private string fTaskTime;
               
        public FormAddTask(int user_ID)
        {
            InitializeComponent();
            con = new DBConnect("localhost", "plutodb", "root", "");
            this.userID = user_ID;
            ControlBox = false;
            timePicker.CustomFormat = "HH:mm";
            timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        }
             
        //---------------------------------------------------------------
        //This part of code moves the form if you press any part which is NOT a label/button/ComboBox/etc
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        //---------------------------------------------------------------

        //---------------------------------------------------------------
        //Cancel Button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //---------------------------------------------------------------

        //---------------------------------------------------------------
        ////Populate the form with the needed information when it is opened
        private void FormAddTask_Load(object sender, EventArgs e)
        {          
            //Populate the cmbBoxChooseCategory with the user's categories
            if (con.OpenConnection() == true)
            {
                MySqlCommand cmd = con.connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM categories WHERE users_id_user = @user_ID ";
                cmd.Parameters.AddWithValue("@user_ID", this.userID);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    comboBoxChooseCategory.Items.Add(dataReader.GetString("category_name"));
                }
                con.CloseConnection();
            }
            else
            {
                string errorMessage = "Database can't be opened!";
                MessageBox.Show(errorMessage);
            }
            //Populate cmbBoxPriorities with the priorities
            cmbBoxPriority.Text = "Priority";
            string[] priorities = new string[3] { "1", "2", "3" };
            foreach (var itemCombo in priorities)
            {
                cmbBoxPriority.Items.Add(itemCombo);
            }

            //Only future dates can be picked up
            //datePicker.MinDate = DateTime.Now; 

            //ToolTip tooltip = new ToolTip();
            //tooltip.SetToolTip.(System.Windows.Forms.cmbBoxPriority,"The highest priority is 1 and the lowest is 3.");


            //Load 
            // textBoxTaskTitle.Text = "Task description";
            // labelLocation.Text = "Task location";
        }

        //---------------------------------------------------------------
        ///Add.a.task Button
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            //Check if all the fields are completed with the proper informations 
            bool category = false;
            bool description = false;
            //bool location = false;
            //bool priority = false;
            int priorityValue; Int32.TryParse(cmbBoxPriority.Text, out priorityValue);

            string d = string.Empty;
            string m = string.Empty;
            string y = string.Empty;
            d = datePicker.Value.Day.ToString();
            m = datePicker.Value.Month.ToString();
            y = datePicker.Value.Year.ToString();
            fTaskDataTimeString = y + "-" + m + "-" + d + " ";
            fTaskTime = timePicker.Text.ToString();
            fTaskDataTimeString = fTaskDataTimeString + fTaskTime;

            if (comboBoxChooseCategory.Text.ToString().Equals("Choose category") || comboBoxChooseCategory.Text.ToString().Equals(String.Empty))
            {
                category = true;
            }
            if (textBoxTaskTitle.Text.ToString().Equals("Task description") || textBoxTaskTitle.Text.ToString().Equals(String.Empty))
            {
                description = true;
            }
            if (labelLocation.Text.ToString().Equals("Task location") || labelLocation.Text.ToString().Equals(String.Empty))
            {
                fTaskLocation = String.Empty;
            }
            if (cmbBoxPriority.Text.ToString().Equals("Priorities") || priorityValue < 1 || priorityValue > 3 || cmbBoxPriority.Text.ToString().Equals(String.Empty))
            {
                fTaskPriorityInt = 3;
            }

            //If at least one field is not good, a message box will appear
            //otherwise, the informations will be inserted in the database
            //otherwise, the informations will be inserted in the database
            if (category && description)
            {
                MessageBox.Show(" Before you add a task, choose a category for it and name it !! ");
            }
            else
                if (category && !(description))
            {
                MessageBox.Show(" Before you add a task, choose a category for it !! ");
            }
            else
                    if (!category && description)
            {
                MessageBox.Show(" Before you add a task, choose a name for it !! ");
            }
            else
            {

                //MessageBox.Show(fCategory);
                //MessageBox.Show(fTaskTitle);
                //MessageBox.Show(fTaskDataTimeString);
                //MessageBox.Show(fTaskLocation);
                //MessageBox.Show(fTaskPriority);
                //MessageBox.Show(fRecurrentDays);

                if (con.OpenConnection() == true)
                {
                    //Create command
                    MySqlCommand cmd = con.connection.CreateCommand();

                    cmd.CommandText = "INSERT INTO tasks (task_name, task_priority, deadline, location, rec_days, users_id_user, categories_id_category, done) VALUES (?taskName, ?taskPriority, ?taskdeadline, ?taskLocation, ?taskRecurrentDays, ?usersIdUser, ?CategoriesIdCategory, ?taskDone )";
                    cmd.Parameters.AddWithValue("taskName", fTaskTitle);
                    cmd.Parameters.AddWithValue("taskPriority", fTaskPriorityInt);
                    cmd.Parameters.AddWithValue("taskdeadline", fTaskDataTimeString);
                    cmd.Parameters.AddWithValue("taskLocation", fTaskLocation);
                    cmd.Parameters.AddWithValue("taskRecurrentDays", fRecurrentDays);
                    cmd.Parameters.AddWithValue("usersIdUser", userID);
                    cmd.Parameters.AddWithValue("CategoriesIdCategory", fTaskIDCategory);
                    cmd.Parameters.AddWithValue("taskDone", fTaskDone);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Now, Pluto knows about your task!\nDon't forget about it! Because he wouldn't :)");
                        CCategory.populateCategoryList(Login.h.categories);

                        //write the number of tasks for today
                        int todayTasks = CTask.countTodayTasks();
                        Login.h.btnToday.Text = "Today(" + todayTasks + ")";

                        //update today and next list
                        CTask.populateTaskList(Login.h.listViewToday, Login.h.today);
                        CTask.populateNextTasksList(Login.h.listViewNext);
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                    //close connection
                    con.CloseConnection();
                }
                else
                {
                    MessageBox.Show("Database can't be opened");
                }
                this.Close();
            }
        }
        //---------------------------------------------------------------

        //---------------------------------------------------------------
        private void comboBoxChooseCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            fCategory = comboBoxChooseCategory.SelectedItem.ToString();
            //After the category is chosed, we search in 'categories' table for its ID
            if (con.OpenConnection() == true)
            {
                MySqlCommand cmd = con.connection.CreateCommand();
                cmd.CommandText = "SELECT id_category FROM categories WHERE category_name = @categoryName ";
                cmd.Parameters.AddWithValue("@categoryName", fCategory);
                
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    fTaskIDCategory = Convert.ToInt16(dataReader.GetString("id_category"));
                }
                con.CloseConnection();
            }
            else
            {
                string errorMessage = "Database can't be opened!";
                MessageBox.Show(errorMessage);
            }
            //MessageBox.Show(Convert.ToString(fTaskIDCategory));
        }
        //---------------------------------------------------------------

        //---------------------------------------------------------------
        private void textBoxTaskTitle_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTaskTitle.Text.ToString().Equals("Task description"))
            {
                textBoxTaskTitle.Clear();
            }
            else
            {
                fTaskTitle = textBoxTaskTitle.Text;
                //MessageBox.Show(fTaskTitle);
            }              
        }
        //---------------------------------------------------------------

        //---------------------------------------------------------------
        private void labelLocation_TextChanged(object sender, EventArgs e)
        {
            if (labelLocation.Text.ToString().Equals("Task location"))
            {
                textBoxTaskTitle.Clear();
            }
            else
            {
                fTaskLocation = labelLocation.Text;
                //MessageBox.Show(fTaskTitle);
            }
        }
        //---------------------------------------------------------------

        //---------------------------------------------------------------
        //The string for recurrent days is modified by checking each checkBox 
        private void checkMon_CheckedChanged(object sender, EventArgs e)
        {
            char itIsChecked = fRecurrentDays[0];
            StringBuilder strB = new StringBuilder(fRecurrentDays);

            if (checkMon.Checked == true && !(itIsChecked.Equals('1')))
            {
                strB[0] = '1';
                fRecurrentDays = strB.ToString();
                //MessageBox.Show("Monday is checked " + fRecurrentDays);
            }
            else
            {
                if (checkMon.Checked == false && itIsChecked.Equals('1'))
                {
                    strB[0] = '0';
                    fRecurrentDays = strB.ToString();
                    //MessageBox.Show("Monday is unchecked " + fRecurrentDays);
                }
            }              
        }

        private void checkTue_CheckedChanged(object sender, EventArgs e)
        {
            char itIsChecked = fRecurrentDays[1];
            StringBuilder strB = new StringBuilder(fRecurrentDays);

            if (checkTue.Checked == true && !(itIsChecked.Equals('1')))
            {             
                strB[1] = '1';
                fRecurrentDays = strB.ToString();
                //MessageBox.Show("Tuesday is checked " + fRecurrentDays);
            }
            else
            {
                if (checkTue.Checked == false && itIsChecked.Equals('1'))
                {
                    strB[1] = '0';
                    fRecurrentDays = strB.ToString();
                    //MessageBox.Show("Tuesday is unchecked " + fRecurrentDays);
                }
            } 
        }

        private void checkWed_CheckedChanged(object sender, EventArgs e)
        {
            char itIsChecked = fRecurrentDays[2];
            StringBuilder strB = new StringBuilder(fRecurrentDays);

            if (checkWed.Checked == true && !(itIsChecked.Equals('1')))
            {
                strB[2] = '1';
                fRecurrentDays = strB.ToString();
                //MessageBox.Show("Wednesday is checked " + fRecurrentDays);
            }
            else
            {
                if (checkWed.Checked == false && itIsChecked.Equals('1'))
                {
                    strB[2] = '0';
                    fRecurrentDays = strB.ToString();
                    //MessageBox.Show("Wednesday is unchecked " + fRecurrentDays);
                }
            } 
        }

        private void checkThu_CheckedChanged(object sender, EventArgs e)
        {
            char itIsChecked = fRecurrentDays[3];
            StringBuilder strB = new StringBuilder(fRecurrentDays);

            if (checkThu.Checked == true && !(itIsChecked.Equals('1')))
            {
                strB[3] = '1';
                fRecurrentDays = strB.ToString();
                //MessageBox.Show("Thursday is checked " + fRecurrentDays);
            }
            else
            {
                if (checkThu.Checked == false && itIsChecked.Equals('1'))
                {
                    strB[3] = '0';
                    fRecurrentDays = strB.ToString();
                   //MessageBox.Show("Thursday is unchecked " + fRecurrentDays);
                }
            } 
        }

        private void checkFri_CheckedChanged(object sender, EventArgs e)
        {
            char itIsChecked = fRecurrentDays[4];
            StringBuilder strB = new StringBuilder(fRecurrentDays);

            if (checkFri.Checked == true && !(itIsChecked.Equals('1')))
            {
                strB[4] = '1';
                fRecurrentDays = strB.ToString();
               //MessageBox.Show("Friday is checked " + fRecurrentDays);
            }
            else
            {
                if (checkFri.Checked == false && itIsChecked.Equals('1'))
                {
                    strB[4] = '0';
                    fRecurrentDays = strB.ToString();
                    //MessageBox.Show("Friday is unchecked " + fRecurrentDays);
                }
            } 

        }

        private void checkSat_CheckedChanged(object sender, EventArgs e)
        {
            char itIsChecked = fRecurrentDays[5];
            StringBuilder strB = new StringBuilder(fRecurrentDays);

            if (checkSat.Checked == true && !(itIsChecked.Equals('1')))
            {
                strB[5] = '1';
                fRecurrentDays = strB.ToString();
                //MessageBox.Show("Saturday is checked " + fRecurrentDays);
            }
            else
            {
                if (checkSat.Checked == false && itIsChecked.Equals('1'))
                {
                    strB[5] = '0';
                    fRecurrentDays = strB.ToString();
                    //MessageBox.Show("Saturday is unchecked " + fRecurrentDays);
                }
            } 

        }

        private void checkSun_CheckedChanged(object sender, EventArgs e)
        {
            char itIsChecked = fRecurrentDays[6];
            StringBuilder strB = new StringBuilder(fRecurrentDays);

            if (checkSun.Checked == true && !(itIsChecked.Equals('1')))
            {
                strB[6] = '1';
                fRecurrentDays = strB.ToString();
                //MessageBox.Show("Sunday is checked " + fRecurrentDays);
            }
            else
            {
                if (checkSun.Checked == false && itIsChecked.Equals('1'))
                {
                    strB[6] = '0';
                    fRecurrentDays = strB.ToString();
                    //MessageBox.Show("Sunday is unchecked " + fRecurrentDays);
                }
            } 
        }
        //---------------------------------------------------------------

        //---------------------------------------------------------------
        private void cmbBoxPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            fTaskPriorityInt = Convert.ToInt16(cmbBoxPriority.Text);
            //MessageBox.Show(Convert.ToString(fTaskPriorityInt));
        }
        //---------------------------------------------------------------

        //---------------------------------------------------------------
        //Get the date and time
        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            string d = string.Empty;
            string m = string.Empty;
            string y = string.Empty;
            d = datePicker.Value.Day.ToString();
            m = datePicker.Value.Month.ToString();
            y = datePicker.Value.Year.ToString();
            fTaskDataTimeString = y + "-" + m + "-" + d + " ";
            //MessageBox.Show(d); MessageBox.Show(m); MessageBox.Show(y);
            //MessageBox.Show("The selected value is " + datePicker.Text);
            //MessageBox.Show("The day of the week is " + datePicker.Value.DayOfWeek.ToString());
        }

        private void timePicker_ValueChanged(object sender, EventArgs e)
        {
            fTaskTime = timePicker.Text.ToString();
            //MessageBox.Show(fTaskTime);
        }
        //---------------------------------------------------------------

        //---------------------------------------------------------------
        //Are performed events when you want to write a task description or a task location
        private void textBoxTaskTitle_Enter(object sender, EventArgs e)
        {
            if (textBoxTaskTitle.Text.ToString().Equals("Task description"))
            {
                textBoxTaskTitle.Clear();
            }
            else
            {
                fTaskTitle = textBoxTaskTitle.Text;
                //MessageBox.Show(fTaskTitle);
            }  
        }

        private void labelLocation_Enter(object sender, EventArgs e)
        {
            if (labelLocation.Text.ToString().Equals("Task location"))
            {
                labelLocation.Clear();
            }
            else
            {
                fTaskLocation = labelLocation.Text;
                //MessageBox.Show(fTaskTitle);
            }
        }
        //---------------------------------------------------------------
    }
}
