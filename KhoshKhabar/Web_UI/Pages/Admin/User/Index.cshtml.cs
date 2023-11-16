using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services.Interfaces;

namespace Web_UI.Pages.Admin.User
{
    public class IndexModel : PageModel
    {
        readonly IUserService _userService;
        public IndexModel(IUserService userService)
        {
            _userService = userService;
        }
        [BindProperty]
        public List<Database.Models.User>? Users { get; set; }
        public void OnGet()
        {
            Users = _userService.GetAllUsers();
        }
    }
}
