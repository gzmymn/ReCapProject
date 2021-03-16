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

        public static string BrandAdded = "Marka eklendi";
        public static string BrandsListed = "Markalar listelendi";

        public static string ColorAdded = "Renk eklendi";
        public static string ColorsListed = "Renkler listelendi";

        public static string Deleted = "Silindi!";
        public static string Updated = "Güncellendi!";

        public static string MaintenanceTime = "Sistem bakımda";

        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerListed = "Müşteriler listelendi";

        public static string RentalAddedError = "Kiralama işlemi başarısız! Araç teslim edilmemiş! ";
        public static string RentalAdded = "Kiralama bilgisi eklendi.";
        public static string RentalDeleted = "Kiralama bilgisi silindi!";
        public static string RentalUpdated = "Kiralama bilgisi güncellendi!";
        public static string RentalListed = "Kiralama bilgileri listelendi.";
        public static string RentalUpdateReturnDateError = "Araç teslim edilmiş.";
        public static string RentalUpdateReturnDate = "Araç teslim alındı";

        public static string UserNmeInvalid ="Kullanıcı adı geçersiz!";
        public static string UserAdded = "Kullanıcı eklendi.";
        public static string UserListed = "Kullanıcılar listelendi.";
    }
}
