using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OneGridDemo.Datas;
using OneGridDemo.Models;
using AutoMapper;

namespace OneGridDemo.Controllers
{
    public class HomeController : DbController
    {
        public HomeController()
        {
            Mapper.CreateMap<Product, ProductModel>();
        }

        public ActionResult Index()
        {
            var list = ctx.Product.Select(Mapper.DynamicMap<ProductModel>).Take(10).ToList();

            //var anom = ctx.Product.Select(p => new { p.ProductID, p.Name });
            //var list = anom.Select(Mapper.DynamicMap<ProductModel>).Take(10).ToList();

            return View();
        }
    }
}
