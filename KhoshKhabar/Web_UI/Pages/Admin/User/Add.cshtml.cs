using KarimHash;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services.Classes;
using Services.Interfaces;

namespace Web_UI.Pages.Admin.User
{
    public class AddModel : PageModel
    {
        readonly IUserService _userService;
        public AddModel(IUserService service)
        {
            _userService = service;
        }
        [BindProperty]
        public Database.Models.User? User { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            User.PassWordHash = SHA2.HashIt(User.PassWordHash);
            var state = _userService.InsertUser(User);
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
