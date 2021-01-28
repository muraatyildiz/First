using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class AplicationManager
    {
        public void DoAplication(ICreditManager creditManager , List<ILoggerService> loggerService)
        {
            creditManager.Calculate();
            foreach(var logger in loggerService)
            {
                logger.Log();
            }

        }
        public void CreditInfo(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
