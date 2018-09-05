namespace IteratorPattern.Interfaces
{
    /// <summary>
    /// El Agregado, interfaz que define un método para crear el iterador
    /// </summary>
    public interface Aggregate
    {
        Iterator GetIterator();
    }
}
