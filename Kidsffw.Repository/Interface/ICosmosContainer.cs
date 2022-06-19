using Microsoft.Azure.Cosmos;

namespace Kidsffw.Repository.Interface;

public interface ICosmosContainer
{
    Container GetCosmosContainer(string containerId);
}