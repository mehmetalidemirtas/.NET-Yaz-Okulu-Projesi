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
    public partial class Giris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityGiris giris = new EntityGiris();
            giris.Kullaniciad = TextKullanici.Text;
            giris.Kullanicisifre = TextSifre.Text;            
            BLLGiris.GirisBLL(giris);
            if(Session["KullaniciAdi"]!=null)
            {
                Response.Redirect("OgrenciListesi.aspx");
            }
            else
            {
                Response.Redirect("Giris.aspx");
            }
        }
    }
}