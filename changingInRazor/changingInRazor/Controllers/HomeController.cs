using changingInRazor.Models;
using changingInRazor.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace changingInRazor.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ProductService productService;

        public HomeController(ILogger<HomeController> logger, ProductService productService)
        {
            _logger = logger;
            this.productService = productService;
        }

        public IActionResult Index(int page = 1)
        {
            var products = productService.GetProducts();

            PageModel pageModel = new PageModel { PageSize = 4, ItemsCount = products.Count, CurrentPage = page };
            IndexViewModel indexViewModel = new IndexViewModel { Products = products, PageModel = pageModel };
            //var itemsPerPage = 4;
            //var pageCount = Math.Ceiling((double)products.Count / itemsPerPage);

            //ViewBag.PageCount = pageCount;
            return View(indexViewModel);
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