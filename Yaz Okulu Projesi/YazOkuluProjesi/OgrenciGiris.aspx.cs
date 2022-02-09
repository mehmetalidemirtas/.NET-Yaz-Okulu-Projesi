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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {            
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityGiris giris = new EntityGiris();
            giris.Kullaniciad = TextKullanici.Text;
            giris.Kullanicisifre = TextSifre.Text;
            int DersList = BLLGiris.OgrenciId(giris);
            //int veri = DALGiris.OgrenciId(giris);
            BLLGiris.OgrenciGirisBLL(giris);            
            if (Session["Ogrenci"] != null)
            {                
                Response.Redirect("DersTalep.aspx?id="+ DersList);
            }
            else
            {
                Response.Redirect("OgrenciGiris.aspx");
            }
        }
    }
}