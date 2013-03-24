using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OneGridDemo.Infrastructures
{
    public class FlexiGridClient
    {
        public FlexiGridClient()
        {
            sortorder = "asc";  // desc
            userpager = true;
            useRp = true;
            rp = 10;
            showTableToggleBtn = false;
            resizable = true;
            singleSelect = true;
        }

        public string url { get; set; }
        public string dataType { get; set; }
        public dynamic colModel { get; set; }
        public dynamic buttons { get; set; }
        public dynamic searchitems { get; set; }
        public string sortname { get; set; }
        public string sortorder { get; set; }
        public bool userpager { get; set; }
        public string title { get; set; }
        public bool useRp { get; set; }
        public int rp { get; set; }
        public bool showTableToggleBtn { get; set; }
        public bool resizable { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public bool singleSelect { get; set; }
    }
}