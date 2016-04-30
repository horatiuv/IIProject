using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_II
{
    class CTask
    {
        int m_idTask;
        string m_taskName;
        int m_taskPriority;
        DateTime m_deadline;
        int m_usersIdUser;
        int m_categoriesIdcategory;
        bool m_done;


        CTask(int f_idTask, string f_taskName, int f_taskPriority, DateTime f_deadline, int f_usersIdUser, int f_categoriesIdcategory, bool f_done)
        {
            m_idTask = f_idTask;
            m_taskName = f_taskName;
            m_taskPriority = f_taskPriority;
            m_deadline = f_deadline;
            m_usersIdUser = f_usersIdUser;
            m_categoriesIdcategory = f_categoriesIdcategory;
            m_done = f_done;
        }

        public static void populateTaskList(System.Windows.Forms.ListView f_todayTasks, System.Windows.Forms.Label f_today)
        {


            f_todayTasks.Items.Clear();

            //reset the label with Today
            f_today.Text = "Today";

            //try to open the database
            DBConnect con; //connection to the db
            con = new DBConnect("localhost", "plutodb", "root", "");
            //try to open the connection to db
            if (con.OpenConnection() == true)
            {
                //create command
                MySqlCommand cmd = con.connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM tasks WHERE users_id_user = ?id_user AND done=0";
                cmd.Parameters.AddWithValue("?id_user", Login.user_class.getUserId().ToString());

                //Create a data reader and execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        //verify if the task is from today
                        if (DateTime.Parse(dataReader["deadline"].ToString()).Date == DateTime.Now.Date)
                        {
                            string descriptionDB = dataReader["task_name"].ToString();
                            string deadlineDB = dataReader["deadline"].ToString();
                            f_todayTasks.View = View.Details; // Enables Details view so you can see columns

                            ListViewItem item = new ListViewItem();

                            item.SubItems.Add(descriptionDB);
                            item.SubItems.Add("location unknown");
                            item.SubItems.Add(deadlineDB);
                            item.SubItems.Add("undone");
                            item.ImageIndex = 0;

                            f_todayTasks.Items.Add(item);
                        }
                    }
                }
            }
            f_todayTasks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            f_todayTasks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            con.CloseConnection();
        }

        public static void populateNextTasksList(System.Windows.Forms.ListView f_nextTasks)
        {
            f_nextTasks.Items.Clear();

            //try to open the database
            DBConnect con; //connection to the db
            con = new DBConnect("localhost", "plutodb", "root", "");
            //try to open the connection to db
            if (con.OpenConnection() == true)
            {
                //create command
                MySqlCommand cmd = con.connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM tasks WHERE users_id_user = ?id_user AND done=0";
                cmd.Parameters.AddWithValue("?id_user", Login.user_class.getUserId().ToString());

                //Create a data reader and execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        //verify if the task is from today
                        if (DateTime.Parse(dataReader["deadline"].ToString()).Date >= DateTime.Now.Date)
                        {
                            string descriptionDB = dataReader["task_name"].ToString();
                            string deadlineDB = dataReader["deadline"].ToString();
                            f_nextTasks.View = View.Details; // Enables Details view so you can see columns

                            ListViewItem item = new ListViewItem();

                            item.SubItems.Add(descriptionDB);
                            item.SubItems.Add("location unknown");
                            item.SubItems.Add(deadlineDB);
                            item.SubItems.Add("undone");
                            item.ImageIndex = 0;

                            f_nextTasks.Items.Add(item);
                        }
                    }
                }
            }

            f_nextTasks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            f_nextTasks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            con.CloseConnection();
        }

        public static int countTodayTasks()
        {

            int taskCounter = 0;

            //try to open the database
            DBConnect con; //connection to the db
            con = new DBConnect("localhost", "plutodb", "root", "");
            //try to open the connection to db
            if (con.OpenConnection() == true)
            {
                //create command
                MySqlCommand cmd = con.connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM tasks WHERE users_id_user = ?id_user AND done=0";
                cmd.Parameters.AddWithValue("?id_user", Login.user_class.getUserId().ToString());

                //Create a data reader and execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        //verify if the task is from today
                        if (DateTime.Parse(dataReader["deadline"].ToString()).Date == DateTime.Now.Date)
                        {
                            taskCounter++;
                        }
                    }
                }


            }
            con.CloseConnection();

            return taskCounter;
        }


        public static void doneTask(System.Windows.Forms.ListView f_listView)
        {

            string taskName = f_listView.SelectedItems[0].SubItems[1].Text;
            bool taskDoneDB=false;;

            //try to open the database
            DBConnect con; //connection to the db
            con = new DBConnect("localhost", "plutodb", "root", "");
            con.OpenConnection();

            //create command
            MySqlCommand cmdDone = con.connection.CreateCommand();
            cmdDone.CommandText = "SELECT * FROM tasks WHERE users_id_user = ?id_user AND task_name = ?task_nm";
            cmdDone.Parameters.AddWithValue("?id_user", Login.user_class.getUserId().ToString());
            cmdDone.Parameters.AddWithValue("?task_nm", taskName);
            MySqlDataReader dataReader = cmdDone.ExecuteReader();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    //verify if the task is done
                    taskDoneDB = Convert.ToBoolean(dataReader["done"]);
                }
            }
            con.CloseConnection();

            DialogResult resultTasksDelete;
            if(taskDoneDB==false)
            {
                resultTasksDelete = MessageBox.Show("Task is done? ", "Confirmation", MessageBoxButtons.YesNo);
            }
            else
            {
                resultTasksDelete = MessageBox.Show("Do you want to undo task? ", "Confirmation", MessageBoxButtons.YesNo);
            }
           
            if (resultTasksDelete == DialogResult.Yes)
            {

                //try to open the connection to db
                if (con.OpenConnection() == true)
                {
                    //create command
                    MySqlCommand cmd = con.connection.CreateCommand();
                    cmd.CommandText = "UPDATE tasks SET done = ?done WHERE task_name = ?task_name";
                    cmd.Parameters.AddWithValue("?task_name", taskName);
                    cmd.Parameters.AddWithValue("?done", !taskDoneDB);

                    cmd.ExecuteNonQuery();

                }
            }
            con.CloseConnection();

            //write the number of tasks for today
            int todayTasks = CTask.countTodayTasks();
            Login.h.btnToday.Text = "Today(" + todayTasks + ")";

            //update task lists
            populateTaskList(Login.h.listViewToday, Login.h.today);
            populateNextTasksList(Login.h.listViewNext);
            CCategory.populateCategoryList(Login.h.categories);



        }

    }
}
