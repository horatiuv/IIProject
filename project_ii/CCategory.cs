using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_II
{
    class CCategory
    {
        int m_idCategory;
        string m_categoryName;
        string m_categoryColor;
        int m_usersIdUsers;

        CCategory(int f_idCategory, string f_categoryName, string f_categoryColor, int f_usersIdUsers)
        {
            m_idCategory = f_idCategory;
            m_categoryName = f_categoryName;
            m_categoryColor = f_categoryColor;
            m_usersIdUsers = f_usersIdUsers;
        }


        public static void populateCategoryList(System.Windows.Forms.ListBox f_categories)
        {
            //empty the category list
            f_categories.Items.Clear();

            //try to open the database
            DBConnect con; //connection to the db
            con = new DBConnect("localhost", "plutodb", "root", "");
            //try to open the connection to db
            if (con.OpenConnection() == true)
            {
                //create command
                MySqlCommand cmd = con.connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM categories WHERE users_id_user = ?id_user";
                cmd.Parameters.AddWithValue("id_user", Login.user_class.getUserId());

                //Create a data reader and execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        string categoryNameDB = dataReader["category_name"].ToString();
                        int categoryIdDB = int.Parse(dataReader["id_category"].ToString());

                        //try to open the database
                        DBConnect con2; //connection to the db
                        con2 = new DBConnect("localhost", "plutodb", "root", "");
                        //create command
                        if (con2.OpenConnection() == true)
                        {
                            MySqlCommand cmd2 = con2.connection.CreateCommand();

                            cmd2.CommandText = "SELECT * FROM tasks WHERE users_id_user = ?id_user AND categories_id_category =?id_category";
                            cmd2.Parameters.AddWithValue("?id_user", Login.user_class.getUserId().ToString());
                            cmd2.Parameters.AddWithValue("?id_category", categoryIdDB);

                            //Create a data reader and execute the command
                            MySqlDataReader taskReader = cmd2.ExecuteReader();

                            //verify how many tasks are in each category
                            int taskCounter = 0;
                            if (taskReader.HasRows)
                            {
                                while (taskReader.Read())
                                {
                                    taskCounter++;
                                }
                            }
                            f_categories.Items.Add(categoryNameDB + "(" + taskCounter + ")");
                        }
                        con2.CloseConnection();
                    }

                }
                con.CloseConnection();
            }
        }

        public static void populateTasksFromCategory(System.Windows.Forms.ListView f_categoryTasks, int f_categoryId)
        {
            f_categoryTasks.Items.Clear();

            //try to open the database
            DBConnect con; //connection to the db
            con = new DBConnect("localhost", "plutodb", "root", "");
            //try to open the connection to db
            if (con.OpenConnection() == true)
            {
                //create command
                MySqlCommand cmd = con.connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM tasks WHERE users_id_user = ?id_user AND categories_id_category =?category_id";
                cmd.Parameters.AddWithValue("?id_user", Login.user_class.getUserId().ToString());
                cmd.Parameters.AddWithValue("?category_id", f_categoryId);

                //Create a data reader and execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        string taskNameDB = dataReader["task_name"].ToString();
                        string deadlineDB = dataReader["deadline"].ToString();
                        bool doneDB = Convert.ToBoolean(dataReader["done"]);
                        
                        f_categoryTasks.View = View.Details; // Enables Details view so you can see columns
                        ListViewItem item = new ListViewItem();

                        item.SubItems.Add(taskNameDB);
                        item.SubItems.Add("location unknown");
                        item.SubItems.Add(deadlineDB);
                        if(doneDB == true)
                        {
                            item.SubItems.Add("done");
                            item.ImageIndex = 1;
                        }
                        else
                        {
                            item.SubItems.Add("undone");
                            item.ImageIndex = 0;
                        }

                        

                        f_categoryTasks.Items.Add(item);
                    }
                }
            }
            con.CloseConnection();

            f_categoryTasks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            f_categoryTasks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }


        public static void createNewCategory(string f_categoryName)
        {
            //try to open the database
            DBConnect con; //connection to the db
            con = new DBConnect("localhost", "plutodb", "root", "");
            //try to open the connection to db
            if (con.OpenConnection() == true)
            {
                //create command
                MySqlCommand cmd = con.connection.CreateCommand();
                cmd.CommandText = "INSERT INTO categories (category_name, category_color, users_id_user) VALUES (?cat_name, ?none, ?id_user)";
                cmd.Parameters.AddWithValue("?id_user", Login.user_class.getUserId().ToString());
                cmd.Parameters.AddWithValue("?cat_name", f_categoryName);
                cmd.Parameters.AddWithValue("?none", "none");

                //Create a data reader and execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                con.CloseConnection();
            }
            MessageBox.Show("Category " + f_categoryName + " added!");
            
            //Home h = new Home();
            Login.h.newCategory.Text = "Add new category...";
            populateCategoryList(Login.h.categories);
        }


        public static int getCategoryId(string f_categoryName)
        {
            int l_categoryId = 0;

            //try to open the database
            DBConnect con; //connection to the db
            con = new DBConnect("localhost", "plutodb", "root", "");
            //try to open the connection to db
            if (con.OpenConnection() == true)
            {
                //create command
                MySqlCommand cmd = con.connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM categories WHERE category_name = ?cat_name";
                cmd.Parameters.AddWithValue("?cat_name", f_categoryName);

                //Create a data reader and execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        l_categoryId = int.Parse(dataReader["id_category"].ToString());
                    }
                }
                con.CloseConnection();
            }
            return l_categoryId;
        }
    }
}
