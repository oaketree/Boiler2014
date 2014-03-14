using Boiler.Class.Abstract;
using Boiler.Class.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Boiler.Class.Concrete
{
    public class NewsRepository:INewsRepository
    {
        private NewsContext context = new NewsContext();
        public IQueryable<News> News
        {
            get
            {
                return context.News;
            }
        }
    }
}
