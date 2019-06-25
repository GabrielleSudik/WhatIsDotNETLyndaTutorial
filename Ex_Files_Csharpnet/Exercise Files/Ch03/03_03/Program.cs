using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LearningAsyncAwayStart
{
    class Program
    {
        //Anonymous Functions and callbacks.
        //I think they are an alternative to async/await, 
        //but prof was pretty skimpy on this point.

        //see "static void Download"
        //and "class Network" below.

        static void Main(string[] args)
        {
            Console.WriteLine("downloading file");
            Download();
            Console.ReadLine();

        }

        static void Download()
        {
            Network.Download((message) => Console.WriteLine("Download complete " + message));
            //that's an anonymous function
            //using the lambda expression makes it an in-line anon function.
        }
    }

    // Imaginary external network library

    class Network
    {
        static public void Download(Action<String> callback)
        {
            Task.Run(() => {
                Thread.Sleep(3000);
                callback("completed");
                });
        }

        //Task.Run(() => { } is an anonymous function

    }
}
