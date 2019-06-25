using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningUsing
{
    class MyResource : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Disposing our resource"); //will print second
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //USING STATEMENT. manages resources only while the resource is scoped
            //so long as the resource also uses "Dispose"

            //see above for MyResource class.
            //it contains the Dispose method.
            //USING it here, the body of this block will run
            //then the used resource will run, including Dispose.
            using (var resource = new MyResource())
            {
                Console.WriteLine("Using my resource"); //will print first
            }
            Console.WriteLine("Finished"); //out of using scope, will print third.
        }
    }
}
