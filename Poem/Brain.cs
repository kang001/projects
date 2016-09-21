using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poem
{
    class Brain
    {
        private string word;
        private int syllables;

        public Brain() { }

        public Brain(string word, int syllables)
        {
            this.getWord = word;
            this.getSyllables = syllables; 
        }

        public string getWord
        {
            get
            {
                return word;
            }
            set
            {
                word = value;
            }
        }
        public int getSyllables
        {
            get
            {
                return syllables;
            }
            set
            {
                syllables = value;
            }
        }
        public string GetDisplayText(string sep)
        {
            return word.ToString("c") + sep + syllables; 
        }
    }
}
