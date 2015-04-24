using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Raz.Controls.Login
{
    public partial class LoginDefaultMasterpage : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PanelArroundControll.Visible = true;
            {
                try
                {
                    TextBox boxLoginPassword = this.GetTextBoxLoginPassword();
                    if (boxLoginPassword != null)
                    {
                        Button buttonLogin = this.GetButtonLogin();
                        if (buttonLogin != null)
                            boxLoginPassword.Attributes.Add("onkeydown", "if (event.keyCode == 13) document.getElementById('" + buttonLogin.ClientID + "').focus();");
                    }
                }
                catch
                {
                }
                            
            }
        }
        public TextBox GetTextBoxLoginPassword()
        {
            try
            {
                return this.Login1.FindControl("Password") as TextBox;
            }
            catch
            {
                return (TextBox)null;
            }
        }

        public Button GetButtonLogin()
        {
            try
            {
                return this.Login1.FindControl("LoginButton") as Button;
            }
            catch
            {
                return (Button)null;
            }
        }
        protected void Login1_LoggedIn(object sender, EventArgs e)
        {
            if (!this.Context.Profile.IsAnonymous)
                this.PanelArroundControll.Visible = false;
            TextBox textBox = (TextBox)this.Login1.FindControl("UserName");
            if (Roles.IsUserInRole(textBox.Text, "Administrator"))
                this.Login1.DestinationPageUrl = "~/Store/Admin/DefaultAdmin.aspx";
            else if (Roles.IsUserInRole(textBox.Text, "User"))
                this.Login1.DestinationPageUrl = this.Request.Url.PathAndQuery;
            else
                this.Login1.DestinationPageUrl = "~/";
        }

        protected void Login1_LoginError(object sender, EventArgs e)
        {
            this.Page.ClientScript.RegisterClientScriptBlock(this.Page.GetType(), "LoginScript", "$(document).ready(function(){$('#myModal').reveal();});", true);
        }
    }
}