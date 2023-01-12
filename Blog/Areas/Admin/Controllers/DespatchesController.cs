using Microsoft.AspNetCore.Mvc;

namespace Blog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DespatchesController : Controller
    {
        private readonly ApplicationDbcontext _db;

        public DespatchesController(ApplicationDbcontext db) 
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Despatches.Include(d => d.Category).ToList());
        }
    }
}
