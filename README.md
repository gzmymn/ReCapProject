# Rent A Car Project - Araç Kiralama Projesi

Proje genel hatlarıyla katmanlı mimariye uygun şekilde tasarlanmıştır ve OOP olarak Entity Framework kullanılmaktadır.
AutoFac ve FluentValidation paketleri kullanılmaktadır.
SOLID ilkeleri ve IoC prensibi ile geliştirilmiştir. 

## Katmanlar (Layers)

***Business***: Sunum katmanından gelen bilgileri gerekli koşullara göre işlemek veya denetlemek için oluşturulan iş katmanıdır. <br>
          Abstract klasörü soyut nesneleri, Concrete klasörü somut nesneleri tutmaktadır. <br>
          Utilities ve ValidationRules klasörlerinde doğrulama(validation) işlemlerinin gerçekleştiği classlar mevcuttur. <br>
         
***Core***: Bu katmanın adının .Net Core ile hiçbir bağlantısı olmamakla birlikte bir Framework katmanıdır ve her projede ortak kullanılabilecek yapılar kodlanmıştır. <br>
      Bu katman ile kurumsal bir yapıda, alt yapı ekibi ilgilenir. <br>
      İçerisinde bulunan DataAccess klasörü DataAccess Katmanı ile ilgili nesneleri, Entities klasörü Entities katmanı ile ilgili nesneleri tutmak için oluşturulmuştur. <br>
     
***DataAccess***: Veritabanında gerçekleşen CRUD işlemleri için oluşturulan Data Access Katmanı'nda Abstract klasörü soyut nesneleri, Concrete klasörü somut nesneleri tutmak için oluşturulmuştur. <br>

***Entites***: Veritabanı nesneleri için oluşturulmuş olan katmanda Abstract ve Concrete olmak üzere iki adet klasör oluşturulmuş fakat abstract klasörü core katmanına referans vermesi gerektiğinden dolayı core katmanına taşınmıştır. <br>
         DTOs katmanında ise detaylara göre çağırılacak olan operasyonlar için varlıklar oluşturulmuş ve bu detaylar DataAccess kısmında birleştirilmiştir. <br>
         (Core katmanı ortak katmandır hiçbir yerden referans alamaz). <br>
         
***WebAPI*** <br>

***WebUI***: Proje'de Frontend için Angular kullanılmaktadır. <br>

## Projede Kullanılan Teknikler <br>

*- SOLID PRENSİPLERİ*<br>
*- AOP*<br>
*- KATMANLI MİMARİ*<br>
*- AUTOFAC*<br>
*- OOP (ENTITY FRAMEWORK)*<br>
*- JWT YAPILANDIRILMASI*<br>
