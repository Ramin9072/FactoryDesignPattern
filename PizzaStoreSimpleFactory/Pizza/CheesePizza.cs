using System.Xml.Linq;

namespace PizzaStoreSimpleFactory.Pizza
{
    public class CheesePizza : PizzaStoreSimpleFactory.Pizza.abstracts.Pizza
    {
        public CheesePizza()
        {
            Name = "Cheese Pizza";
            Dough = "Regular Crust";
            Sauce = "Marinara Pizza Sauce";

            Toppings.Add("Fresh Mozzarella");
            Toppings.Add("Parmesan");
        }
    }
}