using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningHashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            var myHash = new HashSet<String>();
            //HashSet is an optimized set collection.
            //it removes duplicates

            //add the same item twice:
            myHash.Add("hello");
            myHash.Add("hello");

            //create a string array of "s"
            //below, we'll compare this to "myHash"
            String[] s = new String[] { "hello" };

            Console.WriteLine(myHash.Count); //count will be 1 because it removes duplicates.
            Console.WriteLine(myHash.Overlaps(s)); //checks for overlap between the HashSet and
                                                    //whatever you are comparing it to.
                                                    //returns true
        }
    }
}
