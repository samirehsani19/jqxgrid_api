using jqxgrid_api.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jqxgrid_api.Controllers
{
    public class EmployeeController : Controller
    {
        DataContext ctx = new DataContext();

       // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetData()
        {
            var data = ctx.Employees.ToList<Employee>();
            return Json(new { rows= data}, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Add(Employee emp)
        {
            try
            {
                ModelState.Remove(nameof(emp.Id)); // remove id 
                ctx.Employees.Add(emp);
                ctx.SaveChanges();
                return RedirectToAction("GetData");
            }
            catch(Exception)
            {
                throw;
            }
        }
        
        public ActionResult Edit(Employee emp)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ctx.Entry(emp).State = EntityState.Modified;
                    ctx.SaveChanges();
                    return RedirectToAction("GetData");
                }

                return HttpNotFound();
            }
            catch (Exception)
            {
                throw;
            }
        } 
        
        public ActionResult Delete(int id)
        {
            try
            {
                var employee = ctx.Employees.FirstOrDefault(x => x.Id == id);
                if (employee != null)
                {
                    ctx.Employees.Remove(employee);
                    ctx.SaveChanges();
                    return RedirectToAction("GetData");
                }
                return HttpNotFound();
            }
            catch(Exception)
            {
                throw;
            }
        }

    }
}