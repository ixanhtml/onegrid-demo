using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OneGridDemo.Infrastructures;
using OneGridDemo.Models;

namespace OneGridDemo.Controllers
{
    public class DatatableController : DbController
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ProductListAll()
        {
            if (Request.IsAjaxRequest())
            {
                var list = ctx.Product.Select(p => new ProductModel
                {
                    ProductID = p.ProductID,
                    Name = p.Name,
                    ProductNumber = p.ProductNumber,
                    Color = p.Color
                }).ToList();

                return Json(list);
            }
            return View();
        }

        [HttpPost]
        public ActionResult ProductList(DatatableRequest request)
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

                var list = linq.OrderBy(p => p.ProductID).Skip(request.iDisplayStart).Take(request.iDisplayLength).ToList();
                var list2 = new List<string[]>();
                foreach (var item in list)
                {
                    list2.Add(new string[] { item.ProductID.ToString(), item.Name, item.ProductNumber, item.Color });
                }

                return Json(new DatatableResult
                {
                    sEcho = request.sEcho,
                    iTotalDisplayRecords = linq.Count(),
                    iTotalRecords = linq.Count(),
                    aaData = list2
                });
            }
            return View();
        }
    }
}
