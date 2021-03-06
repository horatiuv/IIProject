﻿using MySql.Data.MySqlClient;
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
    public partial class UpdateCategoryForm : Form
    {
        public UpdateCategoryForm()
        {
            InitializeComponent();
        }
/*
        private void update_Click(object sender, EventArgs e)
        {
            DBConnect con; //connection to the db
            con = new DBConnect("localhost", "plutodb", "root", "");
            //try to open the connection to db
            if (con.OpenConnection() == true)
            {
                //create command
                MySqlCommand cmd = con.connection.CreateCommand();
                cmd.CommandText = "UPDATE categories SET category_name = @cat_name, category_color = @cat_color WHERE id_category = @id_cat";
                cmd.Parameters.AddWithValue("@cat_name", categ_name.Text);
                cmd.Parameters.AddWithValue("@cat_color", categ_color.Text);
                cmd.Parameters.AddWithValue("@id_cat", Home.id_category);

                cmd.ExecuteNonQuery();
            }

            CCategory.populateCategoryList(Login.h.categories);
            con.CloseConnection();
            this.Close();
        }
*/
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

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            DBConnect con; //connection to the db
            con = new DBConnect("localhost", "plutodb", "root", "");
            //try to open the connection to db
            if (con.OpenConnection() == true)
            {
                //create command
                MySqlCommand cmd = con.connection.CreateCommand();
                cmd.CommandText = "UPDATE categories SET category_name = @cat_name, category_color = @cat_color WHERE id_category = @id_cat";
                cmd.Parameters.AddWithValue("@cat_name", categ_name.Text);
                cmd.Parameters.AddWithValue("@cat_color", categ_color.Text);
                cmd.Parameters.AddWithValue("@id_cat", Home.id_category);

                cmd.ExecuteNonQuery();
            }

            CCategory.populateCategoryList(Login.h.categories);
            con.CloseConnection();
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        //---------------------------------------------------------------
    }
}
