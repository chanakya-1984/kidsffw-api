using Newtonsoft.Json;

namespace Kidsffw.Models;

public record class City(
    [property:JsonProperty(PropertyName = "id")]
    Guid Id, 
    [property:JsonProperty(PropertyName = "cityName")]
    string CityName, 
    [property:JsonProperty(PropertyName = "state")]
    string State, 
    [property:JsonProperty(PropertyName = "country")]
    string Country, 
    [property:JsonProperty(PropertyName = "events")]
    FashionEvent[] Events
    );