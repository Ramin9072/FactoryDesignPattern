using PizzaStoreSimpleFactory.Pizza;

namespace PizzaStoreSimpleFactory.PizzaFactory
{
    public class SimplePizzaFactory
    {
        public PizzaStoreSimpleFactory.Pizza.abstracts.Pizza CreatePizza(string type)
        {
            Pizza.abstracts.Pizza pizza = null;
            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza();
                    break;
                case "veggie":
                    pizza = new VeggiePizza();
                    break;
                case "clam":
                    pizza = new ClamPizza();
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza();
                    break;
            }
            return pizza;

        }
    }
}
