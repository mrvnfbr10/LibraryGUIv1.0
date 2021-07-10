using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryGUIv1._0
{
    public partial class AdminScreen : Form
    {
        public AdminScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertScreen f3 = new InsertScreen();
            f3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginScreen f1 = new LoginScreen();
            f1.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchScreen ss = new SearchScreen();
            ss.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateScreen us = new UpdateScreen();
            us.Show();
            this.Hide();


        }
    }
}
