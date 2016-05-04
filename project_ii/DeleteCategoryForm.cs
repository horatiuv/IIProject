using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Project_II
{
    public partial class DeleteCategoryForm : Form
    {
        //private DBConnect con;

        public DeleteCategoryForm()
        {
            InitializeComponent();
            //con = new DBConnect("localhost", "plutodb", "root", "");
        }

        private void btnDeleteNO_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteYES_Click(object sender, EventArgs e)
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
                    //DialogResult resultTasksDelete = MessageBox.Show("Are you sure you want to delete the category and all it's tasks?", "Confirmation", MessageBoxButtons.YesNo);
                    //if (resultTasksDelete == DialogResult.Yes)
                    //{
                        con.CloseConnection();
                        con.OpenConnection();

                        //delete tasks from category
                        MySqlCommand cmdDeleteTasks = con.connection.CreateCommand();
                        cmdDeleteTasks.CommandText = "DELETE FROM tasks WHERE categories_id_category = @id_cat";
                        cmdDeleteTasks.Parameters.AddWithValue("@id_cat", Home.id_category);
                        cmdDeleteTasks.ExecuteNonQuery();

                        con.CloseConnection();
                        con.OpenConnection();

                        //create command to delete category
                        MySqlCommand cmd = con.connection.CreateCommand();
                        cmd.CommandText = "DELETE FROM categories WHERE id_category = @id_cat";
                        cmd.Parameters.AddWithValue("@id_cat", Home.id_category);

                        cmd.ExecuteNonQuery();
                    //}
                }
            }
            CCategory.populateCategoryList(Login.h.categories);
            CTask.populateTaskList(Login.h.listViewToday, Login.h.today);
            CTask.populateNextTasksList(Login.h.listViewNext);

            con.CloseConnection();
            this.Close();
        }
    }
}