Rent A Car Project - Araç Kiralama Projesi

Proje genel hatlarıyla katmanlı mimariye uygun şekilde tasarlanmıştır ve OOP olarak Entity Framework kullanılmaktadır.
AutoFac ve FluentValidation paketleri kullanılmaktadır.
SOLID ilkeleri ve IoC prensibi ile geliştirilmiştir. 

Katmanlar (Layers(

Business: Sunum katmanından gelen bilgileri gerekli koşullara göre işlemek veya denetlemek için oluşturulan iş katmanıdır. 
          Abstract klasörü soyut nesneleri, Concrete klasörü somut nesneleri tutmaktadır.
          Utilities ve ValidationRules klasörlerinde doğrulama(validation) işlemlerinin gerçekleştiği classlar mevcuttur.
         
Core: Bu katmanın adının .Net Core ile hiçbir bağlantısı olmamakla birlikte bir Framework katmanıdır ve her projede ortak kullanılabilecek yapılar kodlanmıştır. 
      Bu katman ile kurumsal bir yapıda, alt yapı ekibi ilgilenir.
      İçerisinde bulunan DataAccess klasörü DataAccess Katmanı ile ilgili nesneleri, Entities klasörü Entities katmanı ile ilgili nesneleri tutmak için oluşturulmuştur.
     
DataAccess: Veritabanında gerçekleşen CRUD işlemleri için oluşturulan Data Access Katmanı'nda Abstract klasörü soyut nesneleri, Concrete klasörü somut nesneleri tutmak için oluşturulmuştur.

Entites: Veritabanı nesneleri için oluşturulmuş olan katmanda Abstract ve Concrete olmak üzere iki adet klasör oluşturulmuş fakat abstract klasörü core katmanına referans vermesi gerektiğinden dolayı core katmanına taşınmıştır.
         DTOs katmanında ise detaylara göre çağırılacak olan operasyonlar için varlıklar oluşturulmuş ve bu detaylar DataAccess kısmında birleştirilmiştir.
         (Core katmanı ortak katmandır hiçbir yerden referans alamaz).
         
WebAPI

WebUI: Proje'de Frontend için Angular kullanılmaktadır.

Projede Kullanılan Teknikler

SOLID PRENSİPLERİ
AOP
KATMANLI MİMARİ
AUTOFAC
OOP (ENTITY FRAMEWORK)
JWT YAPILANDIRILMASI
