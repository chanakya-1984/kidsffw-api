namespace Kidsffw.Models;

public record class Address(
    Guid Id,
    string Line1,
    string Line2,
    string State,
    string City,
    string Location,
    string Area,
    string PinCode);