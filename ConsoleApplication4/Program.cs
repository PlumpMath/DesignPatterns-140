using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            INotificationManager manager = new NotificationManager();

            Subscriber1 sub1 = new Subscriber1();
            Subscriber2 sub2 = new Subscriber2();
            Subscriber3 sub3 = new Subscriber3();

            Publisher eventraiser = new Publisher(manager);

            manager.AddSubscriber(sub1);
            manager.AddSubscriber(sub2);
            manager.AddSubscriber(sub3);

            //Raise first event
            eventraiser.RaiseEvent("All are subscribed");

            //Sub3 unscribes

            manager.DeleteSubscriber(sub3);

            //Raise one more event

            Console.WriteLine("**************");

            eventraiser.RaiseEvent("Sub3 should be absent");

            Console.ReadLine();           

        }


      

    }
}
