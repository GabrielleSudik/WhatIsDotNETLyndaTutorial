using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

//TASK = piece of work that needs to get done
//THREAD = a thing that performs the work

namespace LearningThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            //the loop will start 50 threads:
            for (int i = 0; i < 50; i++)
            {
                //a new Thread needs an argument.
                //when it's the ThreadStart parameter, it also needs an argument
                //here, that second argument will be the method Work that we create below.
                Thread mythread = new Thread(new ThreadStart(Work));
                //this plus the Work method is creating a manual task.
                //this way starts all threads at the same time.
                //it can cause lag. but gives a lot of control.
                
                //start the Work function (funneled through the Thread methods):
                mythread.Start();

                //here, using Task is another way to manage stuff:
                //this will do each task one at a time.
                //better performance, but not as fine-tuned
                //(I don't know why regular threads give more control btw)
                Task.Run(() =>
                {
                    Console.WriteLine("starting task in thread: " + Thread.CurrentThread.ManagedThreadId);
                    Thread.Sleep(3000);
                    Console.WriteLine("task complete");
                });
            }

            Console.ReadLine();
        }

        //this method will simulate some 3-second work.
        static void Work()
        {
            Console.WriteLine("starting in thread: " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(3000);
            Console.WriteLine("work complete");
        }
    }
}
