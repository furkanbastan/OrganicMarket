using Microsoft.AspNetCore.Mvc;

namespace OrganicMarket.App.ViewComponents;

public class FooterViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        return await Task.Run(()=>View());
    }
}
