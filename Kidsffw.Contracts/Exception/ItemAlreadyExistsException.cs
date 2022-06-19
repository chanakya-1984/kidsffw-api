namespace Kidsffw.Contracts.Exception;

public class ItemAlreadyExistsException: System.Exception
{
    public ItemAlreadyExistsException(){}
    public ItemAlreadyExistsException(string message) : base(message)
    {
    }
}