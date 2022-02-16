<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="OgretmenEkle.aspx.cs" Inherits="YazOkuluProjesi.OgretmenEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        
   </asp:Content>

   <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="form1" runat="server">
        <div class="form-group">
            
            <div>
                <asp:Label for="TextAd" runat="server" Text="Öğretmen Adı-Soyadı:" style="font-weight: bold"></asp:Label>
                <asp:TextBox ID="TextAd" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="TextBrans" runat="server" Text="Öğretmen Branşı:" style="font-weight: bold"></asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>                         
        </div>
        <asp:Button ID="Button1" runat="server" Text="Kaydet" OnClick="Button1_Click" CssClass="btn btn-info" />
    </form>    
    </asp:Content>

