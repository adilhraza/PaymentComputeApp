using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentComputeApp.Core.Services
{
    public class NIContributionService:INIContributionService
    {
        public decimal CalculateNIContribution(decimal totalAmount)
        {
            decimal NIC = 0;

            if (totalAmount < 719)
            {
                NIC = NoContribution();
            }
            else if (totalAmount >= 719 && totalAmount <= 4167)
            {
                NIC = BaseContribution(totalAmount - 719);
            }
            else if (totalAmount > 4167)
            {
                NIC = PremiumContribution(4167 - 719) + BaseContribution(totalAmount - 4167);
            }

            return NIC;
        }

        private decimal NoContribution()
        {
            return 0;
        }

        private decimal BaseContribution(decimal amount)
        {
            decimal NIRate = .12m;
            return amount * NIRate;
        }

        private decimal PremiumContribution(decimal amount)
        {
            decimal NIRate = .02m;
            return amount * NIRate;
        }
    }
}
