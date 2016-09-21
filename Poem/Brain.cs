using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

//insteall Newtonsoft.Json package
namespace Poem
{
    class Brain
    {
        MakeBrain newBrain = new MakeBrain();

        public Brain(string jsonWeHope)
        {
            JObject jObject = JObject.Parse(jsonWeHope);
            JToken jBrain = jObject["brain"];
            word = (string)jBrain["word"];
            freq = (int)jBrain["freq"];
            score = (int)jBrain["score"];
            flags = (string)jBrain["flags"];
            syllables = (string)jBrain["syllables"];
        }

        public string word { get; set; }
        public int freq { get; set; }
        public int score { get; set; }
        public string flags { get; set; }
        public string syllables { get; set; }

        public Brain() { }

        public override string ToString()
        {
            return word + freq + score + flags + syllables; 
        }

        public static string GetRhymes(string seedString, List<Brain> brainList)
        {
            for (int x = 0; x < brainList.Count; x++)
            {
                Console.Write("Brain Object" + x);
                Console.WriteLine(brainList[x]); 
                
            }
            return seedString;

        }
        
        
        
    }
}
