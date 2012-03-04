<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Mvc3IoC.Models.Employee>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    List
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>List</h2>

<p>
    <%: Html.ActionLink("Create New", "Create") %>
</p>
<table>
    <tr>
        <th></th>
        <th>
            LastName
        </th>
        <th>
            FirstName
        </th>
        <th>
            Title
        </th>
        <th>
            TitleOfCourtesy
        </th>
        <th>
            BirthDate
        </th>
       
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: item.LastName %>
        </td>
        <td>
            <%: item.FirstName %>
        </td>
        <td>
            <%: item.Title %>
        </td>
        <td>
            <%: item.TitleOfCourtesy %>
        </td>
        <td>
            <%: String.Format("{0:g}", item.BirthDate) %>
        </td>
 
        </td>
    </tr>  
<% } %>

</table>

</asp:Content>

