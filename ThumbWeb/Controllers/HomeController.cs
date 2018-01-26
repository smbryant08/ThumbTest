using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Thumb.Lib.USBs;

namespace ThumbWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

         
            return View();
        }
        [HttpPost]
        public ActionResult Index(string IssuedTo, string IssuedBy, string Quantity, string TypeOfLog)
        {

            USBManager.Add(TypeOfLog,DateTime.Now, IssuedBy, IssuedTo, Convert.ToInt32(Quantity));
            




            
            ViewBag.Message = "Saved!";

            return Index();
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