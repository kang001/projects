using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;

//insteall Newtonsoft.Json package
namespace Poem
{
    class Brain
    {

        public string word { get; set; }
        public int freq { get; set; }
        public int score { get; set; }
        public string flags { get; set; }
        public int syllables { get; set; }

        public Brain() { }
        public Brain(jsonWeHope);
        public Brain(string word, int syllables)
        {
            //this.Word = word;
            //this.Syllables = syllables; 
        }
        
        
        public static object SendRequestToBrain(string seedString, int maxResults)
        {
            
            WebRequest request = WebRequest.Create("http://rhymebrain.com/talk?function=getRhymes"
                + "&word=" + seedString
                + "&maxResults=" + maxResults);

            WebResponse resp = request.GetResponse();
            Console.Write(resp);
            //string displayTree = resp.ToString;

            Stream data = resp.GetResponseStream();

            StreamReader reader = new StreamReader(data);

            string jsonWeHope = reader.ReadToEnd();
            

            // DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(WebResponse));

            //TODO Deal with JSON somehow?


            Console.Write(jsonWeHope);

            resp.Close();
            return jsonWeHope;

        }

        public static string GetRhymes(string seedString)
        {
            return seedString;
        }

        public Brain(string jsonWeHope)
        {
            JObject jObject = jObject.Parse(jsonWeHope);
            JToken jBrain = jObject["brain"];
            word = (string)jBrain["word"];
            freq = (int)jBrain["freq"];
            score = (int)jBrain["score"];
            flags = (string)jBrain["flags"];
            syllables = (int)jBrain["syllables"];


        }
    }
}
