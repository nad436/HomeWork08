namespace HomeWork08
{
    public class FourthTask
    {
        public Semaphore semaphore = new Semaphore(2, 2);
        public void AccessResource(object threadNumber)
        {
            semaphore.WaitOne();
            Console.WriteLine($"Thread{threadNumber} started");
            Thread.Sleep(2000);
            Console.WriteLine($"Thread{threadNumber} finished");
            semaphore.Release();
        }
    }

}