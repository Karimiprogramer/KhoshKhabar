using Microsoft.AspNetCore.Mvc;
namespace Web_UI.Components.Home

{
    public class TopNewsViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("_TopNews"));
        }
    }
}
