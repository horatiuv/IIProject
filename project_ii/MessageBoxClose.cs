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
    public partial class MessageBoxClose : Form
    {
        public delegate void ClickButton();
        public event ClickButton ButtonYESWasClicked;
        public event ClickButton ButtonNOWasClicked;

        public MessageBoxClose()
        {
            InitializeComponent();
            ControlBox = false;
        }

        private void btnDeleteYES_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnDeleteNO_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
