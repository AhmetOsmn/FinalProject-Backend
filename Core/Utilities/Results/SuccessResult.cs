using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message) : base(true, message) //mesaj veriyor
        {

        }

        public SuccessResult(bool success) : base(true) //mesaj vermek istemiyor
        {

        }
    }
}
