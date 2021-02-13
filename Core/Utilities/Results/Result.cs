using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message):this(success)   //eger bu ctor calisirsa diger ctora da success gonderilsin demek.
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }
        public bool Success { get; } //sadece okunabilir demek. Sadece Ctor ile set edilebilir.

        public string Message { get; }
    }
}
