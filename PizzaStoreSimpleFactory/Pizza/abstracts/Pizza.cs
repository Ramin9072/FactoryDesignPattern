namespace PizzaStoreSimpleFactory.Pizza.abstracts
{
    public abstract class Pizza
    {
        public string Name { get; protected set; }
        public string Dough { get; protected set; }
        public string Sauce { get; protected set; }
        public List<string> Toppings { get; protected set; } = new List<string>();

        public virtual void Bake()
        {
            Console.WriteLine($"Pizza {Name} Add Item {Dough} , {Sauce}");
        }
        public virtual void Cut()
        {
            Console.WriteLine($"Pizza {Name} Cut in pices");

        }
        public virtual void Box()
        {
            Console.WriteLine($"Pizza {Name} Ready to deliver");
        }

    }
}
