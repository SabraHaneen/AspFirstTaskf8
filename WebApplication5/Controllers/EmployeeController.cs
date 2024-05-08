using Microsoft.AspNetCore.Mvc;
using WebApplication5.Data;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class EmployeeController : Controller
    {
       ApplicationDbContext context = new ApplicationDbContext();

        public IActionResult Index()
        {
            var employee = context.Employee.ToList();

            return View("index", employee);
            
        }
        public IActionResult CreateEmployee()
        {
            return View("CreateEmployee");
        }
        public IActionResult Store(Employee employee)
        {
            //return Content($"Store{employee.Name}--{employee.Title}--{employee.Age}");
            context.Employee.Add(employee);
            context.SaveChanges();
            
            return RedirectToActionPermanent("index");
        }
    }
}
