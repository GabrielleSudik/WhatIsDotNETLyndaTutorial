using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//null conditional operators
//this example is really simple.
//a real life example might be, if a field in a DB is null.
//four different ways of managing nulls below.

namespace LearningNullConditional
{
    class Person
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person() { Name = "Tim" }; //what if this was null
            Person person = null;

            //we COULD add an if statement to prevent Console.WriteLine from crashing...
            if (person != null) {
                Console.WriteLine(person.Name);
            }

            //or even tidier via coalescing:
            Console.WriteLine(person?.Name);

            //or nesting null conditional operator:
            Person person2 = new Person(); //ie, still null
            Console.WriteLine(person2?.Name?.Length);

            //coalescing plus conditional operators:
            Person person3 = new Person(); //ie, still null
            Console.WriteLine(person3?.Name ?? "Name not set.");


        }
    }
}
