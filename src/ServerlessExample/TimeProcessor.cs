using System;

namespace ServerlessExample
{
    public class TimeProcessor : ITimeProcessor
    {
        public DateTime CurrentTimeUTC()
        {
            return DateTime.UtcNow;
        }
    }
}