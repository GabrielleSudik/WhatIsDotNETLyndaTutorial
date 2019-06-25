using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, String> config = new Dictionary<string, string>();
            //Dictionaries are also generics. Need to supply the types for both key and value.


            config.Add("resolution", "1920x1080");
            config.Add("title", "MyWebsite");

            Console.WriteLine(config["title"]); //prints the value MyWebsite.
                //looks kind of like array[position] prints the value.

            //the reverse doesn't work. IE, "calling" the value won't print the key.
            //values can repeat. keys cannot.

            foreach (var setting in config)
            {
                Console.WriteLine(setting.Value);
            }

        }
    }
}
