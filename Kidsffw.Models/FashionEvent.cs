using Newtonsoft.Json;

namespace Kidsffw.Models;

public record class FashionEvent(
    [property:JsonProperty(PropertyName = "id")]
    Guid Id,
    [property:JsonProperty(PropertyName = "name")]
    string Name,
    [property:JsonProperty(PropertyName = "eventType")]
    FashionEventType EventType, 
    [property:JsonProperty(PropertyName = "registrationStartDate")]
    DateTime? RegistrationStartDate,
    [property:JsonProperty(PropertyName = "registrationEndDate")]
    DateTime? RegistrationEndDate,
    [property:JsonProperty(PropertyName = "eventStartDate")]
    DateTime? EventStartDateTime,
    [property:JsonProperty(PropertyName = "eventEndDate")]
    DateTime? EventEndDateTime,
    [property:JsonProperty(PropertyName = "isRegistrationOpen")]
    bool IsRegistrationOpen,
    [property:JsonProperty(PropertyName = "eventStatus")]
    FashionEventStatus EventStatus,
    [property:JsonProperty(PropertyName = "eventVenue")]
    Address EventVenue
);