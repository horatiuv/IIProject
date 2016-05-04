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
    public partial class FormDeleteTask : Form
    {
        private DBConnect con;
        int taskID;

        public FormDeleteTask(int id_task)
        {
            InitializeComponent();
            con = new DBConnect("localhost", "plutodb", "root", "");
            this.taskID = id_task;
        }

        private void btnDeleteNO_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteYES_Click(object sender, EventArgs e)
        {
            if (con.OpenConnection() == true)
            {
                string q = "DELETE from tasks WHERE id_tasks = " + taskID;
                MySqlCommand cmd = new MySqlCommand(q, con.connection);
                try
                {
                    cmd.ExecuteNonQuery();
                    //MySqlDataReader myreader1;
                    //myreader1 = cmd.ExecuteReader();
                    //while (myreader1.Read()) { }
                    //MessageBox.Show("Your task have been deleted");
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

            CTask.populateTaskList(Login.h.listViewToday, Login.h.today);
            CTask.populateNextTasksList(Login.h.listViewNext);
            CCategory.populateCategoryList(Login.h.categories);
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
    }
}
