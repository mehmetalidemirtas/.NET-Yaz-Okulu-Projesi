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
    public partial class BasvuruSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["KullaniciAdi"] == null)
            {
                Response.Redirect("Giris.aspx");
            }
            int x = Convert.ToInt32(Request.QueryString["BasvuruId"]);
            Response.Write(x);
            EntityView ent = new EntityView();
            ent.Basvuruid = x;
            BLLBasvuruForm.BasvuruSilBLL(ent.Basvuruid);
            Response.Redirect("DersTalepListesi.aspx");
        }
    }
}