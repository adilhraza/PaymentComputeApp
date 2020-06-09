using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentComputeApp.Core.Services
{
    public class StudentLoanService : ILoan
    {
        public decimal Calculate(decimal amount)
        {
            decimal studentLoanAmount = 0;

            if (amount > 1750 && amount < 2000)
            {
                studentLoanAmount = 15;
            }
            else if (amount >= 2000 && amount < 2250)
            {
                studentLoanAmount = 38;
            }
            else if (amount >= 2250 && amount < 2500)
            {
                studentLoanAmount = 60;
            }
            else if (amount >= 2500)
            {
                studentLoanAmount = 83;
            }

            return studentLoanAmount;
        }
    }
}
