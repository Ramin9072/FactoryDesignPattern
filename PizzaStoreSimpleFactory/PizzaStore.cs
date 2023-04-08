using PizzaStoreSimpleFactory.PizzaFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreSimpleFactory
{
    public class PizzaStore
    {
        private readonly SimplePizzaFactory _factory;

        public PizzaStore(SimplePizzaFactory factory)
        {
            _factory = factory;
        }

        public PizzaStoreSimpleFactory.Pizza.abstracts.Pizza OrderPizza(string type)
        {
            PizzaStoreSimpleFactory.Pizza.abstracts.Pizza pizza = _factory.CreatePizza(type);
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza; 
        }
    }
}
