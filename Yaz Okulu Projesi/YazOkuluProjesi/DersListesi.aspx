<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DersListesi.aspx.cs" Inherits="YazOkuluProjesi.DersListesi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">        
    </asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
<table class="table table-bordered table-hover">
           <tr>
                <th>Ders Id</th>
                <th>Ders Adı</th>
                <th>Min Kontenjan</th>
                <th>Max Kontenjan</th>
           </tr> 
           <tbody>
               <asp:Repeater ID="Repeater1" runat="server">
               <ItemTemplate>
               <tr>
                   <td><%#Eval("Dersid") %></td>
                   <td><%#Eval("Dersad") %></td>
                   <td><%#Eval("Minkontenjan") %></td>                   
                   <td><%#Eval("Maxkontenjan") %></td>                   
                   <td>
                       <asp:HyperLink NavigateUrl='<%#"~/DersSil.aspx?DersId="+Eval("Dersid") %>' ID="HyperLink1" CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                       <asp:HyperLink NavigateUrl='<%#"~/DersGuncelle.aspx?DersId="+Eval("Dersid") %>' ID="HyperLink2" CssClass="btn btn-success" runat="server">Güncelle</asp:HyperLink>
                   </td>
               </tr>
               </ItemTemplate>
               </asp:Repeater>
           </tbody>
       </table>    
</asp:Content>

