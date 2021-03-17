using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class UserMessages
    {
        public static string UserNotFound = "Kullanıcı Bulunamadı";

        public static string PasswordError = "Şifre Hatalı";

        public static string SuccessfulLogin = "Giriş Başarılı";

        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";

        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";

        public static string AccessTokenCreated = "Access Token Oluşturuldu";

        public static string AuthorizationDenied = "Yetki Yok";
    }
}
