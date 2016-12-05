using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public interface INotificationManager
    {
         void AddSubscriber(ISubscriber subscriber);
         void DeleteSubscriber(ISubscriber subscriber);
         void Notify(string message);
    }
}
