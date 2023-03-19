using Mapeamento.Data;
using Mapeamento.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Diagnostics;

namespace Mapeamento.Controllers
{
    public class HomeController : Controller
    {   
        private readonly DB_ESTUDO _dbContext;
        public HomeController (DB_ESTUDO Estudo)
        {
            _dbContext= Estudo;

        }
        public IActionResult Index()
        {


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
    }
}