using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TransportCredit : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Taşın kredisi hesaplandı");
        }

        public void DoSomething()
        {
            //Console.WriteLine("Taşın kredisi hesaplandı");
        }
    }
}
