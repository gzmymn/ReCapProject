using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages //static : sürekli new'lememek için
    {
        public static string CarAdded = "Araba eklendi"; //public olduğu için Pascal Case
        public static string CarNameInvalid = "Araba ismi geçersiz";        
        public static string CarsListed = "Arabalar listelendi";
        public static string DailyPriceInvalid = "Günlük ücret geçersiz";

        public static string BrandAdded = "Araba eklendi";
        public static string BrandsListed = "Modeller listelendi";

        public static string ColorAdded = "Araba eklendi";
        public static string ColorsListed = "Renkler listelendi";

        public static string Deleted = "Silindi";
        public static string Updated = "Güncellendi";

        public static string MaintenanceTime = "Sistem bakımda";
    }
}
