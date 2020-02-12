using System;
using System.Threading;

namespace _Threading
{
    class SyncThread
    {
        object block = new object();

        public void SyncThreadMethod()
        {
            lock (block)
            {
                for (int counter = 0; counter < 10; counter++)
                {
                    //lock (new object { })
                    {
                        Console.WriteLine("Thread # {0}, step {1}", Thread.CurrentThread.GetHashCode(), counter);
                        Thread.Sleep(100);
                    }
                }
                Console.WriteLine(new string('-', 20));
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SyncThread syncThread = new SyncThread();

            for (int i = 0; i < 3; i++)
            {
                new Thread(syncThread.SyncThreadMethod).Start();
            }

            Thread.Sleep(500);

            Console.Out.WriteLine("kjsjhdvvlkzjdlvj");

            Console.ReadKey();
        }
    }
}
