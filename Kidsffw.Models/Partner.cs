using Newtonsoft.Json;

namespace Kidsffw.Models;

public record class Partner(
    [property:JsonProperty(PropertyName = "id")]
    Guid Id,
    [property:JsonProperty(PropertyName = "name")]
    string Name,
    [property:JsonProperty(PropertyName = "email")]
    string Email,
    [property:JsonProperty(PropertyName = "phone")]
    string Phone,
    [property:JsonProperty(PropertyName = "address")]
    Address Address,
    [property:JsonProperty(PropertyName = "partnerType")]
    PartnerType PartnerType,
    [property:JsonProperty(PropertyName = "registrationCoupons")]
    RegistrationCoupon[] RegistrationCoupons
    );