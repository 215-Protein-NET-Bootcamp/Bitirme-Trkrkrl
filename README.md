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
- Authorization
- Roles


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

<br/>

Bu api methodlarının büyük bir kısmı yetkilendirme gerektirmektedir.  Add,Delete Update methodlarının tamamı ve, özel verlere erişimgerektiren methodlar kullanıcı girişi gerektirmektedir.

<br/>



#### Auth Controller

<br/>


#### Auth - Register

<br/>

##### Senaryo 1: Kullanılmakta olan bir kullanıcıadı veya email ile kayıt olmaya çalışmak.	


<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Auth-Register-Failed-EmailOrUsernameInUse.png">

<br/>

##### Senaryo 2: Başarılı Kayıt	


<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Auth-Register-SuccessfullRegistration.png">

<br/>

##### Senaryo 3: Başarılı Kayıt	 -  Gönderilen Kayıt Emaili


<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Auth-Register-SuccessfullRegistration-SentEmail.png">

<br/>

##### Senaryo 4: Kayıt Bilgileri Validasyonları


<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Auth-Register-ValidationWorks.png">

<br/>

##### Senaryo 4: Kayıt Bilgileri Validasyonları


<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Auth-Register-ValidationWorks.png">

<br/>

<br/>


#### Auth - LoginWithEmail - Unregistered Email - User Not Found

<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Auth-LoginWithEmail-UnRegisteredEmail-usernotfound.png">

<br/>

#### Auth - LoginWithEmail - Invalid Email 

<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Auth-LoginWithEmail-UnvalidEmail.png">

<br/>

#### Auth - LoginWithUserName - Successful Login

<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Auth-LoginWithUserName-SuccessfulLogin.png">

<br/>

#### Auth - LoginWithUserName - UserNotFound 

<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Auth-LoginWithUserName-Username%20not%20found.png">

<br/>

#### Auth - Login - 3 kez Hatalı Giriş -  Account Suspended Maili
<br/>

Bu methodda kullanıcı parolasını 3 kez hatalı girerse hesabı 10 dk süreyle askıya alınır ve bilgilendirme emaili gönderilir.

<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Auth-Logion-Accountsuspended%2010%20minutes.png">

<br/>

#### Authorization Token Entrance

<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Authorization-token%20enter.png">

<br/>

#### Authorization Token Entrance

<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Authorization-token%20enter.png">

<br/>



<br/>

#### Address Controller

<br/>

Address add ve update methodları validation gerektirir. Bu yüzden adresinize mutlaka bir ad vermeli , il ,ilçe ve bina no'yu girmelisiniz.'

#### Address - Add

<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Address-Add.png">

<br/>

#### Address - Delete

<br/>

Delete işlemi için adress kısmında Id girilmesi yeterli olacaktır

<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Address-Delete.png">

<br/>

#### Address - Update

<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Address-Update.png">

<br/>

#### Address - GetAll

<br/>

Bu methodu çalıştırabilmek için Admin rolüne sahip bir kullanıcı girişi gerekmektedir.

<br/>


<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Address-Getall-Adminrequired.png">

<br/>


#### Address - GetByUserId

<br/>

Bu method giriş yapmış kullanıcının claims bilgilerinden userId bilgisini alır ve kaydetmiş olduğu adresleri getirir.
<br/

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Address-GetByUserId-autogetsId.png">

<br/>

<br/>

#### Brand Controller

<br/>

#### Brand - Add

<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Brand-Add-Success-Authorization%20%20required.png">

<br/>

#### Brand - Delete

<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Brand-Delete.pngs">

<br/>

#### Brand - Update

<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Brand-Update-AuthorizationRequired.png">

<br/>

#### Brand - GetAll

<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Brand-GetAll.png">

<br/>

#### Brand - GetByBrandId

<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Brand-GetByBrandId.png">

<br/>

<br/>

#### Category Controller

<br/>

#### Category - Add Failed - Admin Required

<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Category-Add-Failed-AdminRequired.png">

<br/>

#### Category - Add

<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Category-Add-SuccessWithAdmin.png">

<br/>

#### Category - Delete

<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Category-Delete.png">

<br/>

<br/>

#### Category - Update

<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Category-Update.png">

<br/>

#### Category - GetById

<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Category-GetById.png">

<br/>

#### Category - GetAll

<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Category-Getall.png">

<br/>

<br/>

#### Colors Controller

<br/>

#### Colors - Add  - Admin Required

<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Color-Add-AdminRequired.png">

<br/>

#### Colors - Delete  

<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Color-Delete-AdminRequired.png">

<br/>

#### Colors - Update  

<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Color-Update-AdminRequired.png">

<br/>

#### Colors - GetById  

<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Color-Getbyid.png">

<br/>

#### Colors - GetAll  

<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Colors-Getall.png">

<br/>

<br/>

#### Offers Controller

<br/>

#### Offers - Add/Make - Failed 

<br/>
Daha önce bu kullanıcı bu ürüne teklif yapmışsa bu yanıtı alır

<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Offer-Add-Daha%20OnceTeklifYaptiniz.png">

<br/>

#### Offers - Add/Make - Accept 

<br/>

Teklif kabul edildiğinde eğer aynı ürüne teklif yapmış  başka kullanıcılar varsa onlara , otomatik olarak decline işlemi uygulanır ve bilgilendirme maili iletilir.

<br/>


<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Offer-Accepted.png">

<br/>

#### Offers - Add/Make - Accepted  Bilgilendirme Maili

<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Offer-Accepted-NotificationMail.png">

<br/>

#### Offers - Add/Make - Fail - Percentage Validation 

<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Offer-Fail-MaxPercentageIs100.png">

<br/>

#### Offers - Add/Make - 100 percent Directed To Purchase

<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Offer-Make-100percent-directToPurchase.png">

<br/>

#### Offers - Add/Make - ByAmount

<br/>
<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Offer-Make-Success-byOfferAmount.png">



<br/>

#### Offers - Add/Make - ByPercentage

<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Offer-Make-Success-byPercentage.png">

<br/>

#### Offers - Add/Make - NotOfferableProduct

<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Offer-NotOfferableProduct.png">

<br/>



#### Offers - Delete/Cancel

<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Offer-Delete.png">

<br/>


#### Offers - Delete/Cancel - Fail  

<br/>

Eğer  teklif satıcı  tarafından kabul edilmiş  ise satışa dönüşmüştür ve offer olarak iptal edilemez.

<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Offer-DeleteCancel-Fail-OfferAcceptedCantBeCancelled.png">

<br/>

#### Offers - Decline

<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Offer-Decline.png">

<br/>

#### Offers - Decline Notification Mail

<br/>

Satıcı yapılan teklifi reddettiğinde teklifi yapan kişiye bilgilendrime maili iletilir. 

<br/>


<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Offer-Declined-NotificationMail.png">

<br/>

#### Offers - Decline Notification Mail


<br/>


<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Offer-Declined-NotificationMail.png">

<br/>

#### Offers - Update - CantBeUpdated


<br/>


<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Offer-Update-Fail-CantBeUpdated-ItsAcceptedBySeller.png">

<br/>

#### Offers - GetById


<br/>


<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Offer-GetById.png">

<br/>

#### Offers - GetDetailsByOfferId


<br/>


<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Offer-GetDetailsByOfferId.png">

<br/>

#### Offers - GetReceivedOffers


<br/>

Kullanıcının eklemiş olduğu ürünlere yapılan teklifleri gösterir.

<br/>


<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Offer-GetReceivedOffers.png">

<br/>

#### Offers - GetSentOffers


<br/>

Kullanıcının yapmış olduğu  teklifleri gösterir.UserId yi claimsten otomatik alır.

<br/>


<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Offer-GetReceivedOffers.png">

<br/>

#### Offers - GetAll


<br/>

Admin'in tüm teklifleri görmesini sağlar.

<br/>


<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Offer-Getall-ByAdmin.png">

<br/>

<br/>

#### Products Controller

<br/>

#### Products - Add



<br/>


<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Product-Add.png">

<br/>

#### Products - Delete



<br/>


<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Product-Delete.png">

<br/>



#### Products - Update



<br/>


<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Product-Update.png">

<br/>

#### Products - GetAll



<br/>


<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Product-GetAll.png">

<br/>

#### Products - GetAllByBrandId



<br/>


<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Product-GetAllByBrandId.png">

<br/>

#### Products - GetAllByCategoryId



<br/>


<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Product-GetByCategoryId.png">

<br/>

#### Products - GetByProductId



<br/>


<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Product-GetByProductId.png">

<br/>

#### Products - GetMyProductsOnSale

<br/>

Kullanıcının eklemiş olduğu, satıştaki ürünleri gösterir.

<br/>


<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Product-GetMyProductsOnSale.png">

<br/>

	
#### Products - GetProductDetailsByProductId

<br/>

Filter ve expression yardımı ile çalışır.Kökü data acceste bulunan bu method ile her türlü product özelliğine göre arama yapılabilir.

<br/>


<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Product-GetProductDetails-ByProductId%20works%20with%20filter.png">

<br/>



<br/>

#### ProductImages Controller

<br/>

<br/>

#### ProductImages - Add || Update Image Size Validation

<br/>

ProductImage yüklenmesi için controller bir adet formfile dosyası türünde nesne , bir adet de productImage nesnesine ait bilgiler için form nesnesi istiyor.
Svagger bu iki özelliği aynı aynda destekleyemediğinden Postman kullanılmalı. Jwt auth token girildikten sonra, resimdeki şekilde Add ve Update yapılmalıdır.

<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/ProductImage-Add%26Update-ImageSizeError.png">

<br/>

#### ProductImages - Add UnAuthorized

<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/ProductImage-add-unatuhorized.png">

<br/>

#### ProductImages - Add 

<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/ProductImage-add-successful.png">

<br/>

#### ProductImages - Update 

<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/ProductImage-Update-Success.png">

<br/>

#### ProductImages - GetByProductId

<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/ProductImage-GetByProductId.png">

<br/>


#### ProductImages - GetByProductImageId

<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/ProductImage-GetByProductImageId.png">

<br/>

#### ProductImages - GetAll

<br/>

<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/ProductImage-Getall.png">

<br/>

#### Purchase Controller



<br/>

#### Purchase - Add 

<br/>


<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Purchase-Add.png">

<br/>

#### Purchase - Cancel 

<br/>


<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Purchase-Cancel.png">

<br/>

#### Purchase - GetByPurchaseId 

<br/>


<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Purchase-GerByPurchaseId.png">

<br/>

#### Purchase - GetMyPurchases 

<br/>

Kullanıcının yapmış olduğu satınalmaları gösterir.

<br/>



<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Purchase-GetMyPurchases.png">

<br/>

#### Purchase - GetAll



<br/>



<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/Purchase-Getall.png">

<br/>

#### Users Controller



<br/>

#### Users - GetByMail 

<br/>


<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/User-GetByMail.png">

<br/>


#### Users - GetByUserName

<br/>


<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/User-GetByUserName.png">

<br/>

#### Users - UpdatePassword

<br/>


<img src="https://github.com/215-Protein-NET-Bootcamp/Bitirme-Trkrkrl/blob/master/Images/User-UpdatePassword.png">

<br/>


