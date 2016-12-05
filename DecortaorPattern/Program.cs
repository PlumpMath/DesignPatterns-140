using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecortaorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage bev = new AfricanBlend();
            Console.WriteLine(
                String.Format("{0} - ${1}",
                    bev.GetDescription(),
                    bev.GetCost()));

            bev = new HouseBlend();
            Console.WriteLine(
                String.Format("{0} - ${1}",
                    bev.GetDescription(),
                    bev.GetCost()));

            bev = new Cream(bev);
            Console.WriteLine(
                String.Format("{0} - ${1}",
                    bev.GetDescription(),
                    bev.GetCost()));

            bev = new Cream(bev);
            Console.WriteLine(
                String.Format("{0} - ${1}",
                    bev.GetDescription(),
                    bev.GetCost()));
            Console.ReadLine();

        }
    }
}
