using Microsoft.AspNetCore.Mvc;

namespace OrganicMarket.App.ViewComponents;

public class HeaderViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        List<string> categories = new List<string>();
        categories.Add("Meyve");
        categories.Add("Sebze");
        categories.Add("Köy Ürünleri");
        categories.Add("Tereyağları");
        categories.Add("Pekmezler");
        categories.Add("Turşular");
        categories.Add("Yöresel");
        categories.Add("Süt ve Süt Ürünleri");
        categories.Add("Kahvaltılık");
        categories.Add("Kuruyemiş");
        categories.Add("Baharatlar");
        categories.Add("Lokumlar");
        categories.Add("Şire Ürünleri");
        categories.Add("Sucuklar");
        categories.Add("Zeytinler");
        categories.Add("Hurmalar");
        categories.Add("Kuru Meyveler");
        return await Task.Run(()=>View(categories));
    }
}
