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
    public partial class Dersler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Ogrenci"] == null)
            {
                Response.Redirect("OgrenciGiris.aspx");
            }

            int x = Convert.ToInt32(Request.QueryString["id"].ToString());
            TextId.Text = x.ToString();
            TextId.Enabled = false;


            if (Page.IsPostBack == false)
            {
                List<EntityDers> EntDers = BLLDers.DersListesi();
                DropDownList1.DataSource = BLLDers.DersListesi();
                DropDownList1.DataTextField = "Dersad";
                DropDownList1.DataValueField = "Dersid";
                DropDownList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //TextBox1.Text = DropDownList1.SelectedValue.ToString();
            EntityBasvuruForm ent = new EntityBasvuruForm();
            ent.Basvuruogrid =Convert.ToInt32(TextId.Text);
            ent.Basvurudersid = int.Parse(DropDownList1.SelectedValue.ToString());
            BLLDers.TalepEkleBLL(ent);

            Response.Write("<script>alert('Ders Talebi Başarıyla Gerçekleşti')</script>");

            //PageUtility.MessageBox(this, "Success !");
        }
    }
}