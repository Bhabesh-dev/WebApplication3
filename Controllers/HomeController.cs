using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository _employeeRepository;
        public HomeController( IEmployeeRepository employeeRepository )
        {
            _employeeRepository = employeeRepository;

        }

        public string Index()
        {
            return _employeeRepository.GetEmployee(2).Name;
        }
    }
}