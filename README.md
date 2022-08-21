# PatikaBitirme-EticaretApp 

<br/>
Konu: Ürün Katalog Projesi
<br/>
Bu proje c# dili ile .Net Core 5.0 Framework'u ile gelistirlimis bir backend projesidir.

### Kullanilan Teknolojiler
- Asp .Ner Core WebAPI
- EntityFramework Core
- Autofac 
- FluentValidation
- RabbitMQ
- Docker
- PostgreSQL

<br/>

### Kullanilan Teknikler

- Layered Architecture Design Pattern
- Repository Design Pattern
- Restful API
- Result Types
- Interceptor
- Autofac 
- AOP, Aspect Oriented Programming
- Caching
- Validation
- Fluent Validation
- Cache Management
- JWT Authentication
- Cross Cutting Concerns
- Extensions
- Claims
- Service Collection
- Error Handling
- Validation Error Details
- SeriLog
- IOC
- File Upload
- Migration

<br/>

### Kurulum için gerekenler

<br/>

- Docker : Dockerda bir RabbitMQ container oluşturmalısınız. RabbitMQ erişim bilgilerinizi appsettings.json dosyasındaki ilhili bölümlere girmelisiniz
- Dockerda oluşturduğunuz bu container i run ettikten sonra backend projesini açınız.
- Proje için Database oluşturulması gereklidir. Bu projede PostgreSQl tercih edilmiştir.
- Kendi Database erişim bilgilerinizi appsetting.json dosyassındaki ilgili yere giriniz.
- Daha sonra migration oluşturmak için Visual studioda Packaga Manager Console'u açınız. Bilmeyenler için  sol üstteki View>other Windows>Packaga Manager Console.
- Packaga Manager Console 'da DataAccess'i seçiniz'(deffault olarak WebApi seçilidir) ve  Add-Migraiton mig_06  kodunu çalıştırınız . en son 05 yapıldığından dolayı 06 , sayıyı kendiniz belirleyebilirsiniz.
- Migration başarılı bir şekilde gerçekleştikten sonra Update-Database komutunu çalıştırın. Bu komut da başarılı bir şekilde çallıştıysauygulamamız çalıştırılmaya hazır demektir.
- Çalıştırmadan önce rabbitMQ 'nun Run -  Çalışır  halde olduğundan emin olunuz.

<br/>

### APILER


	
