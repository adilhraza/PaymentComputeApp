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

        public IEnumerable<TotalEarningsYear> TotalEarningsByYear()
        {
            return _context.TotalEarningsYear.FromSql("SELECT YEAR(PayDate) AS YearOfPayment, AVG(TotalEarnings) AS AvgTotalEarnings" +
                " FROM PaymentRecords GROUP BY YEAR(PayDate)").ToList();
        }
    }
}
