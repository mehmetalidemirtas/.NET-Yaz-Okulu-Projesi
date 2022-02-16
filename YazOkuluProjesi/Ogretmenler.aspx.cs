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
    public partial class Ogretmenler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["KullaniciAdi"] == null)
            {
                Response.Redirect("Giris.aspx");
            }
            List<EntityView> OgrList = BLLOgretmen.BllOgretmenListesi();
            Repeater1.DataSource = OgrList;
            Repeater1.DataBind();
        }
    }
}