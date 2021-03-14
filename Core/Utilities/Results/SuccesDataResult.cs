using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data, string message) : base(data, true, message) //işlem sonucunu default true verdim
        {

        }

        public SuccessDataResult(T data) : base(data, true) //mesaj vermek istemediğimde
        {

        }

        public SuccessDataResult(string message) : base(default, true, message) //bu versiyonda data'yı default haliyle döndürmek istiyorum -- pek sık kullanılmaz
        {

        }

        public SuccessDataResult() : base(default, true) //mesaj vermiyorum data'yı default döndürüyorum
        {

        }
    }
}
