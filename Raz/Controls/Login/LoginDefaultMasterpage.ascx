<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginDefaultMasterpage.ascx.cs"
    Inherits="Raz.Controls.Login.LoginDefaultMasterpage" %>
<asp:Panel ID="PanelArroundControll" runat="server">
    Sunt deja client
    <asp:Login ID="Login1" runat="server" FailureText="Incercati din nou!" OnLoggedIn="Login1_LoggedIn"
        OnLoginError="Login1_LoginError">
        <LayoutTemplate>
            <table cellpadding="0" border="0" cellspacing="0" style="width: 100%;">
                <tr>
                    <td>
                        E-mail<br />
                        <asp:TextBox ID="UserName" CssClass="TextBox" Width="240px" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName"
                            SetFocusOnError="true" ErrorMessage="" ToolTip="Email-ul e obligatoriu." ValidationGroup="LoginMasterPage"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="height: 10px;">
                    </td>
                </tr>
                <tr>
                    <td>
                        Parola<br />
                        <asp:TextBox ID="Password" CssClass="TextBox" Width="240px" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password"
                            SetFocusOnError="true" ErrorMessage="" ToolTip="Parola e obligatorie" ValidationGroup="LoginMasterPage"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="height: 10px;">
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <div style="color: #CC0000">
                            <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td style="height: 10px;">
                    </td>
                </tr>
                <tr>
                    <td align="left">
                        <asp:Button ID="LoginButton" runat="server" CssClass="ButtonLogin" CommandName="Login"
                            Text="Log In" ValidationGroup="LoginMasterPage" />
                    </td>
                </tr>
                <tr>
                    <td style="height: 10px;">
                    </td>
                </tr>
            </table>
        </LayoutTemplate>
    </asp:Login>
</asp:Panel>
