using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lesson8.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            ViewBag.Message = "This is my store index page";
            return View();
        }


        //Get: Store/Browse?genre=Rock
        public ActionResult Browse(string genre)
        {
           ViewBag.Message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
            return View();
        }

        //Get: /Store/Details/3
        public ActionResult Details(int id)
        {
            ViewBag.Message = HttpUtility.HtmlEncode("Store.Details, ID = " + id);
            return View();
        }
    }
}