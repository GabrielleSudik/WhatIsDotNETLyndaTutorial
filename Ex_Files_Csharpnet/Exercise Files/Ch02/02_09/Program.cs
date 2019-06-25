using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<String> pancakes = new Stack<string>();
            //Stack is LIFO collection. Like a stack of pancakes on a plate.
            //generic, so declare the type.

            //no "Add" in Stack -- use "Push"
            //I like the plates at a buffet analogy, which actually push down.
            pancakes.Push("first pancake made");
            pancakes.Push("second pancake made");
            pancakes.Push("last pancake made");

            //foreach (var pancake in pancakes)
            //{
            //    Console.WriteLine(pancake);
            //}

            Console.WriteLine(pancakes.Pop()); //pop shows the last item added to the stack
                //and it removes it too
                //think about how Git Pop works.
            Console.WriteLine(pancakes.Peek()); //peek shows the "top" item without popping it.
            Console.WriteLine(pancakes.Peek()); //so if you call it twice, it will show the top item twice
                //because it didn't pop the first time.


        }
    }
}
