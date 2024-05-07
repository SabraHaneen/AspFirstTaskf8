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
    }
}
