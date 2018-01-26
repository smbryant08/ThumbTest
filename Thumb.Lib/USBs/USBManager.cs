using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thumb.Lib.USBs
{
    public class USBManager
    {

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
    }
}
