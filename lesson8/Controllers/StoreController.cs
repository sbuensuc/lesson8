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
        public string Index()
        {
            return "This is my store index page";
        }


        //Get: Store/Browse?genre=Rock
        public string Browse(string genre)
        {
            string message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
            return message;
        }

        //Get: /Store/Details/3
        public string Details(int id)
        {
            string message = HttpUtility.HtmlEncode("Store.Details, ID = " + id);
            return message;
        }
    }
}