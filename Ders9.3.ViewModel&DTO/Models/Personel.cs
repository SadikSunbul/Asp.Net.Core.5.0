
//Entity Model

using Ders9._3.ViewModel_DTO.Models.ViewModels;

namespace Ders9._3.ViewModel_DTO.Models
{
    public class Personel
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public  string Pozisyon { get; set; }
        public int Maas { get; set; }
        public bool Medenihal { get; set; }


        #region Implict operator Overload ile Donusturme /Gizli/Bilinçsiz
        //2 sınıftan bırınde gerceklestırıle bılır 
        //public static implicit operator PersonelCreateViewModel(Personel personel) //Burada Personelı PersonelCreateViewModel buna dondurur
        //{
        //    return new  PersonelCreateViewModel
        //    { 
        //        Adi=personel.Adi,
        //         Soyadi=personel.Soyadi
        //    };
        //}

        //public static implicit operator Personel(PersonelCreateViewModel personel) //burada PersonelCreateViewModel ı Personel e dondurduk 
        //{
        //    return new Personel
        //    {
        //        Adi = personel.Adi,
        //         Soyadi = personel.Soyadi
        //    };
        //}
        #endregion
        #region Explict Operator Overload ile Dönusturme/Acık/Bilinçli
        public static explicit operator PersonelCreateViewModel(Personel personel) //Burada Personelı PersonelCreateViewModel buna dondurur
        {
            return new PersonelCreateViewModel
            {
                Adi = personel.Adi,
                Soyadi = personel.Soyadi
            };
        }

        public static explicit operator Personel(PersonelCreateViewModel personel) //burada PersonelCreateViewModel ı Personel e dondurduk 
        {
            return new Personel
            {
                Adi = personel.Adi,
                Soyadi = personel.Soyadi
            };
        }
        #endregion
    }
}
