using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Thumb.Lib
{
    [Table("USBs_And_Labels_Log")]
    public class USBdb
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public string Type_of_log { get; set; }
        public DateTime IssueDate { get; set; }
        public string Issued_by { get; set; }
        public string Entity_issued_to { get; set; }
        public int Quantity_issued { get; set; }



    }
}