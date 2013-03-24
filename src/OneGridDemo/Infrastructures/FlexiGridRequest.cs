using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OneGridDemo.Infrastructures
{
    public class FlexiGridRequest
    {
        public int page { get; set; }
        public string sortname { get; set; }
        public string sortorder { get; set; }
        public string qtype { get; set; }
        public string query { get; set; }
        public int rp { get; set; }
    }
}