using Newtonsoft.Json;

namespace Kidsffw.Models;

public record class Address(
    [property:JsonProperty(PropertyName = "id")]
    Guid Id,
    [property:JsonProperty(PropertyName = "line1")]
    string Line1,
    [property:JsonProperty(PropertyName = "line2")]
    string Line2,
    [property:JsonProperty(PropertyName = "state")]
    string State,
    [property:JsonProperty(PropertyName = "city")]
    string City,
    [property:JsonProperty(PropertyName = "location")]
    string Location,
    [property:JsonProperty(PropertyName = "area")]
    string Area,
    [property:JsonProperty(PropertyName = "pinCode")]
    string PinCode);