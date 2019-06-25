using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            //ArrayList is deprecated, replaced by List.
            //You might see it in older code.
            //it is NOT a generic; we can't specify what type of object it holds.

            //how does it work?
            //"boxing" -- it's how C# converts stuff to an "object" type.
            //but that keeps it an object. If you need to use the object as an int or string (eg)
            //you have to case it back to its type.

            list.Add("some string");
            String s = (String)list[0];
            
        }
    }
}
