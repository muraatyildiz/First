using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonelCredit personelCredit = new PersonelCredit();
            //personelCredit.Calculate();

            //TransportCredit transportCredit = new TransportCredit();
            //transportCredit.Calculate();

            //MortgageLoan mortgageLoan = new MortgageLoan();
            //mortgageLoan.Calculate();

            ICreditManager personelCredit = new PersonelCredit();         

            ICreditManager transportCredit = new TransportCredit();           

            ICreditManager mortgageLoan = new MortgageLoan();

            ILoggerService databaseLoggerSevice = new DatabaseLoggerService();
            ILoggerService fileLoggerServise = new FileLoggerService();

            AplicationManager aplicationManager = new AplicationManager();
            aplicationManager.DoAplication(personelCredit,new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService() });

            List<ICreditManager> credits = new List<ICreditManager>() { personelCredit, transportCredit, mortgageLoan };
          //  aplicationManager.CreditInfo(credits);

        }
    }
}
