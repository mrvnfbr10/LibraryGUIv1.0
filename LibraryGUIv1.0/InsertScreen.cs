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
    public partial class InsertScreen : Form
    {
        public InsertScreen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminScreen f2 = new AdminScreen();
            f2.Show();
            this.Hide();
        }
        /**public static class SequentialNumber
        {
            private static int _currentNumber = 0;
            public static string GetNextNumber()
            {
                _currentNumber++;
                return "100" + _currentNumber.ToString();
            }
        }
            **/
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBox1.Text.Equals(""))
                {
                    MessageBox.Show("Title Field should not be empty.");

                }
                else
                {
                    StreamReader file = new StreamReader("Books.txt");

                    String[] book = new String[35];
                    String title = "";
                    String author = "";
                    String genre = "";
                    String ISBN = "";
                    String status = "Available";
                    Boolean found = false;

                    int i = 0;
                    while ((book[i] = file.ReadLine()) != null)
                    {
                        i++;
                    }
                    file.Close();

                    if (!(i >= 35))
                    {
                        title = textBox1.Text;
                        author = textBox2.Text;

                        for (int a = 0; book[a] != null; a++)
                        {
                            String[] separators = { "\t" };
                            String[] temp = book[a].Split(separators, StringSplitOptions.RemoveEmptyEntries);

                            if (title.Equals(temp[0]) && author.Equals(temp[1]))
                            {
                                found = true;
                            }
                        }
                        if (found)
                        {
                            MessageBox.Show("Book already in list.");
                        }
                        else
                        {
                            //textBox4.Text = SequentialNumber.GetNextNumber();
                            genre = textBox3.Text;
                            ISBN = textBox4.Text;

                            book[i] = title + "\t" + author + "\t" + genre + "\t" + ISBN + "\t" + status;
                            StreamWriter write = new StreamWriter("Books.txt");

                            for (int b = 0; book[b] != null; b++)
                            {
                                write.WriteLine(book[b]);
                            }
                            write.Close();

                            MessageBox.Show("Succesfully Inserted");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Book is Full");
                    }
                }

                textBox1.Text = ("");
                textBox2.Text = ("");
                textBox3.Text = ("");
                textBox4.Text = ("");



            }
            catch (Exception ex)
            {
                MessageBox.Show("Please try again.");
                textBox1.Text = ("");
                textBox2.Text = ("");
                textBox3.Text = ("");
                textBox4.Text = ("");
            }
          

           
    }                                        
            

        }


    }


