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
    public partial class BasvuruGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["KullaniciAdi"] == null)
            {
                Response.Redirect("Giris.aspx");
            }
            if (Page.IsPostBack == false)
            {
                List<EntityDers> EntDers = BLLDers.DersListesi();
                DropDownList1.DataSource = BLLDers.DersListesi();
                DropDownList1.DataTextField = "Dersad";
                DropDownList1.DataValueField = "Dersid";
                DropDownList1.DataBind();

                int x = Convert.ToInt32(Request.QueryString["BasvuruId"].ToString());
                TextId.Text = x.ToString();
                TextId.Enabled = false;
               
                List<EntityBasvuruForm> BasvuruList = BLLBasvuruForm.BllDetay(x);
                TextOgr.Text = BasvuruList[0].Basvuruogrid.ToString();
                TextOgr.Enabled = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityBasvuruForm ent = new EntityBasvuruForm();            
            ent.Basvurudersid = Convert.ToInt32(DropDownList1.SelectedValue.ToString());
            ent.Basvuruid = Convert.ToInt32(TextId.Text);
            ent.Basvuruogrid = Convert.ToInt32(TextOgr.Text);
            BLLBasvuruForm.BasvuruGuncelleBLL(ent);
            Response.Redirect("DersTalepListesi.aspx");
        }
    }
}