using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using phonemvc.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using phonebookghp;

namespace phonemvc.Controllers
{
    public class HomeController : Controller
    {
        
        
        public IActionResult Index()
        {
            
            return View();
        }

        
        public IActionResult Contacts()
        {


             return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
