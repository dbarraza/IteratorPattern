using IteratorPattern.Interfaces;

namespace IteratorPattern.Implementation
{
    /// <summary>
    /// El objecto iterador concreto, implementa los métodos de la interfaz Iterator y está encargado de controlar la posición acutal de los elementos del objeto agregado
    /// </summary>
    public class ConcreteIterator : Iterator
    {
        private ConcreteAggregate _items;
        private int _position;

        public ConcreteIterator(ConcreteAggregate items)
        {
            _items = items;
        }

        public bool HasNext()
        {
            return _position < _items.Count;
        }

        public object Next()
        {
            return _items[_position++];
        }
    }
}
