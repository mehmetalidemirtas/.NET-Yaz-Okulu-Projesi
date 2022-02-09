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
    public partial class OgretmenKullaniciKayit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityGiris ent = new EntityGiris();
            ent.Kullaniciad = TextKullanici.Text;
            ent.Kullanicisifre = TextSifre.Text;
            BLLGiris.KullaniciEkleBLL(ent);
            Response.Redirect("Giris.aspx");
        }
    }
}