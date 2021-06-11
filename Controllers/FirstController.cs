using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApp.Controllers
{
    public class FirstController : Controller
    {
        public string Index()
        {
            return "Hello World";
        }

        public IActionResult Hello()
        {
            ViewBag.Message = "Hello World";
            return View();
        }

        public IActionResult Info()
        {
            Person person = new Person();
            person.Name = "Alex";
            person.Age = 49;
            person.Location = "Manaus-AM-Brazil";
            return View(person);
        }
    }
}
