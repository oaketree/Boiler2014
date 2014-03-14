using Boiler.Class.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Boiler.Class.Concrete
{
    public class NewsContext : DbContext
    {
        public DbSet<News> News { get; set; }
    }
}
