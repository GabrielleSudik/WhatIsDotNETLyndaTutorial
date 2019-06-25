using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningHashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();
            //Hashtable has been replaced by Dictionary.
            //non-generic, so you can't assign types.
            //like ArrayList, it will box items into objects
            //which will need to be unboxed to use

            table.Add("title", "MyWebsite");

            var s = (String)table["title"]; //see, has to be cast as "string" to use.
            Console.WriteLine(s);
        }
    }
}
