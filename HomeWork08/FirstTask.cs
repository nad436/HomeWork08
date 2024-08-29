namespace HomeWork08
{
    public class FirstTask
    {
        public void ThreadInfo()
        {
            string threadName = Thread.CurrentThread.Name;
            int threadId = Thread.CurrentThread.ManagedThreadId;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Thread name: {threadName}\nThread ID: {threadId}");
                Thread.Sleep(500);
            }
        }
    }

}