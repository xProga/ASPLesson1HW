using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPLesson1HW.Models;

namespace ASPLesson1HW.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ListEmployees liEmp = new ListEmployees();
            liEmp.liEmp = Employees.GetEmployees();
            return View(liEmp);
        }

        [HttpGet]
        public IActionResult DetailViewEmployee(int IDEmployee)
        {
            Employees emp = Employees.GetEmployees().Where(x => x.IDEmployee == IDEmployee).FirstOrDefault();
            return View(emp);
        }
    }
}