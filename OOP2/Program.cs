using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Individual individual1 = new Individual();
            individual1.Id = 1;
            individual1.CustomerNumber = "12345";
            individual1.FirstName = "Murat";
            individual1.LastName = "yıldız";
            individual1.TcNumber = "1234678910";

            Coorporate coorporate1 = new Coorporate();
            coorporate1.Id = 2;
            coorporate1.CustomerNumber = "54455";
            coorporate1.CompanyName = "CodeNet";
            coorporate1.TaxNumber = "12322563325";

            Customer customer3 = new Individual();
            Customer customer4 = new Coorporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer3);
            customerManager.Add(customer4);

        }
    }
}
