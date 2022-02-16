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
            if (Session["KullaniciAdi"] == null)
            {
                Response.Redirect("Giris.aspx");
            }

            int x = Convert.ToInt32(Request.QueryString["OgrId"].ToString());
            TextId.Text = x.ToString();
            TextId.Enabled = false;

            if (Page.IsPostBack == false)
            {
                List<EntityOgrenci> OgrList = BLLOgrenci.BllDetay(x);
                TextAd.Text = OgrList[0].Ad.ToString();
                TextSoyad.Text = OgrList[0].Soyad.ToString();
                TextNumara.Text = OgrList[0].Numara.ToString();
                TextSifre.Text = OgrList[0].Sifre.ToString();
                TextMail.Text = OgrList[0].Mail.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.Ad = TextAd.Text;
            ent.Soyad = TextSoyad.Text;
            ent.Numara = TextNumara.Text;
            ent.Sifre = TextSifre.Text;
            ent.Mail = TextMail.Text;
            ent.Ogrid = Convert.ToInt32(TextId.Text);
            BLLOgrenci.OgrenciGuncellleBLL(ent);
            Response.Redirect("OgrenciListesi.aspx");
        }
    }
}