
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDto : IDto //Calass'ları çıplak bırakmıyoruz ama buraya :IEntity yazabilir miyiz?
                                     //Hayır yazamayız çünkü IEntity demek sen bir veri tabanı tablosusun demekti. Ama bu tek başına bir tablo değil.
                                     //O yüzden buna :IDto sen bir DTO'sun diyoruz.
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
        public List<string> ImagePath { get; set; }
    }
}
