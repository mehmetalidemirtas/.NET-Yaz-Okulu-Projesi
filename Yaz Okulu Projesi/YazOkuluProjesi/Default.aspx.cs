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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["KullaniciAdi"]==null)
            {
                Response.Redirect("Giris.aspx");
            }
        }
        protected void Button1_Click(object sender,EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.Ad = TextAd.Text;
            ent.Soyad = TextSoyad.Text;
            ent.Numara = TextNumara.Text;
            ent.Sifre = TextSifre.Text;
            ent.Mail = TextMail.Text;
            BLLOgrenci.OgrenciEkleBLL(ent);
            Response.Redirect("OgrenciListesi.aspx");
        }
    }
}