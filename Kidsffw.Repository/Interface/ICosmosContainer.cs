using Microsoft.Azure.Cosmos;

namespace Kidsffw.Repository;

public interface ICosmosContainer
{
    Container GetCosmosContainer(string containerId);
}