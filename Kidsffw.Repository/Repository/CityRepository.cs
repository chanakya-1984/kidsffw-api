using Kidsffw.Contracts.Interfaces;
using Kidsffw.Models;
using Kidsffw.Repository.Interface;
using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Cosmos.Linq;

namespace Kidsffw.Repository.Repository;

public class CityRepository : ICityRepository
{
    private readonly Container _container;  
    private const string ContainerName = "cities";
    public CityRepository(ICosmosContainer container)
    {
        _container = container.GetCosmosContainer(ContainerName);

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

    public async Task<City> AddAsync(City entity)
    {
        var result = await _container.CreateItemAsync(entity);
        return result;
    }

    public async Task<City> UpdateAsync(City entity)
    {
        // TODO: should be first fetch the entity and do a practical update only ??
        var result = await _container.UpsertItemAsync(entity, new PartitionKey(entity.CityName));
        return result;
    }

    public Task DeleteAsync(City entity)
    {
        throw new NotImplementedException();
    }

    public async IAsyncEnumerable<string> GetAllCityNames()
    {
        var names = _container.GetItemQueryIterator<City>(new QueryDefinition("select c.cityName from c"));
        while(names.HasMoreResults)
        {
            var nameResponse = await names.ReadNextAsync();
            foreach(var name in nameResponse)
            {
                yield return name.CityName;
            }
        }
    }
    public IAsyncEnumerable<FashionEvent> GetAllFashionEvents(bool isActive)
    {
        throw new NotImplementedException();
    }

    public async IAsyncEnumerable<FashionEvent[]> GatAllFashionEventsByCity(string city, bool isActive)
    {
        var _events = _container.GetItemQueryIterator<City>
            (new QueryDefinition("select c.events from c where c.cityName = @city").WithParameter("@city", city));
        while (_events.HasMoreResults)
        {
            var results = await _events.ReadNextAsync();
            foreach (var fashionEvent in results)
            {
                yield return fashionEvent.Events.Where(x=>x.IsRegistrationOpen == isActive).ToArray();
            }
        }
    }
}