using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OneGridDemo.Infrastructures;

namespace OneGridDemo.Controllers
{
    public class DbController : Controller
    {
        protected DataContext ctx = new DataContext();
    }
}
