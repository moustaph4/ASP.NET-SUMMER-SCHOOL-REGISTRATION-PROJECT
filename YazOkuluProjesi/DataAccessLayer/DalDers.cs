using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EntityLayer;

namespace DataAccessLayer
{
    public class DalDers
    {
        public static List<EntityDersler> DersListesi()
        {
            List<EntityDersler> degerler = new List<EntityDersler>();

            SqlCommand komut1 = new SqlCommand("Select * from tblDersler", Baglanti.bgl);

            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }

            SqlDataReader dr = komut1.ExecuteReader();

            while (dr.Read())
            {
                EntityDersler ent = new EntityDersler();
                ent.Id = Convert.ToInt32(dr["dersId"].ToString());
                ent.DersAd = dr["dersAd"].ToString();
                ent.Min = int.Parse(dr["dersMinKontenjan"].ToString());
                ent.Max = int.Parse(dr["dersMaxKontenjan"].ToString());

                degerler.Add(ent);
            }

            dr.Close();
            return degerler;
        }

        public static int TalepOlustur(EntityBasvuruForm parametre)
        {
            SqlCommand komut = new SqlCommand("insert into tblBasvuruForm (ogrenciId,dersId) values (@p1,@p2)", Baglanti.bgl);
            komut.Parameters.AddWithValue("@p1", parametre.BasvuruOgrId);
            komut.Parameters.AddWithValue("@p2", parametre.BasvuruDersId);

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            return komut.ExecuteNonQuery();
        }
    }
}
