using AzureDemoApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AzureDemoApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;
        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            Trace.TraceError("Something is definetely wrong here");
            Trace.TraceWarning("Something could be wrong here");
            Trace.TraceInformation("Entered {0}", this.GetType().Name);
            Debug.WriteLine("This is a debug only trace message");

            ViewBag.K1 = _configuration["K1"];
            ViewBag.K2 = _configuration["K2"];
            ViewBag.Name = _configuration["Name:FirstName"] + " " + _configuration["Name:LastName"];
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