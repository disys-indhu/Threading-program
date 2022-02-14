using System;
using System.Threading;
class VariousMethods
{
    public static void Main()
    {
        Thread newThread = new Thread(new ThreadStart(TestMethod));
        newThread.Start();
        Thread.Sleep(1000);
        Console.WriteLine("Main aborting new thread");
        newThread.Abort("Information from Main");
        newThread.Join();
        Console.WriteLine("New thread terminated ");
    }
    static void TestMethod()
    {
        try
        {
            while (true)
            {
                Console.WriteLine("New thread");
                Thread.Sleep(1000);
            }
        }
        catch (ThreadAbortException abortException)
        {
            Console.WriteLine((string)abortException.ExceptionState);
        }
    }
}

