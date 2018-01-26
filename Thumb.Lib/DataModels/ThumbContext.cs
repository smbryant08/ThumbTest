using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Thumb.Lib
{
    public class ThumbContext : DbContext
    {


        //entity framework

        public DbSet<USBdb> USBs { get; set; }



    }
}