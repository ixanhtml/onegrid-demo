using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using OneGridDemo.Datas;

namespace OneGridDemo.Infrastructures
{
    public class DataContext : DbContext
    {
        public IDbSet<Product> Product { get; set; }
    }
}