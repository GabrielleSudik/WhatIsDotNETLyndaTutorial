using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> myQueue = new Queue<int>();
            //Queue is FIFO collection. Like a line waiting at a shop.

            //no "Add". use "Enqueue"
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);

            //foreach (var item in myQueue)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine(myQueue.Dequeue()); //this is like pop -- it shows and removes the first item
            Console.WriteLine(myQueue.Peek()); //shows the first item without removing it.


        }
    }
}
