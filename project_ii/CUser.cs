using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_II
{

    public class CUser
    {
        int m_idUser;
        string m_typeUser;
        string m_username;
        string m_password;
        string m_email;

        public CUser(int f_idUser, string f_typeUser, string f_username, string f_password, string f_email)
        {
            m_idUser = f_idUser;
            m_typeUser = f_typeUser;
            m_password = f_password;
            m_username = f_username;
            m_email = f_email;
        }

        public int getUserId()
        {
            return m_idUser;
        }

        public string getUsername()
        {
            return m_username;
        }

        public void setUsername(string input)
        {
            this.m_username = input;
        }

        public string getEmail()
        {
            return m_email;
        }

        public void setEmail(string input)
        {
            this.m_email = input;
        }


    }
}
