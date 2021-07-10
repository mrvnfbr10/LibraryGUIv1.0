using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace LibraryGUIv1._0
{
    public partial class SearchScreen : Form
    {
        public SearchScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminScreen f2 = new AdminScreen();
            f2.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Equals(""))
                    MessageBox.Show("Enter an item. Try Again!");
                else
                {
                    for (int r = 0; r < 35; r++)
                        for (int c = 0; c < 3; c++)
                            //dataGridView1.Add("", r, c);
                    ;

                    StreamReader rdfile = new StreamReader ("Books.txt");
                    String[] line = new String[35];
                    String search = "", target = "";

                    Boolean same = false, found = false;

                    int x = 0, row = 0;
                    while ((line[x] = rdfile.ReadLine()) != null)
                        x++;

                    rdfile.Close();

                    search = textBox1.Text;

                    for (int k = 0; line[k] != null; k++)
                    {
                        same = false;
                        target = "";
                        for (int j = 0; j < search.Length; j++)
                            target += line[k][j];
                            

                        if (search.Equals(target))
                            same = true;

                        if (same)
                        {
                            String[] separators = { "\t" };
                            String[] temp = line[k].Split(separators, StringSplitOptions.RemoveEmptyEntries);
                            for (int i = 0; i < 1; i++)
                                dataGridView1.Rows.Add(temp[0], temp[3], temp[4]);
                            //dataGridView1.Rows.Add(temp[3], row, 1);
                            //dataGridView1.Rows.Add(temp[4], row, 2);
                            row++;
                            found = true;
                        }
                    }

                    if (!found)
                        MessageBox.Show("Item(s) not found! Please Try Again!");

                    textBox1.Text=("");
                }
            }
            catch (IOException ex) 
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
