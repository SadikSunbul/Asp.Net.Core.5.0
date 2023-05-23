using AutoMapper;
using Ders9._3.ViewModel_DTO.Models;
using Ders9._3.ViewModel_DTO.Models.ViewModels;

namespace Ders9._3.ViewModel_DTO.AutoMappers
{
    public class MüşteriKayıtProfil:Profile
    {
        public MüşteriKayıtProfil()
        {
            CreateMap<MüşteriKayıt, Müşteri>();
            CreateMap<Müşteri,MüşteriKayıt > ();
        }
    }
}
