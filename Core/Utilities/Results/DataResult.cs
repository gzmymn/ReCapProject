using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool success, string message):base(success, message)  //Result'ın constructor'larını yapıyorum
        {
            Data = data;
        }

        public DataResult(T data, bool success):base(success) //mesaj görmek istemediğim durumlarda kullanırım
        {
            Data = data;
        }
        public T Data { get; }
    }
}
