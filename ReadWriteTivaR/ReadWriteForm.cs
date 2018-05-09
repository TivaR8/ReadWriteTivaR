using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by: Tiva rait
 * Created on: 9-05-2017 <3
 * Created for: ICS3U Programming
 * Daily Assignment – Day #37 - File Read/Write
 * This program...
*/


namespace ReadWriteTivaR
{
    public partial class frmReadWrite : Form
    {
        public frmReadWrite()
        {
            InitializeComponent();
            this.lblConfirmOutput.Hide();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Read each line of the file into a string array. Each element...
            // ... of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines("@input.txt");

            // array of characters that I want to take out when I split the line into words
            char[] charSeparators = new char[] { ' ', '\t' };

            // The output string where I will put my results 
            string output = "";

            // Go through and compare each string on each line of the file
            foreach (string line in lines)
            {
                // Split each line into words and put them into an array. I am assuming...
                //... there are only two words on the line.
                string[] words = line.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);

                if  (StringsAreEqual(words[0], words[1]) == true)
                {
                    // Concatenate the output to the string. There must be \r\ so that...
                    //...  it goes onto a new line in the text file
                    output = output + "True\r\n";
                }
                else
                {
                    // Concatenate the output to the string. There must be \r\n so...
                    // .. that it goes onto a new line in the text file.
                    output = output + "False\r\n";
                }
            }

            // WriteAllText Creates a file, writes the specified string to the file
            // if file already exists it overwrites the file.
            System.IO.File.WriteAllText("@output.txt", output);

            // Show the label notifying the users that the process is complete
            this.lblConfirmOutput.Show();
        }
    }
}
