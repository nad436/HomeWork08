using System;
namespace HomeWork08
{
    class Program
    {        
        static void Main(string[] args)
        {
            var first = new FirstTask();
            var thread1 = new Thread(first.ThreadInfo);
            var thread2 = new Thread(first.ThreadInfo);

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            string[] tasks = new string[]
      {
          "Task 1",
          "Task 2",
          "Task 3",
          "Task 4",
          "Task 5",
          "Task 6",
          "Task 7",
          "Task 8",
          "Task 9",
          "Task 10",

          
      };
            var second = new SecondTask();
            foreach (string task in tasks)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(second.ThreadPoolTask), task);
            }
            Thread.Sleep(2000);

            var third = new ThirdTask();
            Thread threadLock1 = new Thread(third.CounterTask);
            Thread threadLock2 = new Thread(third.CounterTask);

            threadLock1.Start();
            threadLock2.Start();

            threadLock1.Join();
            threadLock2.Join();

            Console.WriteLine($"Counter:{third.counter}");

            var fourth = new FourthTask();
            for (int i = 1; i <= 5; i++)
            {
                Thread thread = new Thread(fourth.AccessResource);
                thread.Start(i);
            }
        }    
    }

}