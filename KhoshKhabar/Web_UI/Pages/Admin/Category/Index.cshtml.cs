using Database.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services.Interfaces;

namespace Web_UI.Pages.Admin.Category
{
    public class IndexModel : PageModel
    {
        readonly ICategoryService _categoryService;
        public IndexModel(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [BindProperty]
       public List<Database.Models.Category>? Categories { get; set; }
        public void OnGet()
        {
            Categories = _categoryService.GetAllCategories();
        }
    }
}
