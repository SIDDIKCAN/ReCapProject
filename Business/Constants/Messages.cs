using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç eklendi";
        public static string CarNameInvalid = "Araç ismi geçersiz";
        public static string CarListed = "Araçlar listelendi";
        public static string CarDeleted = "Araç başarılı bir şekilde silindi.";
        public static string CarUpdated = "Araç başarılı bir şekilde güncellendi.";
        public static string MaintenanceTime = "Sistem bakıma alınmıştır";
        public static string BrandAdded = "Marka başarılı bir şekilde eklendi.";
        public static string BrandDeleted = "Marka başarılı bir şekilde silindi.";
        public static string BrandListed= "Marka başarılı bir şekilde listelendi.";
        public static string BrandUpdated = "Marka başarılı bir şekilde güncellendi.";
        public static string BrandNameInvalid = "Marka ismi geçersiz.";

        public static string ColorAdded = "Renk başarılı bir şekilde eklendi.";
        public static string ColorDeleted = "Ren başarılı bir şekilde silindi.";
        public static string ColorListed = "Renk başarılı bir şekilde listelendi.";
        public static string ColorUpdated = "Renk başarılı bir şekilde güncellendi.";
        public static string ColorNameInvalid = "Renk ismi geçersiz.";

        public static string UserAdded = "Kullanıcı başarılı bir şekilde eklendi.";
        public static string UserDeleted = "Kullanıcı başarılı bir şekilde silindi.";
        public static string UserListed = "Kullanıcı başarılı bir şekilde listelendi.";
        public static string UserUpdated = "Kullanıcı başarılı bir şekilde güncellendi.";
        public static string UserNameInvalid = "Kullanıcı ismi geçersiz.";

        public static string CustomerAdded = "Müşteri başarılı bir şekilde eklendi.";
        public static string CustomerDeleted = "Müşteri başarılı bir şekilde silindi.";
        public static string CustomerListed = "Müşteri başarılı bir şekilde listelendi.";
        public static string CustomerUpdated = "Müşteri başarılı bir şekilde güncellendi.";
        public static string CustomerNameInvalid = "Müşteri ismi geçersiz.";

        public static string RentalAdded = "Müşteri başarılı bir şekilde eklendi.";
        public static string RentalDeleted = "Müşteri başarılı bir şekilde silindi.";
        public static string RentalListed = "Müşteri başarılı bir şekilde listelendi.";
        public static string RentalUpdated = "Müşteri başarılı bir şekilde güncellendi.";
        public static string RentalAddedError = "Müşteriden teslim alınmamaış araç kiraya verilemez.";
        public static string CarImageListed="Araç resimleri listelendi.";
        public static string CarImageAdded = "Araç fotoğrafı eklendi.";
        public static string CarImageDeleted = "Araç fotoğrafı silindi.";
        public static string CarImageUpdated = "Araç fotoğrafı güncellendi.";

        public static string CarImageCountCarError = "Bir ürünün en fazla 5 adet resmi olabilir.";
        public static string ImagesAdded = "Ürün fotoğrafı başarılı bir şekilde eklendi.";
        public static string  AuthorizationDenied="Yetkiniz yok";

        public static string UserRegistered = "Kayıt başarılı";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
