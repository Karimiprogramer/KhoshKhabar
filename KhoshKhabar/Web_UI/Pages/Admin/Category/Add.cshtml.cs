using Microsoft.AspNetCore.Mvc.RazorPages;
using Services.Interfaces;

namespace Web_UI.Pages.Admin.Category
{
    public class AddModel : PageModel
    {
        readonly ICategoryService _categoryService;
        public AddModel(ICategoryService service)
        {
            _categoryService = service;
        }
        [BindProperty]
        public Database.Models.Category Category { get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var state = _categoryService.InsertCategory(Category);
            if (state)
            {
                return RedirectToPage("Index", new { result = "success" });
            }
            else
            {
                return RedirectToPage("Index", new { result = "fail" });
            }
        }
    }
}
