using Microsoft.AspNetCore.Mvc;

namespace Blog.Components
{
    public class CategoriesViewComponent:ViewComponent
    {
        private readonly ApplicationDbcontext _db;

        public CategoriesViewComponent(ApplicationDbcontext db)
        {
            _db = db;   
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(_db.Categories.ToList());
        }
    }
}
