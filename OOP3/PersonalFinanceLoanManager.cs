using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class PersonalFinanceLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Personal Finance Loan's payment plan calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
