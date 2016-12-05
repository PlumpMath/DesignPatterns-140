using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Publisher
    {
        INotificationManager manager;
        public Publisher(INotificationManager manager)
        {
            this.manager = manager;
        }

        public void RaiseEvent(string message1)
        {
            string message = $" The message was {message1} at {DateTime.Now}";
            manager.Notify(message);
        }
    }
}
