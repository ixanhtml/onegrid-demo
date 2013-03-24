using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OneGridDemo.Infrastructures
{
    public class DatatableResult
    {
        public int sEcho { get; set; }
        public int iTotalRecords { get; set; }
        public int iTotalDisplayRecords { get; set; }
        public dynamic aaData { get; set; }
    }
}