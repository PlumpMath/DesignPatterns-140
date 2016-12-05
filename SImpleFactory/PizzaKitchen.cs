using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SImpleFactory
{
   public  abstract class PizzaKitchen
    {
        PizzaFactory factory;
        IPizza pizza;

        public PizzaKitchen(PizzaFactory factory)
        {
            this.factory = factory;
        }

        public void orderPizza(string type)
        {
            pizza = factory.GetPizza(type);
        }


        public void bake()
        {
            Console.WriteLine($" {pizza.Name} Pizza Baked");
        }
        public void cut()
        {
            Console.WriteLine("{pizza.Name} Pizza cut");
        }

        public void box()
        {
            Console.WriteLine(" {pizza.Name} Pizza boxed");
        }
    }

   
}
