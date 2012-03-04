<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Mvc3ValidationImpovemets.Models.Person>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Create

    
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">
    <script src="Url.Content('~/Content/jwysiwyg/jquery.wysiwyg.js')" type="text/javascript"></script>
    <link href="Url.Content('~/Content/jwysiwyg/jquery.wysiwyg.css')" rel="stylesheet" type="text/css" />

       <script type="text/javascript">
           (function ($) {
               $('#wysiwyg').wysiwyg({
                   controls: {
                       strikeThrough: { visible: true },
                       underline: { visible: true },

                       separator00: { visible: true },

                       justifyLeft: { visible: true },
                       justifyCenter: { visible: true },
                       justifyRight: { visible: true },
                       justifyFull: { visible: true },

                       separator01: { visible: true },

                       indent: { visible: true },
                       outdent: { visible: true },

                       separator02: { visible: true },

                       subscript: { visible: true },
                       superscript: { visible: true },

                       separator03: { visible: true },

                       undo: { visible: true },
                       redo: { visible: true },

                       separator04: { visible: true },

                       insertOrderedList: { visible: true },
                       insertUnorderedList: { visible: true },
                       insertHorizontalRule: { visible: true },

                       h4mozilla: { visible: true && $.browser.mozilla, className: 'h4', command: 'heading', arguments: ['h4'], tags: ['h4'], tooltip: "Header 4" },
                       h5mozilla: { visible: true && $.browser.mozilla, className: 'h5', command: 'heading', arguments: ['h5'], tags: ['h5'], tooltip: "Header 5" },
                       h6mozilla: { visible: true && $.browser.mozilla, className: 'h6', command: 'heading', arguments: ['h6'], tags: ['h6'], tooltip: "Header 6" },

                       h4: { visible: true && !($.browser.mozilla), className: 'h4', command: 'formatBlock', arguments: ['<H4>'], tags: ['h4'], tooltip: "Header 4" },
                       h5: { visible: true && !($.browser.mozilla), className: 'h5', command: 'formatBlock', arguments: ['<H5>'], tags: ['h5'], tooltip: "Header 5" },
                       h6: { visible: true && !($.browser.mozilla), className: 'h6', command: 'formatBlock', arguments: ['<H6>'], tags: ['h6'], tooltip: "Header 6" },

                       separator07: { visible: true },

                       cut: { visible: true },
                       copy: { visible: true },
                       paste: { visible: true }
                   }
               });
           })(jQuery);
    </script>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Create</h2>

<% using (Html.BeginForm("Create","Home",FormMethod.Post)) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>Fields</legend>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.FirstName) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.FirstName) %>
            <%: Html.ValidationMessageFor(model => model.FirstName) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.LastName) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.LastName) %>
            <%: Html.ValidationMessageFor(model => model.LastName) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Bio) %>
        </div>
        <div class="editor-field">
            <%: Html.TextAreaFor(model => model.Bio, new {cols="50",rows="10" })%>
            <%: Html.ValidationMessageFor(model => model.Bio) %>
        </div>

        <p>
            <input type="submit" value="Create" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("Back to List", "Index") %>
</div>

</asp:Content>

