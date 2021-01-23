using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class MortgageLoan : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Konut kredisi hesaplandı");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
