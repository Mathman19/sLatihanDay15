using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using waDay15Xpos.MVC.Models;

namespace waDay15Xpos.MVC.Controllers
{
    public class HtmlController : Controller
    {
        public static List<Employee> listEmployee = new List<Employee>()
            {
                new Employee() {id=1, Firstname="Budi", Lasttname="Wardi", Age=36, Address="Jakarta", Gender="Laki-laki" },
                new Employee() {id=2,Firstname="Wati", Lasttname="Saraswati", Age=29, Address="Jakarta", Gender="Perempuan"}
            };
        // GET: Html
        public ActionResult Index()
        {
            return View("Employees", listEmployee);
        }
        //Get: Create
        public ActionResult Create()
        {
            return View();
        }
        //Post: Create
        [HttpPost]
        public ActionResult Create(Employee model)
        {
            int newid = listEmployee.Max(e => e.id) + 1;
            model.id = newid;
            listEmployee.Add(model);
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            Employee model = listEmployee.Find(e => e.id == id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(Employee model)
        {
            int idx = listEmployee.FindIndex(e => e.id == model.id);
            listEmployee[idx] = model;
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            Employee model = listEmployee.Find(e => e.id == id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(Employee model)
        {
            int idx = listEmployee.FindIndex(e => e.id == model.id);
            listEmployee.Remove(listEmployee[idx]);
            return RedirectToAction("Index");
        }
        public ActionResult List()
        {
            return View();
        }

        public ActionResult Table()
        {
            return View();
        }        
    }
}