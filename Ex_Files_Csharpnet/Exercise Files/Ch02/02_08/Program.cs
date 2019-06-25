using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningTuple
{
    class Program
    {
        static void Main(string[] args)
        {
            //here is one way of creating Tuples:
            //since it is generic, gotta identify the types.
            //Tuple<int, String, bool> myTuple = new Tuple<int, string, bool>(1, "hello", true);

            //here's another way to create a Tuple:
            //C# figures out the types this way.
            var myTuple = Tuple.Create(1, "hello", true);
            //Tuples are not collections of the same type.
            //They allow for creation of objects containing various types.

            //why use a Tuple?
            //getting object from a server or DB, instead of creating a class.
            //return multiple items from a function 
            //(because functions return only item, but a Tuple is considered one item with multiple things in it)

            Console.WriteLine(myTuple.Item2);
        }
    }
}
