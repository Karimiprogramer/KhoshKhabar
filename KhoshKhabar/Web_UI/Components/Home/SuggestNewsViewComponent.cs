using Microsoft.AspNetCore.Mvc;
namespace Web_UI.Components.Home
{
    public class SuggestNewsViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("_SuggestNews"));
        }
    }
}
