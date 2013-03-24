using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OneGridDemo.Infrastructures
{
    public class FlexiGridResult
    {
        public int page { get; set; }
        public int total { get; set; }
        public dynamic rows { get; set; }
    }
}