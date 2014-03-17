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
        private DefaultContext context = new DefaultContext();
        public IQueryable<News> News
        {
            get
            {
                return context.News;
            }
        }
        public void saveNews(News news)
        {
                context.News.Add(news);
                context.SaveChanges();
        }
    }
}
