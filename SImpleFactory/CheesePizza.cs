using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SImpleFactory
{
    public class CheesePizza : IPizza
    {
        public string Name
        {
            get
            {
                return Name;
            }

            set
            {
                Name = "Cheese Pizza";
            }
        }
    }
}
