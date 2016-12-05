using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public  class NotificationManager : INotificationManager
    {

        public  List<ISubscriber> subscribers;

        public NotificationManager()
        {
            subscribers = new List<ISubscriber>();
        }


        public  void AddSubscriber(ISubscriber subscriber)
        {
           
            subscribers.Add(subscriber);
        }

        public  void DeleteSubscriber(ISubscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }

        public void Notify(string message)
        {
            NotifySubscriber(message);
        }

        private  void NotifySubscriber(string message)
        {
            foreach (var subscriber in subscribers)
            {
                subscriber.HandleNotification(message);
            }
        }
    }
}
