namespace Web_UI.Components.Layout.Footer
{
    public class FooterViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("_Footer"));
        }
    }
}
