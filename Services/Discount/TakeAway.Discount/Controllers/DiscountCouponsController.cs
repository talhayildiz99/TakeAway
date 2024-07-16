using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TakeAway.Discount.Dtos;
using TakeAway.Discount.Services;

namespace TakeAway.Discount.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountCouponsController : ControllerBase
    {
        private readonly IDiscountCouponService _discountCouponService;

        public DiscountCouponsController(IDiscountCouponService discountCouponService)
        {
            _discountCouponService = discountCouponService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDiscountCoupon()
        {
            var values = await _discountCouponService.GetResultDiscountCouponAsync();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDiscountCoupon(CreateDiscountCouponDto createDiscountCouponDto)
        {
            await _discountCouponService.CreateDiscountCouponAsync(createDiscountCouponDto);
            return Ok("Kupon başarıyla oluşturuldu");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteDiscountCoupon(int id)
        {
            await _discountCouponService.DeleteDiscountCouponAsync(id);
            return Ok("Kupon başarıyla silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateDiscountCoupon(UpdateDiscountCouponDto updateDiscountCouponDto)
        {
            await _discountCouponService.UpdateDiscountCouponAsync(updateDiscountCouponDto);
            return Ok("Kupon başarıyla güncellendi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDiscountCouponAsync(int id)
        {
            var value = await _discountCouponService.GetByIdDiscountCouponAsync(id);
            return Ok(value);
        }
    }
}
