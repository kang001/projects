using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.IO;
using System.Net;
/* Rules of the program:
 * For now, a poem will be 4 lines
 * Figure out how to generate a random sentence 
 * //http://stackoverflow.com/questions/23346853/random-sentence-generator-listbox-output
 * 
*/
namespace Poem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            
            int maxResults = Convert.ToInt32(txtMaxResults.Text); //stores the maxResults textbox
            string seedString = txtSeed.ToString(); //stores the txtSeed text
            lbldisplaySeed.Text = txtSeed.Text; //sets the display label equal to the textbox input

            //this statement uses the Brain's class static method to send these variables 
            Brain.SendRequestToBrain(seedString, maxResults);

            //this statement stores the string returned from the GetRhymes method to a variable 
            string displayTree = Brain.GetRhymes(seedString);
            

            ///*Figure out how to format a very long string
            // * or figure out if I want different sorts of 
            // * outpits for each of the lines
            // * ALSO: figure out general rules for the application
            //*/
            ////test for a program that creates random text 
            //string[] article = { "the", "a", "one", "some", "any", };
            //string[] noun = { "boy", "girl", "dog", "town", "car", };
            //string[] verb = { "drove", "jumped", "ran", "walked", "skipped", };
            //string[] preposition = { "to", "from", "over", "under", "on", };

            ///*Another idea would be to have different types of words
            // * and the random class would pull random types of words from their list
            // * and would string them together to make some sort of sentence structure 
            // * the apis would feed into these lists of the words 
            //*/
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
