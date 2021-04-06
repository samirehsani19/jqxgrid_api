using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace jqxgrid_api.Controllers
{
    public class TestController : Controller
    {
        DataContext ctx = new DataContext();
        public ActionResult Get()
        {
            var data = ctx.Employees.ToList();
            return View(data);
        }

        //public PartialViewResult GetAmount()
        //{
        //    var data = ctx.Employees.ToList();
        //    return PartialView("Test/_AjaxTest", data);
        //}


    }
}