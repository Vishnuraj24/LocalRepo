using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository=employeeRepository;
        }

        public string Index()
        {
            return _employeeRepository.GetEmployee(1).Name;
        }

        public ViewResult Details(int ?id)
        {
            Employee model = _employeeRepository.GetEmployee(id??1);
            //ViewData["Employee"] = model;
            //ViewData["TitleName"] = "Employee Details";  //ViewData and ViewBag are smilar but one is dictonary other is a .convention
            //lets use the strongly types view
            return View(model);
        }

        public ViewResult EmployeeList()
        {
            var modelemployeeList = _employeeRepository.GetAllEmployees();
            return View(modelemployeeList);
        }
    }
}

















