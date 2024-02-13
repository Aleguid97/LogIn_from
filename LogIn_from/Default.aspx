<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LogIn_from._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <asp:TextBox ID="UserName" placeholder="UserName" runat="server"></asp:TextBox>
        <asp:TextBox ID="Password" placeholder="Password" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Registrati" OnClick="Button1_Click" />
    </main>
</asp:Content>
