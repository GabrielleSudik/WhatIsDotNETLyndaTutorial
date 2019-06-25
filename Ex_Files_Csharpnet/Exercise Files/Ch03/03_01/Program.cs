using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LearningAsync
{
    class Program
    {
        //Async programming means different things happen at the same time
        //Eg: you need to be able to download large files while keeping a UI useable.

        static void Main(string[] args)
        {
            Console.WriteLine("Downloading file");
            Download();
            Console.ReadLine();
        }

        static void Download()
        {
            //for this demo, we will pause the application
            //to simulate what would happen if you had to download a file
            Task.Run(() => {
                Thread.Sleep(3000);
                Console.WriteLine("Download Complete");
            });
            //If we didn't use Task.Run, the program would merely pause for 3 seconds.
            //the Console.ReadLine above wouldn't work for 3 seconds.
            //Task.Run allows the code inside to run async
            //so the other code above keeps going without the pause.

            //the Task.Run(() => { } syntax is an anonymous function
            //we'll learn more about them later.

        }
    }
}
