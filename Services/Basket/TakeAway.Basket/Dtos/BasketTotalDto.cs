namespace TakeAway.Basket.Dtos
{
    public class BasketTotalDto
    {
        public string UserId { get; set; }
        public List<BasketItemDto> BasketItems { get; set; }
        public decimal TotalPrice { get => BasketItems.Sum(x => x.Price * x.Quantity); }

    }
}
