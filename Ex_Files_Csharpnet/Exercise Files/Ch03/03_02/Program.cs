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
        //Await keyword.
        //used with Async.

        static void Main(string[] args)
        {
            Console.WriteLine("downloading file");
            Download();       
            Console.ReadLine();

        }

        static async void Download() //await MUST be paired with "async" in the method declaration line
        {
            //this method will call the external class below.
            //the method in that class pauses for 3 seconds 
            //to simulate the time it takes to download
            await Network.Download(); //await keyword tells the rest of this line to 
                                        //continue the block of code once Network.Download() is complete            

            //this next line will run once Network.Download() is complete 
            //because of the await keyword:
            Console.WriteLine("Download complete");
        }
   }


    // Imaginary external network library

    class Network
    {
        static public Task Download()
        {
            return Task.Run(() => Thread.Sleep(3000));
        }
    }
}

//async/await also have several specific methods you can use for specific things you want to to.
//look them up as needed.
