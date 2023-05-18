using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;

namespace _999999_ÖrnekDenemlerer.Models.DataBase
{
    public class DataBases
    {
        public static List<Kullanıcı> KullanıcıDatabase=new List<Kullanıcı>();
        private static int Idekle = 1;
        static DataBases()
        {
            KullanıcıDatabase.Add(new Kullanıcı { Id = 1, Email = "sadık@gmail.com", KullanıcıAdı = "Sadık.sunbul", Şİfre = "test1" });
        }

        public  static (bool,string) KullanıcıEkle(Kullanıcı kullanıcı)
        {
            if(kullanıcı!=null)
            {
                bool kontrol = MailKontorl(kullanıcı.Email);
                if (!kontrol)
                {
                    Idekle++;
                    kullanıcı.Id = Idekle;
                    KullanıcıDatabase.Add(kullanıcı);
                    return (true,"Kayıt basarılı");
                }
                else
                {

                    return (false,"bu maıl kullanılıyor");
                }
                
            }
            else
            {
                return (false,"kullanıcı bos geldı");
            }
        }

        public static bool KullanıcıcGiriş(string Email,string Şifre)
        {
            
            if(!string.IsNullOrEmpty(Email) &&!string.IsNullOrEmpty(Şifre))
            {
                if (!string.IsNullOrEmpty(Email))
                {
                    for (int i = 0; i < Idekle; i++)
                    {
                        var data = KullanıcıDatabase[i];
                        if (data.Email == Email)
                        {
                            if(data.Şİfre==Şifre)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                    return false;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool MailKontorl(string Email)
        {

            if (!string.IsNullOrEmpty(Email))
            {
                for (int i = 0; i < KullanıcıDatabase.Count; i++)
                {
                    var data = KullanıcıDatabase[i];
                    if (data.Email == Email)
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
