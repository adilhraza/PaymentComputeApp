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
            => _context.AvgAmountYear.FromSql("SELECT YEAR(PayDate) AS Year, AVG(TotalEarnings) AS Amount" +
                " FROM PaymentRecords GROUP BY YEAR(PayDate)").ToList();

        public IEnumerable<AvgAmountYear> AvgTotalDeductionByYear()
            => _context.AvgAmountYear.FromSql("SELECT YEAR(PayDate) AS Year, AVG(TotalDeduction) AS Amount" +
                " FROM PaymentRecords GROUP BY YEAR(PayDate)").ToList();

        public IEnumerable<AvgAmountYear> AvgNetPaymentByYear()
            => _context.AvgAmountYear.FromSql("SELECT YEAR(PayDate) AS Year, AVG(NetPayment) AS Amount" +
                " FROM PaymentRecords GROUP BY YEAR(PayDate)").ToList();

        public AvgAmount AvgHourlyRateInfo()
            => _context.AvgAmount.FromSql("SELECT AVG(HourlyRate) AS Amount FROM PaymentRecords").FirstOrDefault();

        public AvgAmount AvgOvertimeEarningsInfo()
            => _context.AvgAmount.FromSql("SELECT AVG(OvertimeEarnings) AS Amount FROM PaymentRecords").FirstOrDefault();

        public AvgMultipleAmount AvgPaymentsInfoPercent()
        {
            var currentYear = DateTime.Today.Year;
            var lastYear = currentYear - 1;
            string sqlQuery = $@"SELECT IIF((SELECT AVG(TotalEarnings) FROM PaymentRecords 
                    WHERE YEAR(PayDate) = {currentYear}) = 0, 0,AVG(TotalEarnings)/
                    (SELECT AVG(TotalEarnings) FROM PaymentRecords 
                    WHERE YEAR(PayDate)={currentYear})*100) AS AvgTotalEarningsPercent,
                    IIF((SELECT AVG(NetPayment) FROM PaymentRecords 
                    WHERE YEAR(PayDate) = {currentYear})=0, 0, AVG(NetPayment)/
                    (SELECT AVG(NetPayment) FROM PaymentRecords 
                    WHERE YEAR(PayDate)={currentYear})*100) AS AvgNetPaymentPercent,
                    IIF((SELECT AVG(TotalDeduction) FROM PaymentRecords
                    WHERE YEAR(PayDate) = {currentYear})=0, 0, AVG(TotalDeduction)/
                    (SELECT AVG(TotalDeduction) FROM PaymentRecords 
                    WHERE YEAR(PayDate)={currentYear})*100) AS AvgTotalDeduction 
                    FROM PaymentRecords WHERE YEAR(PayDate)={lastYear}";

            return _context.AvgMultipleAmount.FromSql(sqlQuery).FirstOrDefault(); 
        }
    }
}
