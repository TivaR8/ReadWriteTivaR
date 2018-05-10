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
 * This program reads a text file and puts them into an ...
 * ...array for each line there are two words and it...
 * ...checks to see if the words are equal. It then outputs...
 * ...a file that has gone through each line of code and has...
 * ...written true or false depending on if the two words in each...
 * ...line are the same.
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

        // Procedure: StringsAreEqual
        // Input: stringOne and stringTwo
        // Output: bool isEqual
        // Description: It checks to see if the strings are equal in length...
        // ... and when they are both capitalized
        private bool StringsAreEqual(string wordOne, string wordTwo)
        {
            // Declare local Variables
            bool isEqual = false;
            string upcaseWordOne, upcaseWordTwo;

            // To find their length
            if (wordOne.Length == wordTwo.Length)
            {
                // Convert the strings to upper case and then compare them
                upcaseWordOne = wordOne.ToUpper();
                upcaseWordTwo = wordTwo.ToUpper();

                // See if they are the same still
                if (upcaseWordOne == upcaseWordTwo)
                {
                    // If they are the same set the boolean to true
                    isEqual = true;
                }

            }


            return isEqual;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Read each line of the file into a string array. Each element...
            // ... of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(@"input.txt");

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
