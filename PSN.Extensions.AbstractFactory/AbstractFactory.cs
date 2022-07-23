namespace PSN.Extensions.AbstractFactory;

public class AbstractFactory<T> : IAbstractFactory<T> where T : class
{
    private readonly Func<T> _factory;

    public AbstractFactory(Func<T> factory)
    {
        _factory = factory;
    }
    
    public T Create()
    {
        return _factory();
    }
}