using Blog.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
        public IActionResult Index(string? status)
        {
            ViewBag.Message = status == "added" ? "Despatch is created succesfully" :
              status == "edited" ? "Despatch is edited succesfully" :
              status == "deleted" ? "Despatch is deleted succesfully" : null;

            return View(_db.Despatches.Include(d => d.Category).ToList());
        }

        public IActionResult New()
        {
            UploadCategories();
            return View("Manage");
        }

        private void UploadCategories()
        {
            ViewBag.Categories = _db.Categories
                            .Select(c => new SelectListItem() { Value = c.Id.ToString(), Text = c.Name })
                            .ToList();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult New(DespatchViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var despatch = new Despatch()
                {
                    Title = vm.Title,
                    Content = vm.Content,
                    CategoryId = vm.CategoryId!.Value
                };

                _db.Despatches.Add(despatch);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index), new { status = "Added." });
            }
            UploadCategories();
            return View("Manage");
        }

        public IActionResult Edit(int id)
        {
            return View("Manage");
        }
    }
}
