using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalfinanceLoanManager = new PersonalFinanceLoanManager();
            ICreditManager transportationLoanManager = new TransportationLoanManager();
            ICreditManager housingLoanManager = new HousingLoanManager();

            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeApplication(personalfinanceLoanManager, databaseLoggerService);

            List<ICreditManager> credits = new List<ICreditManager>() {personalfinanceLoanManager, housingLoanManager };

            //applicationManager.MakeLoanPreInformation(credits);
        
        
        }
    }
}
