using TakeAway.WebUI.Dtos.CatalogDtos;

namespace TakeAway.WebUI.Services.CatalogServices.ProductServices
{
    public interface IProductService
    {
        Task<List<ResultProductDto>> GetAllProductsAsync();
    }
}
