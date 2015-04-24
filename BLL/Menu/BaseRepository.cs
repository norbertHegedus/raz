using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Security.Principal;
using System.Web;
using System.Web.Caching;

namespace BLL.Menu
{
    public abstract class BaseRepository 
    {
        private int _cacheDuration = 0;
        private string _cacheKey = "CacheKey";
        private string _connectionString = "Set the ConnectionString";
        private bool _enableCaching = true;
        public const int DefPageSize = 50;
        protected const int MAXROWS = 0x7fffffff;
    }
}
