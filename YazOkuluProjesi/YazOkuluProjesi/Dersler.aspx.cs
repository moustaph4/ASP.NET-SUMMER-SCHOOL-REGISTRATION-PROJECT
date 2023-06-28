using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using BusinessLogicLayer;
using DataAccessLayer;

namespace YazOkuluProjesi
{
    public partial class Dersler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                List<EntityDersler> EntDers = BllDers.DersListeleBll();
                DropDownList1.DataSource = BllDers.DersListeleBll();
                DropDownList1.DataTextField = "DersAd";
                DropDownList1.DataValueField = "Id";
                DropDownList1.DataBind();

                DropDownList2.DataSource = BllOgrenci.OgrenciListeleBll();
                DropDownList2.DataTextField = "ad";
                DropDownList2.DataValueField = "id";
                DropDownList2.DataBind();

            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityBasvuruForm ent = new EntityBasvuruForm();
            ent.BasvuruOgrId = int.Parse(DropDownList2.SelectedValue.ToString());
            ent.BasvuruDersId = int.Parse(DropDownList1.SelectedValue.ToString());
            
            BllDers.talepOlusturBll(ent);   
        }
    }
}