using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thumb.Lib.USBs
{
   public  class USBItem
    {
        public long Id { get; set; }

        public string Type_of_log { get; set; }
        public DateTime IssueDate { get; set; }
        public string Issued_by { get; set; }
        public string Entity_issued_to { get; set; }
        public int Quantity_issued { get; set; }

    }
}
