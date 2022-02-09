using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using BusinessLogicLayer;
using System.Windows;

namespace YazOkuluProjesi
{
    public partial class DersEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["KullaniciAdi"] == null)
            {
                Response.Redirect("Giris.aspx");
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityDers ent = new EntityDers();            
            ent.Dersad = TextAd.Text;
            ent.Minkontenjan = Convert.ToInt32(TextMin.Text);
            ent.Maxkontenjan = Convert.ToInt32(TextMax.Text);
            BLLDers.DersEkleBLL(ent);
            Response.Redirect("DersListesi.aspx");
        }
    }
}