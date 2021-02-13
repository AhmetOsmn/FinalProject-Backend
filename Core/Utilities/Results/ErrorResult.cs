using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorResult:Result
    {
        public ErrorResult(string message) : base(false, message) //mesaj veriyor
        {

        }

        public ErrorResult(bool success) : base(false) //mesaj vermek istemiyor
        {

        }
    }
}
