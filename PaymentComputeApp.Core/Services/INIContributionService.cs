using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentComputeApp.Core.Services
{
    public interface INIContributionService
    {
        decimal CalculateNIContribution(decimal totalAmount);
    }
}
