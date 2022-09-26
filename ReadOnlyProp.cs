using System;

namespace sess09_Properties__and_Indexers
{
    /// <summary>
    /// Program to demonstrate read-only property
    /// </summary>
    public class ReadOnlyProp
    {
        private DateTime _currentTime = DateTime.Now;

        //Read Only property
        public DateTime CurrentTime
        {
            get { return _currentTime; }
        }
            static void Main(string[] args)
        {
            Console.WriteLine($"The current time is {new ReadOnlyProp().CurrentTime:t}");
        }
    
    }
}
