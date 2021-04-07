using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
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
        public ActionResult Save()
        {

            var file = Request.Files[0];
            if (file != null)
            {
                var fileName = Path.GetFileName(file.FileName);
                file.SaveAs(Server.MapPath("/images/" + fileName));
                return Json(new { success = true }, JsonRequestBehavior.AllowGet);

            }

            return View();
        }

    }
}