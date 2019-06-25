using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//null coalescing
//it's when you try to set a variable to something that would be null
//except instead you set it to a default variable.

namespace LearningNulls
{
    class Program
    {
        static void Main(string[] args)
        {
            int? s = null; //s is nullable, so null is an ok value
            int s2 = s ?? 2; //s2 is NOT nullable, so null (s) would not be ok
                //so set a default value. here, it's "2"

            Console.WriteLine(s2); //prints 2.

            //note you can't null coalesce a non-nullable type.
            //you'll get an error
            //that makes sense. if s can't be null, s2 here can't be either.
        }
    }
}
