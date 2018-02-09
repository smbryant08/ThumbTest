using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thumb.Lib.USBs
{
    //generic classes

    public class USBManager
    {
        public static List<USBItem> GetAll()
        {
            using (var db = new ThumbContext())
            {
                var usbList = (from row in db.USBs
                               select new USBItem
                               {

                                   Entity_issued_to = row.Entity_issued_to,
                                   Quantity_issued = row.Quantity_issued,
                                   IssueDate = row.IssueDate,
                                   Issued_by = row.Issued_by,
                                   Id = row.Id

                               }).ToList();

                return usbList;

            }
        }

        public static USBItem Get(long id)
        {
            using (var db = new ThumbContext())
            {
                var usbList = (from row in db.USBs
                               where row.Id == id
                               select new USBItem
                               {

                                   Entity_issued_to = row.Entity_issued_to,
                                   Quantity_issued = row.Quantity_issued,
                                   IssueDate = row.IssueDate,
                                   Issued_by = row.Issued_by,
                                   Id = row.Id

                               }).FirstOrDefault();

                return usbList;

            }
        }

        public static void Add(string Type_of_log,
        DateTime IssueDate,
        string Issued_by,
        string Entity_issued_to,
        int Quantity_issued)

        {
            using (var db = new ThumbContext())
            {
                USBdb usb = new USBdb();
                usb.Entity_issued_to = Entity_issued_to;
                usb.IssueDate = IssueDate;
                usb.Issued_by = Issued_by;
                usb.Quantity_issued = Quantity_issued;
                usb.Type_of_log = Type_of_log;
                db.USBs.Add(usb);



                db.SaveChanges();

            }

        }

        public static bool Edit(long id, string Type_of_log,
       DateTime IssueDate,
       string Issued_by,
       string Entity_issued_to,
       int Quantity_issued)

        {
            using (var db = new ThumbContext())
            {
                var item = (from row in db.USBs
                           where row.Id == id
                           select row).FirstOrDefault();


                item.Entity_issued_to = Entity_issued_to;
                item.IssueDate = IssueDate;
                item.Issued_by = Issued_by;
                item.Quantity_issued = Quantity_issued;

                item.Type_of_log = Type_of_log;


              return   db.SaveChanges()>0;

            }

        }
    }
}
