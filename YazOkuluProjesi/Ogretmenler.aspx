<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.Master" CodeBehind="Ogretmenler.aspx.cs" Inherits="YazOkuluProjesi.Ogretmenler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">        
    </asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
<table class="table table-bordered table-hover">
           <tr>
                <th>Öğretmen Id</th>
                <th>Öğretmen Ad-Soyad</th>
                <th>Öğretmen Branşı</th>
                <th>İşlemler</th>
           </tr> 
           <tbody>
               <asp:Repeater ID="Repeater1" runat="server">
               <ItemTemplate>
               <tr>
                   <td><%#Eval("Basvuruid") %></td>
                   <td><%#Eval("Ograd") %></td>
                   <td><%#Eval("Dersad") %></td>                   
                   <td>
                       <asp:HyperLink NavigateUrl='<%#"~/OgretmenSil.aspx?OgrtId="+Eval("Basvuruid") %>' ID="HyperLink1" CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                       <asp:HyperLink NavigateUrl='<%#"~/OgretmenGuncelle.aspx?OgrtId="+Eval("Basvuruid") %>' ID="HyperLink2" CssClass="btn btn-success" runat="server">Güncelle</asp:HyperLink>
                   </td>
               </tr>
               </ItemTemplate>
               </asp:Repeater>
           </tbody>
       </table>    
</asp:Content>
