﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Poem
{
    class MakeBrain
    {
        public static object SendRequestToBrain(string seedString, int maxResults)
        {
            Brain brainClass = new Brain();

            WebRequest request = WebRequest.Create("http://rhymebrain.com/talk?function=getRhymes"
                + "&word=" + seedString
                + "&maxResults=" + maxResults);

            WebResponse resp = request.GetResponse();
            Console.Write(resp);
            //string displayTree = resp.ToString;

            Stream data = resp.GetResponseStream();

            StreamReader reader = new StreamReader(data);

            string jsonWeHope = reader.ReadToEnd();

            Console.Write(jsonWeHope);

            resp.Close();

            


            List<Brain> brainList = JsonConvert.DeserializeObject<List<Brain>>(jsonWeHope);

            for (int x = 0; x < brainList.Count; x++)
            {
                Console.Write("The brain object is " + x.ToString());
                Console.WriteLine(brainList[x]);

            }


            //Console.Write("The word is " + brainClass.word);

            return jsonWeHope;
        }
        
    }
}
