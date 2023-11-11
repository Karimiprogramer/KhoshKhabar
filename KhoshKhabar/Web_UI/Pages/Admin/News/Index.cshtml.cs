using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services.Classes;
using Services.Interfaces;

namespace Web_UI.Pages.Admin.News
{
    public class IndexModel : PageModel
    {
       readonly IContentService _contentService;
        public IndexModel(IContentService contentService)
        {
            _contentService = contentService;
        }
        [BindProperty]
        public List<Database.Models.Content>? Contents { get; set; }
        public void OnGet()
        {
            Contents = _contentService.GetAllNews();
        }
    }
}
