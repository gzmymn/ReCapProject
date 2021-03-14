using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message):this(success) //constructor'ın base'lerle çalışmasına örnek -- diğer constructor ile birlikte çalışacak
        {
            Message = message; 
        }

        public Result(bool success) //sadece true-false döndürüp mesaj yazmak istemediğimiz durumlarda kullanabilmek için  
        {
            Success = success; //success'i set etme işi burada
        }

        public bool Success { get; } //IResult'ta sadece {get;} var yani bir şeyi return et demek. buraya ne yazarsak onu return edecektir

        public string Message { get; } //getter read only'dir ve read only'ler constructor'da set edilebilirler
                                       //set; koymamamızın sebebi kodları sınırlamak -- başarı dönüşümlerini constructor ile yapacağız kafasına göre kod yazma olayını kaldıracağız, 
                                       //kod okunurluğu rahat olacak.
    }
}
