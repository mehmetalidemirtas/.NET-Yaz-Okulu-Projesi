using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using EntityLayer;
using BusinessLogicLayer;
using System.Windows;

namespace YazOkuluProjesi
{
    public partial class OgretmenEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["KullaniciAdi"] == null)
            {
                Response.Redirect("Giris.aspx");
            }
            if (Page.IsPostBack == false)
            {
                List<EntityDers> EntDers = BLLDers.DersListesi();
                DropDownList1.DataSource = BLLDers.DersListesi();
                DropDownList1.DataTextField = "Dersad";
                DropDownList1.DataValueField = "Dersid";
                DropDownList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgretmen ent = new EntityOgretmen();
            ent.Ogrtad = TextAd.Text;
            ent.Ogrtbrans = int.Parse(DropDownList1.SelectedValue.ToString()); ;            
            BLLOgretmen.OgretmenEkleBLL(ent);
            Response.Redirect("Ogretmenler.aspx");
        }
    }
}