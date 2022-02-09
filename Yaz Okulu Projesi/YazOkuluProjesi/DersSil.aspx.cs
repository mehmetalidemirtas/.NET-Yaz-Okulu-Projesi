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
    public partial class DersSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["KullaniciAdi"] == null)
            {
                Response.Redirect("Giris.aspx");
            }
            int x = Convert.ToInt32(Request.QueryString["DersId"]);
            Response.Write(x);
            EntityDers ent = new EntityDers();
            ent.Dersid = x;
            BLLDers.DersSilBLL(ent.Dersid);
            Response.Redirect("DersListesi.aspx");
        }
    }
}