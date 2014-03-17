using Boiler.Class.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Boiler.Class.Abstract
{
    public interface  IProductRepository
    {
        IQueryable<Product> Product { get; }
        //void saveNews(News news);
    }
}
