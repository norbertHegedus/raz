using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace BLL.Menu
{
   public class AdminMenuItems
    {
       public static ArrayList FetchProductCategoriesMenuItems()
       {
           var ArticleAdminItems = new ArrayList();

           ArticleAdminItems.Add(new AdminMenuItem("Articles", "ManageArticles.aspx"));
           ArticleAdminItems.Add(new AdminMenuItem("New Article", "AddEditArticle.aspx"));
           ArticleAdminItems.Add(new AdminMenuItem("Categories", "ManageCategories.aspx"));
           ArticleAdminItems.Add(new AdminMenuItem("New Category", "AddEditCategory.aspx"));
           ArticleAdminItems.Add(new AdminMenuItem("Comments", "ManageComments.aspx"));
           ArticleAdminItems.Add(new AdminMenuItem("New Comment", "AddEditComment.aspx"));


           return ArticleAdminItems;
       }
   }
}
