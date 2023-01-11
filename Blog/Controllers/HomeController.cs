using Blog.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbcontext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbcontext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index(int? categoryId, int page = 1)
        {
            IQueryable<Despatch> despatches = _db.Despatches;

            if (categoryId != null)
            {
                despatches = despatches.Where(d => d.CategoryId == categoryId);
                ViewBag.Title = _db.Categories.Find(categoryId)?.Name;
            }

            int pageNumber = (int)Math.Ceiling((double)despatches.Count() / Constants.DESPATCH_PER_PAGE);

            despatches = despatches.Skip((page - 1) * Constants.DESPATCH_PER_PAGE).Take(Constants.DESPATCH_PER_PAGE);

            var vm = new HomeviewModel()
            {
                CategoryId = categoryId,
                Despatches = despatches.ToList(),
                Page = page,
                PageNumber = pageNumber
            };

            return View(vm);
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