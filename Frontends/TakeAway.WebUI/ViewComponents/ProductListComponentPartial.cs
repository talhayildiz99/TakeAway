using Microsoft.AspNetCore.Mvc;
using TakeAway.WebUI.Services.CatalogServices.ProductServices;

namespace TakeAway.WebUI.ViewComponents
{
    public class ProductListComponentPartial : ViewComponent
    {
        private readonly IProductService _productService;

        public ProductListComponentPartial(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _productService.GetAllProductsAsync();
            return View(values);
        }
    }
}
