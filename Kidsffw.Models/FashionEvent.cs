namespace Kidsffw.Models;

public record class FashionEvent(
    Guid Id,
    string Name,
    FashionEventType EventType, 
    DateOnly RegistrationStartDate,
    DateOnly RegistrationEndDate,
    DateTime? EventStartDateTime,
    DateTime? EventEndDateTime,
    bool IsRegistrationOpen,
    FashionEventStatus EventStatus,
    Address EventVenue
):BaseEntity(Id);