using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyCms.Controllers
{
    public class SearchController : Controller
    {
        private MyCmsContext db = new MyCmsContext();
        private IPageRepository pageRepository;

        public SearchController()
        {
            pageRepository = new PageRepository(db);
        }





        // GET: Search
        public ActionResult Index(string q)
        {
            ViewBag.name = q;
            return View(pageRepository.SearchPage(q));
        }
    }
}