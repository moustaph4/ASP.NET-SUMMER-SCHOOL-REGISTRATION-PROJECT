using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class BllDers
    {

        // Ders Listeleme
        public static List<EntityDersler> DersListeleBll()
        {
            return DalDers.DersListesi();
        }

        public static List<EntityOgrenci> OgrenciListeleBll()
        {
            return DalOgrenci.OgrenciListesi();
        }


        // NOT : ENTİTY katmanında değişkenler var, DAL katmanında değer atamaları yapıyoruz,
        // BLL katmanında şartları sağlarsa PRESENTATİON katmanına yollayıp değerleri döndürüyor.

        public static int talepOlusturBll(EntityBasvuruForm parametre)
        {
            if (parametre.BasvuruOgrId != null && parametre.BasvuruDersId != null)
            {
                return DalDers.TalepOlustur(parametre);
            }
            return -1;
        }
    }
}
