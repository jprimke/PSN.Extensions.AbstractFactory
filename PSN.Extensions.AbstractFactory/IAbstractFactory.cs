namespace PSN.Extensions.AbstractFactory;

public interface IAbstractFactory<T> where T : class
{
    T Create();
}