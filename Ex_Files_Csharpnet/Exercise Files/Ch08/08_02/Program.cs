using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string s = null;
                var l = s.Length; //s is null so will throw an exception
                    //will then move to the catch block.
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }

    //let's do a custom exception:
    class Person{

        private String name;

        public String Name{

                get {return name;}
                set { 
                        if(value == null)
                        { throw new NullReferenceException("Name must have a value");

                        name = value;

                    }

              }
            
        }

    }

}

//fyi, you can throw multiple exceptions per error

//you can also set exceptions to catches.
//you can put if statements in the catch block, for example to write different logs at night/day
//or set special messages for specific things.

//another syntax is "catch (thing) when (thing == whatever)" and leaving out if statements in the block
