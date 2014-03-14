using Boiler.Class.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Boiler.Web.Controllers
{
    public class NewsController : Controller
    {
        //
        // GET: /News/
        private INewsRepository repository;
        public NewsController(INewsRepository newsRepository)
        {
            repository = newsRepository;
        }
        public ActionResult List()
        {
            return View(repository.News);
        }

    }
}
