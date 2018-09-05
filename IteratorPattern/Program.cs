using System;
using IteratorPattern.Implementation;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var concreteAgregate = new ConcreteAggregate();
            concreteAgregate.AddItem("Item 1");
            concreteAgregate.AddItem("Item 2");
            concreteAgregate.AddItem("Item 3");
            concreteAgregate.AddItem("Item 4");
            concreteAgregate.AddItem("Item 5");

            var concreteIterator = concreteAgregate.GetIterator();

            while(concreteIterator.HasNext())
                Console.WriteLine(concreteIterator.Next());
        }
    }
}
