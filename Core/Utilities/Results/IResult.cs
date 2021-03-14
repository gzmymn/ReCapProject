using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel voidler için başlangıç -- void'ler bir şey döndürmeyeceği için işlem sonucu ve mesajı döndürmesi yeterli
    public interface IResult
    {
        bool Success { get; } // get -- sadece okunabilir -- yapmaya çalıştığım işin başarılı ya da başarısız olduğunu bildirmek için
        string Message { get; } //yapmaya çalıştığım işlemin başarı durumuna göre mesaj verecek
    }
}
