namespace HomeWork08
{
    public class SecondTask
    {
        public void ThreadPoolTask(object task)
        {


            string taskName = (string)task;
            int threadId = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine("{0}, thread ID: {1}", taskName, threadId);
        }
    }

}