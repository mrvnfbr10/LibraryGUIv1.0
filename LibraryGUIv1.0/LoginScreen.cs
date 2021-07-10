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
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            
            if(username.Equals("marvinlouie") && password.Equals("1234")){
            AdminScreen f2 = new AdminScreen();
            f2.Show();
            this.Hide();
            }
            else if(username.Equals("joannamarie") && password.Equals("1234")){
            AdminScreen f2 = new AdminScreen();
            f2.Show();
            this.Hide();
            }
            else if(username.Equals("johnmichael") && password.Equals("1234")){
             AdminScreen f2 = new AdminScreen();
             f2.Show();
             this.Hide();
            }
            else if (username.Equals("melodyangela") && password.Equals("1234"))
            {
                AdminScreen f2 = new AdminScreen();
                f2.Show();
                this.Hide();
            }
            else if (username.Equals("") && password.Equals(""))
            {
                MessageBox.Show("Error. Please enter correct username and password");

            }
            
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
