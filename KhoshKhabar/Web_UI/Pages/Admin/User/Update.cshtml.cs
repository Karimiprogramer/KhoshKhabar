using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services.Interfaces;

namespace Web_UI.Pages.Admin.User
{
    public class UpdateModel : PageModel
    {
       private int id { get; set; }
        readonly IUserService _userService;
        public UpdateModel(IUserService userService)
        {
            _userService = userService;
        }
        [BindProperty]
        public DTOs.EditableUserDTO User { get; set; }
        public void OnGet(int ID)
        {
            id = ID;
            User = _userService.GetEditableUser(ID);
            User.PassWordHash = null;
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _userService.UpdateUser(User);
            return RedirectToPage("Index");
        }
    }
}
