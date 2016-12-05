using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SImpleFactory
{
    public class PizzaFactory
    {
        IPizza pizza = null;

        public IPizza GetPizza(string type)
        {
            switch (type)
            {
                case "Cheese":
                    pizza = new CheesePizza();
                    break;
                case "Veggie":
                    pizza = new VeggiePizza();
                    break;
                default:
                    break;
            }

            return pizza;
        }
    }
}
