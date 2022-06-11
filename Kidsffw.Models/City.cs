namespace Kidsffw.Models;

public record class City(
    Guid Id, 
    string CityName, 
    string State, 
    string Country, 
    FashionEvent[] Events
    );