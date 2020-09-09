using System;

namespace ServerlessExample
{
    public interface ITimeProcessor
    {
         DateTime CurrentTimeUTC();
    }
}