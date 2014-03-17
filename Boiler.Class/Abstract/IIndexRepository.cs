using Boiler.Class.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Boiler.Class.Abstract
{
    public interface IIndexRepository
    {
        IQueryable<News> News { get; }
        IQueryable<Product> Product { get; }
    }
}
