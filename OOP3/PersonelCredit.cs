using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class PersonelCredit : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç kredisi hesaplandı");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
