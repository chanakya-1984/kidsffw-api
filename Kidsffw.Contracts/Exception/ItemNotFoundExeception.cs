namespace Kidsffw.Contracts.Exception;

public class ItemNotFoundException : System.Exception
{
    public ItemNotFoundException(){}
    
    public ItemNotFoundException(string message) : base(message)
    {
    }
}