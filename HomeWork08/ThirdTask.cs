namespace HomeWork08
{
    public class ThirdTask
    {
        
        static readonly object lockObject = new object();
        public int counter = 0;
        public void CounterTask()
        {
            for (int i = 0; i < 1000; i++)
            {
                lock (lockObject)
                {
                    counter++;
                }
            }
        }
    }

}