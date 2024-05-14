using DepartmentCRUDApp.Data;
using DepartmentCRUDApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DepartmentCRUDApp.Controllers
{
    public class DepartmentController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var departments = context.DepartmentSet.ToList();
            return View("CRUD", departments);
        }
        public IActionResult Details(int id)
        {
            var department = context.DepartmentSet.Find(id);
            return View("Details",department);
        }
        public IActionResult Create(int id)
        {
            return View("Create");
        }
        public IActionResult Store(Department department)
        {
            context.DepartmentSet.Add(department);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id) {
            var department = context.DepartmentSet.Find(id);
            context.DepartmentSet.Remove(department);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
