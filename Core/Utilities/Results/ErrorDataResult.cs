using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        //mesajı doğru kabul etti
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }
        //mesaj girmek istemeyebilir
        public ErrorDataResult(T data) : base(data, false)
        {

        }
        //defult haliyle dönmek isterse
        public ErrorDataResult(string message) : base(default, false, message)
        {

        }
        //hiçbir şey vermek istemiyor
        public ErrorDataResult() : base(default, false)
        {

        }
    }
}
