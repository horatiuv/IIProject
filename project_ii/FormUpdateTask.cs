using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Project_II
{
    public partial class FormUpdateTask : Form
    {
        //Connection to the db
        private DBConnect con;
        //Declare the variables which will be used to update the information in database
        private string fTaskTitle;
        private int fTaskPriorityInt;
        private string fTaskDataTimeString;
        private string fTaskLocation;
        private string fRecurrentDays = "0000000";
        private int userID;
        private int taskID;
        //private int fTaskIDCategory;
        //private int fTaskDone = 0;
        //Declare auxiliary variables that will help to construct the above variables
        //private string fCategory;
        private string fTaskTime;

        public FormUpdateTask(int user_ID, int task_ID)
        {
            InitializeComponent();
            con = new DBConnect("localhost", "plutodb", "root", "");
            this.userID = user_ID;
            this.taskID = task_ID;
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
            //datePicker.MinDate = DateTime.Now;
            ////////////////////////////////////////////////////////////
            //Populate the form with the task's information according to the task_ID
            if (con.OpenConnection() == true)
            {
                MySqlCommand cmd = con.connection.CreateCommand();
                //Select the proper task's information
                cmd.CommandText = "SELECT * FROM tasks WHERE id_tasks = @task_ID LIMIT 1";
                cmd.Parameters.AddWithValue("@task_ID", this.taskID);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                string uIdTask = string.Empty;
                string uIdCategory = string.Empty;
                string uTaskName = string.Empty;
                string uDeadline = string.Empty;
                string uLocation = string.Empty;
                string uRec_Days = string.Empty;
                string uPriority = string.Empty;
                string uNameCategory = string.Empty;

                while (dataReader.Read())
                {
                    uIdTask = dataReader["id_tasks"].ToString();
                    //MessageBox.Show(uIdTask);
                    uIdCategory = dataReader["categories_id_category"].ToString();
                    // MessageBox.Show(uIdCategory);
                    uTaskName = dataReader["task_name"].ToString();
                    //MessageBox.Show(uTaskName);
                    uDeadline = dataReader["deadline"].ToString();
                    //MessageBox.Show(uDeadline);
                    uLocation = dataReader["location"].ToString();
                    //MessageBox.Show(uLocation);
                    uRec_Days = dataReader["rec_days"].ToString();
                    //MessageBox.Show(uRec_Days);
                    uPriority = dataReader["task_priority"].ToString();
                    //MessageBox.Show(uPriority);                     
                }
                dataReader.Close();

                cmd.CommandText = "SELECT category_name FROM categories WHERE id_category = @category_ID";
                cmd.Parameters.AddWithValue("category_ID", int.Parse(uIdCategory));
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    uNameCategory = dataReader.GetString(0);
                }
                //MessageBox.Show(uNameCategory);
                dataReader.Close();

                //Make the data proper for dateTimePicker
                DateTime dt = Convert.ToDateTime(uDeadline);
                datePicker.Value = new DateTime(Convert.ToInt32(dt.Year), Convert.ToInt32(dt.Month), Convert.ToInt32(dt.Day));
                timePicker.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Convert.ToInt32(dt.Hour), Convert.ToInt32(dt.Minute), Convert.ToInt32(dt.Second));

                //Populate the controls
                comboBoxChooseCategory.Text = uNameCategory;
                textBoxTaskTitle.Text = uTaskName.ToString();
                labelLocation.Text = uLocation.ToString();
                cmbBoxPriority.Text = uPriority.ToString();

                fRecurrentDays = uRec_Days;

                check_Days(uRec_Days[0], checkMon);
                check_Days(uRec_Days[1], checkTue);
                check_Days(uRec_Days[2], checkWed);
                check_Days(uRec_Days[3], checkThu);
                check_Days(uRec_Days[4], checkFri);
                check_Days(uRec_Days[5], checkSat);
                check_Days(uRec_Days[6], checkSun);
                con.CloseConnection();
            }
            else
            {
                string errorMessage = "Database can't be opened!";
                MessageBox.Show(errorMessage);
            }

            //Populate cmbBoxPriorities with the priorities
            string[] priorities = new string[3] { "1", "2", "3" };
            foreach (var item in priorities)
            {
                cmbBoxPriority.Items.Add(item);
            }
        }

        //This function is used to check the checkBoxes
        private void check_Days(char day, CheckBox check_Box)
        {
            if (day == '1')
            {
                check_Box.Checked = true;
            }
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

        private void FormAddTask_DoubleClick(object sender, EventArgs e)
        {
            //return;
            this.SetStyle(ControlStyles.StandardDoubleClick, false);
            this.SetStyle(ControlStyles.StandardDoubleClick, false);
            this.Enabled = false;
            this.Location = new Point(10, 10);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Check if all the fields are completed with the proper informations 
            //bool category = false;
            //bool location = false;
            bool description = false;
            bool priority = false;
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

            fTaskPriorityInt = priorityValue;

            if (textBoxTaskTitle.Text.ToString().Equals("Task description") || textBoxTaskTitle.Text.ToString().Equals(String.Empty))
            {
                description = true;
            }
            if (cmbBoxPriority.Text.ToString().Equals("Priorities") || priorityValue < 1 || priorityValue > 3)
            {
                priority = true;
            }

            //If at least one field is not good, a message box will appear
            //otherwise, the informations will be inserted in the database
            if (description && priority)
            {
                MessageBox.Show(" Give a name to your task ! \nChoose a priority between 1 and 3 !");
            }
            else
            {
                if (description)
                {
                    MessageBox.Show(" Give a name to your task !");
                }
                else
                {
                    if (priority)
                    {
                        MessageBox.Show("Choose a priority between 1 and 3 !");
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
                            string q = "Update tasks SET task_name = '" + fTaskTitle + "',task_priority = '" + fTaskPriorityInt + "',deadline = '" + fTaskDataTimeString + "',location = '" + fTaskLocation + "',rec_days = '" + fRecurrentDays + "' WHERE id_tasks = " + taskID;
                            MySqlCommand cmd = new MySqlCommand(q, con.connection);
                            try
                            {
                                cmd.ExecuteNonQuery();
                                //MySqlDataReader myreader1;
                                //myreader1 = cmd.ExecuteReader();
                                //while (myreader1.Read()) { }
                                MessageBox.Show("Now, Pluto knows about your updated task!\nDon't forget about it! Because he wouldn't :)");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                            finally { }

                            //close connection
                            con.CloseConnection();
                        }
                        else
                        {
                            MessageBox.Show("Database can't be opened");
                        }
                        this.Close();
                        //con.CloseConnection();
                    }
                }
            }

            //write the number of tasks for today
            int todayTasks = CTask.countTodayTasks();
            Login.h.btnToday.Text = "Today(" + todayTasks + ")";

            //update task lists
            CTask.populateTaskList(Login.h.listViewToday, Login.h.today);
            CTask.populateNextTasksList(Login.h.listViewNext);
            CCategory.populateCategoryList(Login.h.categories);
        }
    }
}


