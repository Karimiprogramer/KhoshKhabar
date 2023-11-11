using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services.Interfaces;

namespace Web_UI.Pages.Admin.News
{
    public class AddModel : PageModel
    {
        readonly IContentService _contentService;
        public AddModel(IContentService contentService)
        {
            _contentService = contentService;
        }
        [BindProperty]
        public Database.Models.Content Content { get; set; }

        public void OnGet()
        {
        }
    }
}
