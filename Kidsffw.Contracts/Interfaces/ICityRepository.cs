using Kidsffw.Models;

namespace Kidsffw.Contracts.Interfaces;

public interface ICityRepository : IRepository<City>
{
    IAsyncEnumerable<string> GetAllCityNames();
    IAsyncEnumerable<FashionEvent> GetAllFashionEvents(bool isActive);
    IAsyncEnumerable<FashionEvent> GatAllFashionEventsByCity(string city,bool isActive);
}