using Kidsffw.Models;

namespace Kidsffw.Contracts.Interfaces;

public interface ICityRepository : IRepository<City>
{
    IAsyncEnumerable<string> GetAllCityNames();
    IAsyncEnumerable<FashionEvent> GetAllFashionEvents();
    IAsyncEnumerable<FashionEvent> GatAllFashionEventsByCity(string city);
    IAsyncEnumerable<FashionEvent> GetAllActiveFashionEvents();
    IAsyncEnumerable<FashionEvent> GetAllActiveFashionEventsByCity(string city);
}