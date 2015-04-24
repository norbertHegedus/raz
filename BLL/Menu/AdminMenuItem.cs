using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Menu
{
    public class AdminMenuItem
    {
        public string ImageURL { get; set; }

        public string MenuName { get; set; }

        public string URL { get; set; }

        public AdminMenuItem(string vName, string vURL)
        {
            this.MenuName = vName;
            this.URL = vURL;
        }

        public AdminMenuItem(string vName, string vImageURL, string vURL)
        {
            this.MenuName = vName;
            this.ImageURL = vImageURL;
            this.URL = vURL;
        }

    }
}
