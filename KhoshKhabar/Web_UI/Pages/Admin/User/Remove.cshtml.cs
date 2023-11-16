using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services.Interfaces;

namespace Web_UI.Pages.Admin.User
{
    public class RemoveModel : PageModel
    {
        readonly IUserService _userService;
        public RemoveModel(IUserService userService)
        {
            _userService = userService;
        }
        [BindProperty]
        public Database.Models.User? user {get; set;}
        public void OnGet(int id) 
        {
          var state =   _userService.DeleteUser(_userService.GetUserById(id));
        }
    }
}
