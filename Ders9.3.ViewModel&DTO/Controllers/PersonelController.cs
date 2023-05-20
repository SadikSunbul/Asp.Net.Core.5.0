using AutoMapper;
using Ders9._3.ViewModel_DTO.Busineis;
using Ders9._3.ViewModel_DTO.Models;
using Ders9._3.ViewModel_DTO.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Ders9._3.ViewModel_DTO.Controllers
{
    public class PersonelController : Controller
    {
        public IMapper Mapper { get; }
        public PersonelController(IMapper mapper)
        {
            Mapper=mapper;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(PersonelCreateViewModel data)
        {
            //...
            if(ModelState.IsValid)
            {

            }
            else
            {

            }
            #region Manuel donusum
            //Personel p=new Personel()
            //{
            //    Adi=data.Adi,
            //     Soyadi=data.Soyadi
            //};
            #endregion
            #region Implict operator Overload ile Donusturme /Gizli/Bilinçsiz
            //Personel pesrsonel = data; //drekt atıyabıldık cunku cllasların ıcerısınde tanımladık bunu 
            //PersonelCreateViewModel personel1 = pesrsonel; //hata vemez
            #endregion
            #region Explict Operator Overload ile Dönusturme
            //Bilinçli dedıgımız kısım (cast operatoru) 
            //Personel p = (Personel)data;
            //PersonelCreateViewModel p2 = (PersonelCreateViewModel)p;
            #endregion
            #region Reflection ile Donusturme 
            //var data1 = TypConversion.Conversion<PersonelCreateViewModel, Personel>(data);

            //var data2 = TypConversion.Conversion<Personel, PersonelCreateViewModel>(data1);

            #endregion
            #region AutoMapper Kutuphanesı ıle donusturme 

            //NuGet\Install-Package AutoMapper -Version 12.0.1 yukledık 
            var p=Mapper.Map<Personel>(data);
            var p1=Mapper.Map<PersonelCreateViewModel>(p);

            #endregion
            return View();
        }

        public IActionResult Listele()
        {
            List<PersonelListeViewModel> personeller = new List<Personel>() {
            new Personel(){Adi="A", Soyadi="B"},
            new Personel(){Adi="A1", Soyadi="B"},
            new Personel(){Adi="A2", Soyadi="B"},
            new Personel(){Adi="A3", Soyadi="B"},
            new Personel(){Adi="A4", Soyadi="B"},
            new Personel(){Adi="A5", Soyadi="B"},
            new Personel(){Adi="A6", Soyadi="B"}
            }.Select(p=>new PersonelListeViewModel //personellerden secerek yenı bır clasa aktarma yaptık 
            {
                Adi=p.Adi,
                Soyadi=p.Soyadi,
                Pozisyon=p.Pozisyon
            }).ToList();

            return View(personeller);
        }

        public IActionResult Get()
        {
            var nesne = (new Personel(), new Ürün(), new Müşteri());
            return View(nesne);
        }
    }
}
