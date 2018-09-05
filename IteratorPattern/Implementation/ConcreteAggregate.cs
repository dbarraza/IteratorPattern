using System.Collections;
using IteratorPattern.Interfaces;

namespace IteratorPattern.Implementation
{
    /// <summary>
    /// El agregado concreto, que implementa la interfaz agregado y devuelve un IteradorConcreto para el AgregadoConcreto
    /// 
    /// </summary>
    public class ConcreteAggregate : Aggregate
    {
        private readonly ArrayList _elements = new ArrayList();

        public int Count { get { return _elements.Count; } }

        public Iterator GetIterator()
        {
            return new ConcreteIterator(this);
        }

        public void AddItem(object item)
        {
            _elements.Add(item);
        }

        public object this[int index]
        {
            get { return _elements[index]; }
        }
    }
}
