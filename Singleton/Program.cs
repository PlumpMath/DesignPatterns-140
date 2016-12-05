using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            MyfabClass class1 = MyfabClass.GiveMeInstance();

            MyfabClass class2 = MyfabClass.GiveMeInstance();

            Console.WriteLine(class1.identifier);

            Console.WriteLine(class2.identifier);

            Console.ReadLine();
           
        }
    }
}
