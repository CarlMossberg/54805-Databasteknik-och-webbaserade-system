using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Testing2.Controllers
{
    public class DropDownListTestController : Controller
    {
        public List<SelectListItem> lista = new List<SelectListItem>();

        public DropDownListTestController()
        {
            lista.Add(new SelectListItem { Text = "Select", Value = "0" });
            lista.Add(new SelectListItem { Text = "Adam", Value = "1" });
            lista.Add(new SelectListItem { Text = "BErtil", Value = "2" });
            lista.Add(new SelectListItem { Text = "Ceasar", Value = "3" });
            lista.Add(new SelectListItem { Text = "David", Value = "4" });
            lista.Add(new SelectListItem { Text = "Erik", Value = "5" });


        }
        // GET: DropDownListTest
        public ActionResult Index()
        {
            ViewData["country"] = lista;
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            try
            {
                int str = Convert.ToInt16(collection["feedback"]);
                Session["x"] = str;
                return RedirectToAction("Index2");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Index2()
        {
            int str = Convert.ToInt16(Session["x"]);

            ViewBag.Value = lista[str].Text + " och value är " + lista[str].Value;
            return View();
        }

    }
}