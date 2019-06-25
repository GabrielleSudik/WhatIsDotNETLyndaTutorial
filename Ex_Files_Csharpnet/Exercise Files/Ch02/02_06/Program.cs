using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LearningConcurrent
{
    class Program
    {
        static ConcurrentDictionary<int, int> items = new ConcurrentDictionary<int, int>();
        //ConcurrentDictionary (generic) is used when you have multiple threads

        //check out the code below. AddItem() creates a key/value pair of 1, 2.
        //if "items" were a plain old Dictionary, when you ran thread2.Start(),
        //you'd get an error because thread1.Start() had already added 1, 2
        //to the dictionary. (And you can have only one "1" as a key)
        //ConcurrentDictionary allows two threads to have independent dictionaries,
        //including with the same key.

        static void Main(string[] args)
        {
            //create two new threads:
            Thread thread1 = new Thread(new ThreadStart(AddItem));
            Thread thread2 = new Thread(new ThreadStart(AddItem));

            //call them
            thread1.Start();
            thread2.Start();
        }

        static void AddItem()
        {
            items.TryAdd(1, 2); //that's key/value
            //"TryAdd" will check that the arguments aren't already there
            //or at least that the key isn't already there.
            //use instead of Add
            Console.WriteLine(items.Count);
        }
    }
}
