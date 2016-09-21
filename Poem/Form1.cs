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
/*This program will generate a list of words that rhyme with the word that the user enters 
 *http://stackoverflow.com/questions/23346853/random-sentence-generator-listbox-output
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
            MakeBrain.SendRequestToBrain(seedString, maxResults);

            //this statement stores the string returned from the GetRhymes method to a variable 
            //string displayTree = Brain.GetRhymes(seedString);

            Brain brainClass = new Brain();
            lblDisplayTree.Text = brainClass.word;
            
            
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
