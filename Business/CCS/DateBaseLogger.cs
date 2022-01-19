using System;

namespace Business.CCS
{
    public class DateBaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına Loglandı");
        }
    }


}
