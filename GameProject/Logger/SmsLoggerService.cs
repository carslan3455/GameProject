using System;

namespace GameProject
{
    class SmsLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms Loglandı...");
        }
    }
}
