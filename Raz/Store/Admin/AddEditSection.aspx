<%@ Page Title="" Language="C#" MasterPageFile="~/Store/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AddEditSection.aspx.cs" Inherits="Raz.Store.Admin.AddEditSection" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <h1 class="AdminTitle">Adauga / Modifica Pagini</h1>
    <table>
        <tr>
            <td>
                Categorie
            </td>
            <td>
            </td>
            <td>
                <asp:DropDownList ID="DropDownCategorySection" runat="server" DataSourceID="ObjectDataSourceGetSection"
                    DataTextField="Title" DataValueField="">
                </asp:DropDownList>
                <asp:ObjectDataSource ID="ObjectDataSourceGetSection" runat="server" SelectMethod="GetIerarhicArticleCategories"
                    TypeName="BLL.Blog.ArticleCategoryRepository"></asp:ObjectDataSource>
            </td>
        </tr>
    </table>
    
</asp:Content>
