using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab4.Models;

namespace Lab4.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            Person p = new Person();
            return View(p);
        }
    }
}