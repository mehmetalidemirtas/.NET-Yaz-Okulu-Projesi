<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="OgretmenGuncelle.aspx.cs" Inherits="YazOkuluProjesi.OgretmenGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        
   </asp:Content>

   <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="form1" runat="server">
        <div class="form-group">
            
            <div>
                <asp:Label for="TextId" runat="server" Text="Öğretmen ID:" style="font-weight: bold"></asp:Label>
                <asp:TextBox ID="TextId" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="TextAd" runat="server" Text="Öğretmen Adı-Soyadı:" style="font-weight: bold"></asp:Label>
                <asp:TextBox ID="TextAd" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="TextBrans" runat="server" Text="Öğretmen Branşı:" style="font-weight: bold"></asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>
            <br />                    
        </div>
        <asp:Button ID="Button1" runat="server" Text="Kaydet"  CssClass="btn btn-warning" OnClick="Button1_Click" />
    </form>    
    </asp:Content>

