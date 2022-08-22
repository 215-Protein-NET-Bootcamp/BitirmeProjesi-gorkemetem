# BitirmeProjesi-gorkemetem
Bu proje kullanıcıların register ve login olabildiği, ürünlere teklif verebildiği ve bu ürünleri satın alabildikleri bir alışveriş uygulamasıdır.

Projede rolle yetkilendirme kullandım. Bu yetkileri database tarafında kendim verdim. Methodların üzerinde bulunan
attribute'lar ile kullanıcıların yetkilerini kontrol ettim.

![swagger](ScreenShots/UsersInDatabase.PNG)
![swagger](ScreenShots/OperationClaim.PNG)
![swagger](ScreenShots/OperationClaim2.PNG)

Cache ve validation işlemlerini için aspect oriented programming ile gerçekleştirdim.

Aşağıda controller'larda bulunan methodlarının örnek ekran görüntüleri bulunmaktadır.

Not:
- DeleteOffer fonksiyonu tam doğru çalışmıyor. Yeni farkettiğim için düzeltmek için zamanım kalmayabilir. 

      Register ve Login:
   
![swagger](ScreenShots/Register1.PNG)
![swagger](ScreenShots/Register2.PNG)
![swagger](ScreenShots/Login1.PNG)
![swagger](ScreenShots/Login2.PNG)

      Offer:
   
![swagger](ScreenShots/PostOffer.PNG)
![swagger](ScreenShots/OfferPostPercentage.PNG)
![swagger](ScreenShots/OfferGetByUserId.PNG)
![swagger](ScreenShots/OfferGetAll.PNG)
![swagger](ScreenShots/OfferDelete.PNG)

      Product:
   
![swagger](ScreenShots/ProductPost.PNG)
![swagger](ScreenShots/ProductPut.PNG)
![swagger](ScreenShots/ProductGetAll.PNG)
![swagger](ScreenShots/ProductGetById.PNG)
![swagger](ScreenShots/ProductGetByCategoryId.PNG)
![swagger](ScreenShots/ProductBuy.PNG)
![swagger](ScreenShots/ProductDelete.PNG)

      Category:
   
![swagger](ScreenShots/CategoryPost.PNG)
![swagger](ScreenShots/CategoryPut.PNG)
![swagger](ScreenShots/CategoryGetAll.PNG)
![swagger](ScreenShots/CategoryGetById.PNG)
