using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

namespace YazOkuluProjesi
{
    public partial class OgrenciGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["ogrId"].ToString());
            TxtId.Text = x.ToString();
            TxtId.Enabled = false;

            // sayfa yüklendiğinde hafızadaki bilgileri korumak için page is post back kullandım.

            if (Page.IsPostBack == false) {

                List<EntityOgrenci> ogrList = BllOgrenci.OgrenciDetayBll(x);

                TxtAd.Text = ogrList[0].Ad.ToString();
                TxtSoyad.Text = ogrList[0].Soyad.ToString();
                TxtNumara.Text = ogrList[0].Numara.ToString();
                TxtSifre.Text = ogrList[0].Sifre.ToString();
                TxtFotograf.Text = ogrList[0].Fotograf.ToString();

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();

            ent.Ad = TxtAd.Text;
            ent.Soyad= TxtSoyad.Text;
            ent.Numara = TxtNumara.Text;
            ent.Sifre= TxtSifre.Text;   
            ent.Fotograf= TxtFotograf.Text;
            ent.Id = Convert.ToInt32(TxtId.Text);

            BllOgrenci.OgrenciGuncelleBll(ent);

            Response.Redirect("OgrenciListesi.aspx");
        }
    }
}