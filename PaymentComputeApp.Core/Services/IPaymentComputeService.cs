using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PaymentComputeApp.Core.Services
{
    public interface IPaymentComputeService
    {
        decimal OvertimeHours(decimal hoursWorked, decimal contractualHours);
        decimal ContractualEarnings(decimal contractualHours, decimal hoursWorked, decimal hourlyRate);
        decimal OvertimeRate(decimal hourlyRate);
        decimal OvertimeEarnings(decimal overtimeRate, decimal overtimeHours);
        decimal TotalEarnings(decimal overtimeEarnings, decimal contractualEarnings);
        decimal TotalDeductuon(decimal tax, decimal nic, decimal studentLoanRepayment, decimal unionFees);
        decimal NetPay(decimal totalEarnings, decimal totalDeduction);
        Task<decimal> StudentLoanRepaymentAmountAsync(int id, decimal totalAmount);
        Task<decimal> UnionFees(int id);
    }
}
