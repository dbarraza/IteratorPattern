namespace IteratorPattern.Interfaces
{
    /// <summary>
    /// The iterator, interfaz que define los métodos para recorrer el objeto agregado
    /// </summary>
    public interface Iterator
    {
        bool HasNext();
        object Next();
    }
}
