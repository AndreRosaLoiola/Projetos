using CrudFinal.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CrudFinal.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        
    }
}