using Newtonsoft.Json;

namespace Kidsffw.Models;

public record class RegistrationCoupon(
    [property:JsonProperty(PropertyName = "id")]
    Guid Id,
    [property:JsonProperty(PropertyName = "couponCode")]
    string CouponCode,
    [property:JsonProperty(PropertyName = "discountPercent")]
    int DiscountPercent,
    [property:JsonProperty(PropertyName = "isActive")]
    bool IsActive,
    [property:JsonProperty(PropertyName = "creationDate")]
    DateTime CreatedDate,
    [property:JsonProperty(PropertyName = "deactivationDate")]
    DateTime? DeactivatedDate
);