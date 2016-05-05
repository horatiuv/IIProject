using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Project_II
{
    class CNote
    {
        

        public static void populateNotesList(System.Windows.Forms.ListView f_notes)
        {
            f_notes.Items.Clear();
            //try to open the database
            DBConnect con; //connection to the db
            con = new DBConnect("localhost", "plutodb", "root", "");
            //try to open the connection to db
            if (con.OpenConnection() == true)
            {
                //create command
                MySqlCommand cmd = con.connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM notes WHERE users_id_user = ?id_user AND done=0";
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
                            f_notes.View = System.Windows.Forms.View.Details; // Enables Details view so you can see columns

                           
                        }
                    }
                }
            }
           // f_todayTasks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
           // f_todayTasks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            con.CloseConnection();
        }
    }
}
