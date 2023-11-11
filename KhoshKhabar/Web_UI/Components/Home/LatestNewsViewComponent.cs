namespace Web_UI.Components.Home
{
    public class LatestNewsViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("_LatestNews"));
        }
    }
}
