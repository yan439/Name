using Microsoft.AspNetCore.Mvc;
using Projet2.Models;
using System.Collections.Generic;

namespace Projet2.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult ServiceIndex()
        {
            List<Service> services = new List<Service>();

            return View(services);
        }
    }
}
