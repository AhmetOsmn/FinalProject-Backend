using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel voidler icin baslangic
    public interface IResult
    {
        bool Success { get; }   //sadece okunabilir.
        string Message { get; } //sadece okunabilir.
    }
}
