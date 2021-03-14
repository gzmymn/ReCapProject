using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult :Result
    {
        public SuccessResult(string message): base(true, message) //base=Result class'ı -- arkada true dönüyor sadece mesajı belirtmem yeterli
        {

        }

        public SuccessResult() : base(true) //Result class'ında sadece success dönen - mesaj vermek istediğimiz durum
        {

        }
    }
}
