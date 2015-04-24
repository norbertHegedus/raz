using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL.Menu;

namespace Raz.Store.Admin
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindMenuItems();
        }

        protected void BindMenuItems()
        {
            this.HyperLinkSections.NavigateUrl = (AdminMenuItems.FetchProductCategoriesMenuItems()[0] as AdminMenuItem).URL;
            this.lvSections.DataSource = (object)AdminMenuItems.FetchProductCategoriesMenuItems();
            this.lvSections.DataBind();
          
        }
    }
}