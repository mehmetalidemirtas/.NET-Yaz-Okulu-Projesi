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
    public partial class DersGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["KullaniciAdi"] == null)
            {
                Response.Redirect("Giris.aspx");
            }
            int x = Convert.ToInt32(Request.QueryString["DersId"].ToString());
            TextId.Text = x.ToString();
            TextId.Enabled = false;

            if (Page.IsPostBack == false)
            {
                List<EntityDers> DersList = BLLDers.BllDersDetay(x);
                TextAd.Text = DersList[0].Dersad.ToString();
                TextMin.Text = DersList[0].Minkontenjan.ToString();
                TextMax.Text = DersList[0].Maxkontenjan.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityDers ent = new EntityDers();
            ent.Dersad = TextAd.Text;
            ent.Minkontenjan = Convert.ToInt32(TextMin.Text);
            ent.Maxkontenjan = Convert.ToInt32(TextMax.Text);
            ent.Dersid = Convert.ToInt32(TextId.Text);
            BLLDers.DersGuncellleBLL(ent);
            Response.Redirect("DersListesi.aspx");
        }
    }
}