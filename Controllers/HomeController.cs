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

        
        public IActionResult Books()
        {
           var json = "{\"books\":[{\"title\":\"Book 1\", \"author\":\"Author1\", \"price\":762, \"inStock\":15},{\"title\":\"Book 2\", \"author\":\"Author2\", \"price\":100, \"inStock\":1},{\"title\":\"Book 3\", \"author\":\"Author3\", \"price\":185.5, \"inStock\":5},{\"title\":\"Book 4\", \"author\":\"Author 4\", \"price\":1748, \"inStock\":3},{\"title\":\"Book 5\", \"author\":\"Author 5\", \"price\":999, \"inStock\":20},{\"title\":\"Book 6\", \"author\":\"Author 6\", \"price\":499.5, \"inStock\":3},{\"title\":\"Book 7\", \"author\":\"Author 7\", \"price\":564.5, \"inStock\":0}]}";			
			
            var books = JsonConvert.DeserializeObject<Books>(json);


             return View(books);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
