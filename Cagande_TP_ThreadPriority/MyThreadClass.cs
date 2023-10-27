using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cagande_TP_ThreadPriority
{
    internal class MyThreadClass
    {
        public  static void Thread1()
        { 
            for (int loopCount = 0; loopCount < 2; loopCount++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + loopCount);
                Thread.Sleep(TimeSpan.FromSeconds(0.5));
            }
        }

        public static void Thread2() {
            for (int loopCount = 0; loopCount < 5; loopCount++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + loopCount);
                Thread.Sleep(TimeSpan.FromSeconds(1.5));
            }
        }
    }
}
