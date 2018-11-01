using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Testing2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            ViewBag.Message = "Nu är jag i den andra indexen (HttpPost)";
            if (collection["Min första"] != null)
            {
                ViewBag.Message += "Du tryckte på första knappen";
            }
            if (collection["Min andra"] != null)
            {
                ViewBag.Message += "Du tryckte på andra knappen";
            }
            ViewBag.Message += collection["Textruta"].ToString();
            return View();
        }

        public ActionResult Index2()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Index2(FormCollection collection)
        {
            Session["MittData"] = collection["Textruta"].ToString();
            return RedirectToAction("Index3");
        }
        public ActionResult Index3(FormCollection collection)
        {
            ViewBag.Message = Session["MittData"].ToString();
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}