<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DersTalepListesi.aspx.cs" Inherits="YazOkuluProjesi.DersTalepListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" 
     runat="server">        
   </asp:Content>

   <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" 
       runat="server">
       <table class="table table-bordered table-hover">
           <tr>
                <th>Başvuru Id</th>
                <th>Öğrenci Adı</th>
                <th>Öğrenci Soyadı</th>
                <th>Ders Adı</th>               
                <th>İşlemler</th>               
           </tr> 
           <tbody>
               
               <asp:Repeater ID="Repeater1" runat="server">
               <ItemTemplate>
               <tr>               
                   <td><%#Eval("Basvuruid") %></td>                  
                   <td><%#Eval("Ograd") %></td>                   
                   <td><%#Eval("Ogrsoyad") %></td>                   
                   <td><%#Eval("Dersad") %></td>                 
                   <td>
                       <asp:HyperLink NavigateUrl='<%#"~/BasvuruSil.aspx?BasvuruId="+Eval("Basvuruid") %>' ID="HyperLink1" CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                       <asp:HyperLink NavigateUrl='<%#"~/BasvuruGuncelle.aspx?BasvuruId="+Eval("Basvuruid") %>' ID="HyperLink2" CssClass="btn btn-success" runat="server">Güncelle</asp:HyperLink>
                   </td>
                </tr>
               </ItemTemplate>
               </asp:Repeater>                                                          
           </tbody>
       </table>
    </asp:Content>
