<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DersEkle.aspx.cs" Inherits="YazOkuluProjesi.DersEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        
   </asp:Content>

   <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
       <form id="form1" runat="server">
        <div class="form-group">
            <div>
                <asp:Label for="TextAd" runat="server" Text="Ders Adı:" style="font-weight: bold"></asp:Label>
                <asp:TextBox ID="TextAd" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="TextMin" runat="server" Text="Min Kontenjan:" style="font-weight: bold"></asp:Label>
                <asp:TextBox ID="TextMin" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="TextMax" runat="server" Text="Max Kontenjan:" style="font-weight: bold"></asp:Label>
                <asp:TextBox ID="TextMax" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" Text="Kaydet" OnClick="Button1_Click" CssClass="btn btn-info" />
    </form>    
    </asp:Content>


