using DependencyInjection_ingsoftwareii.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DependencyInjection_ingsoftwareii.Controllers
{
    public class HomeController : Controller
    {

        private readonly ITransient _transient;
        private readonly ISingleton _singleton;
        private readonly IScoped _scoped;


        public HomeController(ITransient transient, ISingleton singleton, IScoped scoped)
        {
            _transient = transient;
            _singleton = singleton;
            _scoped = scoped;
        }

        public IActionResult Index()
        {
            ViewBag.transient = _transient;
            ViewBag.singleton = _singleton;
            ViewBag.scoped = _scoped;
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