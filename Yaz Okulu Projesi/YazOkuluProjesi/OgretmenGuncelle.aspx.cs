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
    public partial class OgretmenGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["KullaniciAdi"] == null)
            {
                Response.Redirect("Giris.aspx");
            }
            int x = Convert.ToInt32(Request.QueryString["OgrtId"].ToString());
            TextId.Text = x.ToString();
            TextId.Enabled = false;

            if (Page.IsPostBack == false)
            {
                List<EntityDers> EntDers = BLLDers.DersListesi();
                DropDownList1.DataSource = BLLDers.DersListesi();
                DropDownList1.DataTextField = "Dersad";
                DropDownList1.DataValueField = "Dersid";
                DropDownList1.DataBind();

                List<EntityOgretmen> OgrtList = BLLOgretmen.BllDetay(x);
                TextAd.Text = OgrtList[0].Ogrtad.ToString();                                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgretmen ent = new EntityOgretmen();
            ent.Ogrtad = TextAd.Text;
            ent.Ogrtbrans = Convert.ToInt32(DropDownList1.SelectedValue.ToString());
            ent.Ogrtid = Convert.ToInt32(TextId.Text);
            BLLOgretmen.OgretmenGuncellleBLL(ent);
            Response.Redirect("Ogretmenler.aspx");
        }
    }
}