using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Thumb.Lib.USBs;

namespace ThumbWeb.Controllers
{
    public class USBController : Controller
    {

        public ActionResult Add()
        {


            return View();
        }
        // GET: USB
        [HttpPost]
        public ActionResult Add(string IssuedTo, string IssuedBy, string Quantity, string TypeOfLog)
        {

            USBManager.Add(TypeOfLog, DateTime.Now, IssuedBy, IssuedTo, Convert.ToInt32(Quantity));


            //Controller method



            ViewBag.Message = "Saved!";

            return Add();
        }

        public ActionResult Edit(long id)
        {
          var item =   USBManager.Get(id);

            return View(item);
        }
        // GET: USB
        [HttpPost]
        public ActionResult Edit(long id, string IssuedTo, string IssuedBy, string Quantity, string TypeOfLog)
        {

            USBManager.Edit(id, TypeOfLog, DateTime.Now, IssuedBy, IssuedTo, Convert.ToInt32(Quantity));


            //Controller method



            ViewBag.Message = "Saved!";

            return Redirect("ViewUsbs");
        }

        //for EACH method  there MUST be a corresponding view to it.
        public ActionResult ViewUsbs()
        {

            var usbItems = USBManager.GetAll();


            return View(usbItems);
        }
    }
}