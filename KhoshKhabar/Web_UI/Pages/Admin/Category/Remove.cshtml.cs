using Database.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services.Interfaces;

namespace Web_UI.Pages.Admin.Category
{
    public class RemoveModel : PageModel
    {
        readonly ICategoryService _categoryService;
        public RemoveModel(ICategoryService service)
        {
            _categoryService = service;
        }
        [BindProperty]
        public Database.Models.Category? Category { get; set; }
        public void OnGet(int ID)
        {
            Category = _categoryService.GetCategoryById(ID);
            var a = _categoryService.DeleteCategory(Category);
        }
    }
}
