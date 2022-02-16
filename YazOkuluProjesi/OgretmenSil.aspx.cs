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
    public partial class OgretmenSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["KullaniciAdi"] == null)
            {
                Response.Redirect("Giris.aspx");
            }
            int x = Convert.ToInt32(Request.QueryString["OgrtId"]);
            Response.Write(x);
            EntityOgretmen ent = new EntityOgretmen();
            ent.Ogrtid = x;
            BLLOgretmen.OgretmenSilBLL(ent.Ogrtid);
            Response.Redirect("Ogretmenler.aspx");
        }
    }
}