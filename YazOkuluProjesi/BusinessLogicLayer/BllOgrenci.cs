using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class BllOgrenci
    {
        // Öğrenci Ekleme
        public static int OgrenciEkleBll(EntityOgrenci p)
        {
            if (p.Ad != null && p.Soyad != null && p.Numara != null && p.Sifre != null && p.Fotograf != null)
            {
                return DalOgrenci.OgrenciEkle(p);
            }
            return -1;
        }

        // Öğrenci Listeleme
        public static List<EntityOgrenci> OgrenciListeleBll()
        {
            return DalOgrenci.OgrenciListesi();
        }

        // Öğrenci Silme
        public static bool OgrenciSilBll(int p)
        {
            if (p != null)
            {
                return DalOgrenci.OgrenciSil(p);
            }
            return false;
        }

        // Öğrenci Güncelleme
        public static List<EntityOgrenci> OgrenciDetayBll(int id)
        {
            return DalOgrenci.OgrenciDetay(id);
        }

        public static bool OgrenciGuncelleBll(EntityOgrenci p)
        {
            if (p.Ad != null && p.Ad != "" && p.Soyad != null && p.Soyad != "" && p.Numara != null && p.Numara != "" && p.Sifre != null && p.Sifre != "" && p.Fotograf != null && p.Fotograf != "" && p.Id > 0)
            {
                return DalOgrenci.OgrenciGuncelle(p);
            }

            return false;

        }
    }
}
