<%@ Page Title="" Language="C#" MasterPageFile="~/OgrenciGiris.Master" AutoEventWireup="true" CodeFile="OgrenciGiris.aspx.cs" Inherits="YazOkuluProjesi.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="form1" runat="server">
        <div class="form-group">
            <link rel="stylesheet" href="css/GirisCss.css">
		<div class="body"></div>
		<div class="grad"></div>
		<div class="header">
			<div>Sakarya Üniversitesi <span>Öğrenci Girişi</span></div>
		</div>
		<br>
		<div class="login" runat="server">			
			<asp:TextBox ID="TextKullanici" runat="server" type="text" placeholder="Kullanıcı Adı"></asp:TextBox>
			<br />
			<asp:TextBox ID="TextSifre" runat="server" type="password" placeholder="Şifre" ></asp:TextBox>
			<br />	
			<asp:Button ID="ButtonGiris" runat="server" class="button" Text="Giriş Yap" OnClick="Button1_Click" />
			<br /><br />
			<a href="Giris.aspx"  style="color: #3ae374; margin-left:110px" >Öğretmen Giriş</a>
		</div>            
        </div>        
    </form>    
</asp:Content>
