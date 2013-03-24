using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using OneGridDemo.Models;
using OneGridDemo.Infrastructures;
using System.Collections;
using System.Linq.Dynamic;

namespace OneGridDemo.Controllers
{
    public class FlexiGridController : DbController
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ProductList(FlexiGridRequest request)
        {
            if (Request.IsAjaxRequest())
            {
                var linq = ctx.Product.Select(p => new ProductModel
                {
                    ProductID = p.ProductID,
                    Name = p.Name,
                    ProductNumber = p.ProductNumber,
                    Color = p.Color
                });
                return Json(linq.ToDataSourceResult(request));
            }
            return View();
        }
    }
}
