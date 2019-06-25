using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> customers = new List<string>();
            //List is a generic. So you need to assign a type like <string> 
            //but they can be a lot more complicated.
            //Most Collections are generic.

            customers.Add("Kim");
            customers.Add("John");
            customers.Add("Tim");

            Console.WriteLine(customers.Count);

            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }

            Console.WriteLine(customers[1]);
            Console.ReadLine();
        }
    }
}
