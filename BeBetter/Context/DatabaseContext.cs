using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BeBetter.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() 
            : base("Database1")
        {
           Database.SetInitializer<DatabaseContext>(null);
        }

        public DbSet<ArticleModel> Articles { get; set; }
    }
}
