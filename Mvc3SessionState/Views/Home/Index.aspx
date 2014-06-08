<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<% using (Html.BeginForm("Index", "Home", FormMethod.Post))  %>
<% {  %>
 
    <%: Html.TextBox("message") %>
 
    <input type="submit" value="Submit"/>

<% } %>
</asp:Content>
