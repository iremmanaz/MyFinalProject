using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        //mesajı doğru kabul etti
        public SuccessDataResult(T data, string message):base(data,true,message)
        {
            
        }
        //mesaj girmek istemeyebilir
        public SuccessDataResult(T data):base(data,true)
        {
            
        }
        //defult haliyle dönmek isterse
        public SuccessDataResult(string message):base(default,true,message)
        {
            
        }
        //hiçbir şey vermek istemiyor
        public SuccessDataResult():base(default,true)
        {
            
        }
    }
}
