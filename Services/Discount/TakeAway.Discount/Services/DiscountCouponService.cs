using Dapper;
using TakeAway.Discount.Context;
using TakeAway.Discount.Dtos;

namespace TakeAway.Discount.Services
{
    public class DiscountCouponService : IDiscountCouponService
    {
        public Task CreateDiscountCouponAsync(CreateDiscountCouponDto createDiscountCouponDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteDiscountCouponAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<GetByIdDiscountCouponDto> GetByIdDiscountCouponAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultDiscountCouponDto>> GetResultDiscountCouponAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateDiscountCouponAsync(UpdateDiscountCouponDto updateDiscountCouponDto)
        {
            throw new NotImplementedException();
        }
    }
}
