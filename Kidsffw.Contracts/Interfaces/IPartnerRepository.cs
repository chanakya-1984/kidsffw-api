using Kidsffw.Models;
using Kidsffw.Models.DTO;

namespace Kidsffw.Contracts.Interfaces;

public interface IPartnerRepository : IRepository<Partner>
{
    IAsyncEnumerable<RegistrationCoupon> GetRegistrationCouponsByPartnerPhoneNumber(string phoneNumber, bool onlyActive = true);
    Task<int> GetDiscountPercentageByCouponCode(string couponCode, bool onlyActive = true);
    Task AddNewRegistrationCoupon(RegistrationCoupon registrationCoupon, string partnerPhoneNumber);
    Task UpdateRegistrationCoupon(RegistrationCoupon registrationCoupon);
    Task DisableRegistrationCoupon(string couponCode);
    Task<PartnerContact> GetPartnerContactInformationByCouponId(int couponId);
}