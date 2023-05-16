using ders4.Models.ModelDateTyps;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ders4.Models
{
    // [ModelMetadataType(typeof(ProductMetaData))]  //oraya baglanır ve oradakı valıdatıonları kullanır sorumlulugu baska bı sınıfa yukledık burada burayıda fazla kullanmıyalım FluentValidation u kullanıcaz
    public class Product
    {
    
        public string ProductName { get; set; }
        public int Quentity { get; set; }
        public string Email { get; set; }
    }
}

#region Asp.NET Core 5.0 - FluentValidation Kütüphanesi İle Validation İşlemleri
//FluentValidation.AspNetCore kutuphanesı ındırılmelıdır projeye nugetten 
//bu ındırdıgımız seyı servıse eklememeız gerekrı burada kullanıcaksak .AddFluentValidation();
//AddFluentValidation(x=>x.RegisterValidatorsFromAssemblyContaining<Startup>()); içerideki ifade valıdatıonları otomatık bır sekılde kaydet dedık valıdatıonlaır bıyerde tutması gerekır  burada yazdıgımzda kendısı bulur ekler
//validaters dıye bır sınıf actık ve ıcerısınde ılgılı sınıf ıle ılgılı bır clas acıp clası AbstractValidator<...>dan turettık 
#endregion