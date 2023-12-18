using basicDifferences.Models;
using basicDifferences.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace basicDifferences.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService productService;



        public HomeController(ILogger<HomeController> logger, IProductService productService)
        {
            this.productService = productService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Message = "Bu mesaj controller'dan";
            var names = productService.GetProductNames();
            return View(names);
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