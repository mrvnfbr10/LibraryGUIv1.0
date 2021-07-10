using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace LibraryGUIv1._0
{
    public partial class UpdateScreen : Form
    {
        public UpdateScreen()
        {
            InitializeComponent();
        }

        private void UpdateScreen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminScreen f1 = new AdminScreen();
            f1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try {
                for (int r = 0; r < 35; r++) { 
                    for (int c = 0; c < 5; c++) { 
                        //dataGridView1.Rows.Add(null, r, c);
                            ;
                    }
                }

                StreamReader rdfile = new StreamReader ("Books.txt");

                String[] book = new String[35];
                

                int x = 0;
                while ((book[x] = rdfile.ReadLine()) != null) {
                    String[] separators = { "\t" };
                    String[] temp = book[x].Split(separators, StringSplitOptions.RemoveEmptyEntries);
               
                    for (int j = 0; j < 1; j++) {
                        dataGridView1.Rows.Add(temp[0], temp[1], temp[2], temp[3], temp[4]);
                            
                            
                    }

                    x++;
                }
                rdfile.Close();

            } 
                
                catch (IOException ex)
                 {


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
            if (textBox1.Text.Equals(""))
            MessageBox.Show("Enter item! Please Try Again");
            else {
                StreamReader rdfile = new StreamReader ("Books.txt");

                String[] book = new String[35];
                
                String delete = textBox1.Text;
                Boolean found = false;

                int x = 0;
                while ((book[x] = rdfile.ReadLine()) != null) {
                    String[] separators = { "\t" };
                    String[] temp = book[x].Split(separators, StringSplitOptions.RemoveEmptyEntries);
                  

                    if (delete.Equals(temp[0])) {
                        x = x + 0;
                        found = true;
                    } else
                    x++;

                }

                rdfile.Close();

                StreamWriter write = new StreamWriter("Books.txt");              
                for (int j = 0; book[j] != null; j++)
                write.WriteLine(book[j]);

                write.Close();

                if (!found)
                MessageBox.Show("Book is already not in the list!");
                else
                MessageBox.Show("Succesfully Deleted!");
                textBox1.Text="";

            }
        }
         catch (IOException ex) {}

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            try{
            if( textBox2.Text.Equals(""))
                MessageBox.Show("Enter item! Please Try Again");
           
            else{
                StreamReader rdfile= new StreamReader("Books.txt");

                String[] itemline= new String[35];
                //String temp[];
                int x = 0;
                String search= "Not Available";
                String target= textBox2.Text;
                Boolean found= false;
                if( (!(target.Equals(""))) ){
                    while(( itemline[x]= rdfile.ReadLine()) != null){
                    String[] separators = { "\t" };
                    String[] temp = itemline[x].Split(separators, StringSplitOptions.RemoveEmptyEntries);
                        //temp= itemline[x].split("\t");
                        temp[4] = search;
                        if(target.Equals( temp[0])){
                            itemline[x]= temp[0]+"\t"+temp[1]+"\t"+temp[2]+"\t"+temp[3]+"\t"+temp[4];
                            found= true;
                        }
                        x++;


                    }
                    rdfile.Close();

                    if( found ){
                        StreamWriter wrfile= new StreamWriter("Books.txt");

                        for( int j=0; itemline[j] != null; j++)
                            wrfile.WriteLine( itemline[j]);

                        wrfile.Close();

                        MessageBox.Show("Book has been borrowed!");
                    } else
                        MessageBox.Show("Item Not Found!");
                    textBox2.Text="";
                    
                    } else
                    MessageBox.Show("No Changes Yet!");
            }
                
        }catch(IOException ex){ 
            textBox2.Text="";
        }
                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try{
            if( textBox3.Text.Equals(""))
                MessageBox.Show("Enter item! Please Try Again");
           
            else{
                StreamReader rdfile= new StreamReader("Books.txt");

                String[] book = new String[35];
                
                int x = 0;
                String search= "Available";
                String target= textBox3.Text;
                Boolean found= false;
                if( (!(target.Equals(""))) ){
                    while(( book[x]= rdfile.ReadLine()) != null){
                        String[] separators = { "\t" };
                        String[] temp = book[x].Split(separators, StringSplitOptions.RemoveEmptyEntries);
                        temp[4] = search;
                        if(target.Equals( temp[0])){
                            book[x]= temp[0]+"\t"+temp[1]+"\t"+temp[2]+"\t"+temp[3]+"\t"+temp[4];
                            found= true;
                        }
                        x++;


                    }
                    rdfile.Close();

                    if( found ){
                        StreamWriter wrfile= new StreamWriter("Books.txt");

                        for( int j=0; book[j] != null; j++)
                            wrfile.WriteLine(book[j]);

                        wrfile.Close();

                        MessageBox.Show("Book Returned! Book is now available for borrow.");
                    } else
                        MessageBox.Show("Item Not Found!");
                    textBox3.Text="";
                    
                    } else
                    MessageBox.Show( "No Changes Yet!");
            }
                
        }catch(IOException ex){

            textBox3.Text="";

                }

            }


        


    }
}
