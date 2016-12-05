using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SImpleFactory
{
    class VeggiePizza : IPizza
    {
        public string Name
        {
            get
            {
                return Name;
            }

            set
            {
                Name = "Veggie Pizza";
            }
        }
    }
}
