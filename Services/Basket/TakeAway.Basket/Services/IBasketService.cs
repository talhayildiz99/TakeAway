using TakeAway.Basket.Dtos;

namespace TakeAway.Basket.Services
{
    public interface IBasketService
    {
        Task<BasketTotalDto> GetBasket(string UserId);
        Task SaveBasket(BasketTotalDto Basket);
        Task DeleteBasket(string UserId);
    }
}
