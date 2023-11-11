using Microsoft.AspNetCore.Mvc;

namespace Web_UI.Components.Layout.Header
{
    public class HeaderViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("_Header"));
        }
    }
}
