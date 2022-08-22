# BitirmeProjesi-gorkemetem
Bu proje kullanıcıların register ve login olabildiği, ürünlere teklif verebildiği ve bu ürünleri satın alabildikleri bir alışveriş uygulamasıdır.

Projede rolle yetkilendirme kullandım. Bu yetkileri database tarafında kendim verdim. Methodların üzerinde bulunan
attribute'lar ile kullanıcıların yetkilerini kontrol ettim.

![swagger](ScreenShots/UsersInDatabase.PNG)
![swagger](ScreenShots/UserOperationClaims.PNG)
![swagger](ScreenShots/OperationClaim2.PNG)

Cache ve validation işlemlerini aspect oriented programming ile gerçekleştirdim.

Aşağıda controller'larda bulunan methodlarının swagger ekran görüntüleri bulunmaktadır.

Not:
- DeleteOffer fonksiyonu tam doğru çalışmıyor. Geç farkettiğim için düzeltmek için zamanım kalmayabilir. 

      Register ve Login:
   
![swagger](ScreenShots/Register1.PNG)
![swagger](ScreenShots/Register2.PNG)
![swagger](ScreenShots/Login1.PNG)
![swagger](ScreenShots/Login2.PNG)
![swagger](ScreenShots/Authorize.PNG)

      Offer:
   
![swagger](ScreenShots/OfferPost1.PNG)
![swagger](ScreenShots/OfferPost2.PNG)
![swagger](ScreenShots/OfferPostPercentage1.PNG)
![swagger](ScreenShots/OfferPostPercentage2.PNG)
![swagger](ScreenShots/OfferGetByUserId1.PNG)
![swagger](ScreenShots/OfferGetByUserId2.PNG)
![swagger](ScreenShots/OfferGetAll.PNG)
![swagger](ScreenShots/OfferDelete1.PNG)
![swagger](ScreenShots/OfferDelete2.PNG)

      Product:
   
![swagger](ScreenShots/ProductPost1.PNG)
![swagger](ScreenShots/ProductPost2.PNG)
![swagger](ScreenShots/ProductPut1.PNG)
![swagger](ScreenShots/ProductPut2.PNG)
![swagger](ScreenShots/ProductGetAll.PNG)
![swagger](ScreenShots/ProductGetById1.PNG)
![swagger](ScreenShots/ProductGetById2.PNG)
![swagger](ScreenShots/ProductGetByCategoryId.PNG)
![swagger](ScreenShots/ProductGetByCategoryId2.PNG)
![swagger](ScreenShots/ProductBuy1.PNG)
![swagger](ScreenShots/ProductBuy2.PNG)
![swagger](ScreenShots/ProductDelete1.PNG)
![swagger](ScreenShots/ProductDelete2.PNG)

      Category:
   
![swagger](ScreenShots/CategoryPost1.PNG)
![swagger](ScreenShots/CategoryPost2.PNG)
![swagger](ScreenShots/CategoryPut1.PNG)
![swagger](ScreenShots/CategoryPut2.PNG)
![swagger](ScreenShots/CategoryGetAll.PNG)
![swagger](ScreenShots/CategoryGetById1.PNG)
![swagger](ScreenShots/CategoryGetById2.PNG)
![swagger](ScreenShots/CategoryDelete1.PNG)
![swagger](ScreenShots/CategoryDelete2.PNG)
