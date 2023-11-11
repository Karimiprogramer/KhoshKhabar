using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services.Interfaces;

namespace Web_UI.Pages.Admin.Category
{
    public class UpdateModel : PageModel
    {
        readonly ICategoryService _categoryService;
        public UpdateModel(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [BindProperty]
        public Database.Models.Category? Category { get; set; }
        public void OnGet(int ID)
        {
            Category = _categoryService.GetCategoryById(ID);
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            _categoryService.UpdateCategory(Category);
            return RedirectToPage("Index");
        }
    }
}
