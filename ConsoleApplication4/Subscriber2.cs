﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class Subscriber2 : ISubscriber
    {
        public void HandleNotification(string message)
        {
            Console.WriteLine($" Subscriber2: {message}");
        }
    }
}
