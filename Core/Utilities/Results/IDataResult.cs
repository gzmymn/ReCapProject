using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T> : IResult //Hangi tipi döndüreceğini bana söyle 
                                              //IResult gibi mesaj, işlem sonucu içersin ama aynı zamanda data içersin.
                                              //Mesaj ve işlem sonucunu zaten IResult içeriyor o yüzden sen bir IResult implementasyonusun diyoruz
    {
        T Data { get; }
    }
}
