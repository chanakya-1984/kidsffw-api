using Kidsffw.Contracts.Interfaces;
using Kidsffw.Models;
using Microsoft.Azure.Cosmos;

namespace Kidsffw.Repository.Repository;

public class CityRepository : ICityRepository
{
    private readonly Container _container;  
    
    public CityRepository(Container container)
    {
        _container = container;
    }
    
    
    public async IAsyncEnumerable<City> GetAllAsync()
    {
        var cities = _container.GetItemQueryIterator<City>(new QueryDefinition("SELECT * FROM c"));
        while(cities.HasMoreResults)
        {
            var cityResponse = await cities.ReadNextAsync();
            foreach(var city in cityResponse)
            {
                yield return city;
            }
        }
    }

    public Task<City> GetByPartitionKeyAsync(string partitionKey)
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(City entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(City entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(City entity)
    {
        throw new NotImplementedException();
    }

    public async IAsyncEnumerable<string> GetAllCityNames()
    {
        var names = _container.GetItemQueryIterator<City>(new QueryDefinition("select c.Name from c"));
        while(names.HasMoreResults)
        {
            var nameResponse = await names.ReadNextAsync();
            foreach(var name in nameResponse)
            {
                yield return name.CityName;
            }
        }
    }

    public IAsyncEnumerable<FashionEvent> GetAllFashionEvents()
    {
        throw new NotImplementedException();
    }

    public IAsyncEnumerable<FashionEvent> GatAllFashionEventsByCity(string city)
    {
        throw new NotImplementedException();
    }

    public IAsyncEnumerable<FashionEvent> GetAllActiveFashionEvents()
    {
        throw new NotImplementedException();
    }

    public IAsyncEnumerable<FashionEvent> GetAllActiveFashionEventsByCity(string city)
    {
        throw new NotImplementedException();
    }
}