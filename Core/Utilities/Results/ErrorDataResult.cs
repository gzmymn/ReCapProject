using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data, false, message) //işlem sonucunu default false verdim
        {

        }

        public ErrorDataResult(T data) : base(data, false) //mesaj vermek istemediğimde
        {

        }

        public ErrorDataResult(string message) : base(default, false, message) //bu versiyonda data'yı default haliyle döndürmek istiyorum -- pek sık kullanılmaz
        {

        }

        public ErrorDataResult() : base(default, false) //mesaj vermiyorum data'yı default döndürüyorum
        {

        }
    }
}
