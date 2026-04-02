using EmployeeManagementWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Text.Json;

namespace EmployeeManagementWeb.Controllers
{
    public class HomeController : Controller
    {
        

     public IActionResult Index()
     {
        var employees = _context.Employees.ToList();

        ViewBag.TotalEmployees = employees.Count;
        ViewBag.AvgSalary = employees.Count > 0 ? employees.Average(e => e.Salary) : 0;
        ViewBag.MaxSalary = employees.Count > 0 ? employees.Max(e => e.Salary) : 0;

        ViewBag.Names = JsonSerializer.Serialize(employees.Select(e => e.Name));
        ViewBag.Salaries = JsonSerializer.Serialize(employees.Select(e => e.Salary));

        return View();
     }

    public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        

    }
}
