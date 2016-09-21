using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Poem
{
    class Brain
    {
        public string word { get; set; }
        public int freq { get; set; }
        public int score { get; set; }
        public string flags { get; set; }
        public string syllables { get; set; }

        public Brain() { }

        public Brain(string word, int syllables)
        {
            this.getWord = word;
            this.getSyllables = syllables; 
        }

        
        
        public string GetDisplayText(string sep)
        {
            return word.ToString() + sep + syllables; 
        }
    }
}
