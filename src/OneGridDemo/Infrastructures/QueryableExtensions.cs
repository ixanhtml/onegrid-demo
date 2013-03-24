using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Web;
using System.Collections;

namespace OneGridDemo.Infrastructures
{
    public static class QueryableExtensions
    {
        public static FlexiGridResult ToDataSourceResult<T>(this IQueryable<T> enumerable, FlexiGridRequest request) where T : class
        {
            var take = request.rp;
            var skip = (request.page - 1) * request.rp;
            if (!string.IsNullOrWhiteSpace(request.qtype) && !string.IsNullOrWhiteSpace(request.query))
            {
                enumerable = enumerable.Where(string.Format("{0}.Contains(\"{1}\")", request.qtype, request.query));
            }
            var rows = enumerable.OrderBy(string.Format("{0} {1}", request.sortname, request.sortorder))
                .Skip(skip)
                .Take(take);

            return new FlexiGridResult
            {
                page = request.page,
                total = enumerable.Count<T>(),
                rows = rows
            };
        }
        //public static DatatableResult ToDataSourceResult<T>(this IQueryable<T> enumerable, DatatableRequest request) where T : class
        //{
        //    var take = request.iDisplayLength;
        //    var skip = request.iDisplayStart;
        //    //if (!string.IsNullOrWhiteSpace(request.qtype) && !string.IsNullOrWhiteSpace(request.query))
        //    //{
        //    //    enumerable = enumerable.Where(string.Format("{0}.Contains(\"{1}\")", request.qtype, request.query));
        //    //}
        //    var rows = enumerable.OrderBy(string.Format("{0} {1}", request.sSearch_0, request.sSortDir_0))
        //        .Skip(skip)
        //        .Take(take);

        //    return new DatatableResult
        //    {
        //        sEcho = request.sEcho,
        //        iTotalDisplayRecords = take,
        //        iTotalRecords = enumerable.Count(),
        //        aaData = rows.ToList()
        //    };
        //}
    }
}