using Microsoft.EntityFrameworkCore;
using PaymentComputeApp.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PaymentComputeApp.DataAccess.Repositories
{
    public class PaymentRepository : Repository<PaymentRecord>, IPaymentRepository
    {
        public PaymentRepository(ApplicationDbContext context) : base(context) { }

        public IEnumerable<AvgAmountYear> AvgTotalEarningsByYear()
        {
            return _context.AvgAmountYear.FromSql("SELECT YEAR(PayDate) AS Year, AVG(TotalEarnings) AS Amount" +
                " FROM PaymentRecords GROUP BY YEAR(PayDate)").ToList();
        }

        public IEnumerable<AvgAmountYear> AvgTotalDeductionByYear()
        {
            return _context.AvgAmountYear.FromSql("SELECT YEAR(PayDate) AS Year, AVG(TotalDeduction) AS Amount" +
                " FROM PaymentRecords GROUP BY YEAR(PayDate)").ToList();
        }

        public IEnumerable<AvgAmountYear> AvgNetPaymentByYear()
        {
            return _context.AvgAmountYear.FromSql("SELECT YEAR(PayDate) AS YearOfPayment, AVG(NetPayment) AS Amount" +
                " FROM PaymentRecords GROUP BY YEAR(PayDate)").ToList();
        }
    }
}
