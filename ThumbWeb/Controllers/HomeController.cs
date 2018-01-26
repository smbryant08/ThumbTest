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
            

            //Controller method


            
            ViewBag.Message = "Saved!";

            return Index();
        }


        //for EACH method  there MUST be a corresponding view to it.
        public ActionResult ViewUsbs()
        {

           var usbItems= USBManager.GetAll();


            usbItems.Add(new USBItem() { Entity_issued_to = "to", IssueDate = DateTime.Now, Issued_by = "by", Quantity_issued = 233, Type_of_log = "log" });

            usbItems.Add(new USBItem() { Entity_issued_to = "to", IssueDate = DateTime.Now, Issued_by = "by", Quantity_issued = 233, Type_of_log = "log" });
            usbItems.Add(new USBItem() { Entity_issued_to = "to", IssueDate = DateTime.Now, Issued_by = "by", Quantity_issued = 233, Type_of_log = "log" });
            usbItems.Add(new USBItem() { Entity_issued_to = "to", IssueDate = DateTime.Now, Issued_by = "by", Quantity_issued = 233, Type_of_log = "log" });
            usbItems.Add(new USBItem() { Entity_issued_to = "to", IssueDate = DateTime.Now, Issued_by = "by", Quantity_issued = 233, Type_of_log = "log" });
            usbItems.Add(new USBItem() { Entity_issued_to = "to", IssueDate = DateTime.Now, Issued_by = "by", Quantity_issued = 233, Type_of_log = "log" });
            usbItems.Add(new USBItem() { Entity_issued_to = "to", IssueDate = DateTime.Now, Issued_by = "by", Quantity_issued = 233, Type_of_log = "log" });
            usbItems.Add(new USBItem() { Entity_issued_to = "to", IssueDate = DateTime.Now, Issued_by = "by", Quantity_issued = 233, Type_of_log = "log" });
            usbItems.Add(new USBItem() { Entity_issued_to = "to", IssueDate = DateTime.Now, Issued_by = "by", Quantity_issued = 233, Type_of_log = "log" });
            usbItems.Add(new USBItem() { Entity_issued_to = "to", IssueDate = DateTime.Now, Issued_by = "by", Quantity_issued = 233, Type_of_log = "log" });


            return View(usbItems);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}