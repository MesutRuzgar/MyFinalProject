using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //mesaj yollamak istemiyorsak this koyup 2. koduda calıstırırız
        //ikisini aynı kodda da calıstırabiliriz.
        public Result(bool success, string message):this(success)
        {
            Message = message;            
        }
        public Result(bool success)
        {
           Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
