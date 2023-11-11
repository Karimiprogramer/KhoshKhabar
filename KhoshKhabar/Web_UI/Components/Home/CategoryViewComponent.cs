using Microsoft.AspNetCore.Mvc;
namespace Web_UI.Components.Home
{
    public class CategoryViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("_Category"));
        }
    }
}
