using PizzaStoreSimpleFactory.Pizza.abstracts;
using PizzaStoreSimpleFactory.PizzaFactory;
using PizzaStoreSimpleFactory;

internal class Program
{
    private static void Main(string[] args)
    {
        SimplePizzaFactory factory = new SimplePizzaFactory();
        PizzaStore store = new PizzaStore(factory);

        Pizza pizza = store.OrderPizza("cheese");
        Console.WriteLine("We ordered a " + pizza.Name);

        pizza = store.OrderPizza("veggie");
        Console.WriteLine("We ordered a " + pizza.Name);
    }
}