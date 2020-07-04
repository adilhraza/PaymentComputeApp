using PaymentComputeApp.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentComputeApp.DataAccess.Repositories
{
    public interface IPaymentRepository:IRepository<PaymentRecord>
    {
        IEnumerable<AvgAmountYear> AvgTotalEarningsByYear();
        IEnumerable<AvgAmountYear> AvgTotalDeductionByYear();
        IEnumerable<AvgAmountYear> AvgNetPaymentByYear();
    }
}
