using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentComputeApp.Core.Services
{
    public class TaxService:ITaxService
    {
        public decimal TaxAmount(decimal totalAmount)
        {
            decimal taxRate;
            decimal tax = 0;

            if (totalAmount <= 1042)
            {
                taxRate = 0;
                tax = totalAmount * taxRate;
            }
            else if (totalAmount > 1042 && totalAmount <= 3125)
            {
                taxRate = 0.2m;
                tax = (totalAmount - 1042) * taxRate;
            }
            else if (totalAmount > 3125 && totalAmount <= 12500)
            {
                taxRate = 0.4m;
                tax = (totalAmount - 3125) * taxRate + (3125 - 1042) * 0.2m;
            }
            else if (totalAmount > 12500)
            {
                taxRate = 0.45m;
                tax = (totalAmount - 12500) * taxRate + (12500 - 3125) * 0.4m + (3125 - 1042) * 0.2m;
            }

            return tax;
        }
    }
}
