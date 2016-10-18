using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EasyAd.Core
{
    /// <summary>
    /// Database Context Class
    /// <remarsk>
    /// Created at 2016.10.18
    /// </remarsk>
    /// </summary>
    public class EasyAdContext : DbContext
    {
        public DbSet<MainData> MainDataTable { get; set; }

        public DbSet<WebSiteData> WebSiteDataTable { get; set; }

        public DbSet<WeiboData> WeiboDataTable { get; set; }

        public DbSet<WeixinData> WeixinDataTable { get; set; }

        public EasyAdContext():base("EasyAdContext")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<EasyAdContext>());
        }
    }
}