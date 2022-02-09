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
    public partial class OgrenciSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["KullaniciAdi"] == null)
            {
                Response.Redirect("Giris.aspx");
            }
            int x = Convert.ToInt32(Request.QueryString["OgrId"]);
            Response.Write(x);
            EntityOgrenci ent = new EntityOgrenci();
            ent.Ogrid = x;
            BLLOgrenci.OgrenciSilBLL(ent.Ogrid);
            Response.Redirect("OgrenciListesi.aspx");
        }
    }
}