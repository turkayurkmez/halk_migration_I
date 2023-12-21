using changingInRazor.Services;
using Microsoft.AspNetCore.Mvc;

namespace changingInRazor.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly CategoryService categoryService;

        public MenuViewComponent(CategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            return View(categoryService.GetCategories());
        }
    }
}
