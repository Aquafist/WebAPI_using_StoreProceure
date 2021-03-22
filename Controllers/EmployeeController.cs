using ApiStoreProcedure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApiStoreProcedure.Models;
using WebApplication_using_Store_Procedure;

namespace WebApplication_StoreProcedure.Controllers
{
    public class EmpController : Controller
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        // GET: Emp
        public ActionResult Index()
        {
            var getemprecorde = dc.EmployeeStoreProcedure(null, null, null, null, null, "Select").ToList();
            return View(getemprecorde);
        }

        // GET: Emp/Details/5
        public ActionResult Details(int id)
        {
            var empdetails = dc.EmployeeStoreProcedure(id, null, null, null, null, "Details").Single(x => x.EmployeeID == id);
            return View(empdetails);
        }

        // GET: Emp/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Emp/Create
        [HttpPost]
        public ActionResult Create(EmpClass collection)
        {
            try
            {
                // TODO: Add insert logic here
                dc.EmployeeStoreProcedure(null, collection.EmployeeName, collection.DepartmentID, collection.EmailID, collection.DOJ, "Insert");
                dc.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        // GET: Emp/Edit/5
        public ActionResult Edit(int id)
        {
            var empdetails = dc.EmployeeStoreProcedure(id, null, null, null, null, "Details").Single(x => x.EmployeeID == id);
            return View(empdetails);
        }

        // POST: Emp/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, EmpClass collection)
        {
            try
            {
                // TODO: Add update logic here
                dc.EmployeeStoreProcedure(id, collection.EmployeeName, collection.DepartmentID, collection.EmailID, collection.DOJ, "Update");
                dc.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Emp/Delete/5
        public ActionResult Delete(int id)
        {
            var empdetails = dc.EmployeeStoreProcedure(id, null, null, null, null, "Details").Single(x => x.EmployeeID == id);
            return View(empdetails);
        }

        // POST: Emp/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, EmpClass collection)
        {
            try
            {
                // TODO: Add delete logic here
                dc.EmployeeStoreProcedure(id, null, null, null, null, "Delete");
                dc.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
