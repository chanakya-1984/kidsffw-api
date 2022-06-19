using Kidsffw.Repository.Class;
using Kidsffw.Repository.Interface;
using Microsoft.Azure.Cosmos;

namespace Kidsffw.Repository.Impl;

public class CosmosContainer : ICosmosContainer
{
    private readonly string _databaseName;
    private readonly string _connectionString;
    private readonly CosmosClient _client;
    private readonly Database _database;
    public CosmosContainer(CosmosDbSettings settings)
    {
        _databaseName = settings.DatabaseName;
        _connectionString = settings.ConnectionString;
        _client = new CosmosClient(_connectionString);
        _database = _client.GetDatabase(_databaseName);
    }
    public Container GetCosmosContainer(string containerId)
    {
        return _database.GetContainer(containerId);
    }
}