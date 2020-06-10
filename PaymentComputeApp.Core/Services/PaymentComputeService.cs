using PaymentComputeApp.DataAccess.Repositories;
using PaymentComputeApp.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PaymentComputeApp.Core.Services
{
    public class PaymentComputeService:IPaymentComputeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILoan _loan;

        public PaymentComputeService(IUnitOfWork unitOfWork, ILoan loan)
        {
            _unitOfWork = unitOfWork;
            _loan = loan;
        }

        public decimal ContractualEarnings(decimal contractualHours, decimal hoursWorked, decimal hourlyRate)
            => (hoursWorked < contractualHours) ? hoursWorked * hourlyRate : contractualHours * hourlyRate;

        public decimal NetPay(decimal totalEarnings, decimal totalDeduction)
            => totalEarnings - totalDeduction;

        public decimal OvertimeEarnings(decimal overtimeRate, decimal overtimeHours)
            => overtimeHours * overtimeRate;

        public decimal OvertimeHours(decimal hoursWorked, decimal contractualHours)
            => (hoursWorked <= contractualHours) ? 0.00m : hoursWorked - contractualHours;

        public decimal OvertimeRate(decimal hourlyRate)
            => 1.5m * hourlyRate;

        public async Task<decimal> StudentLoanRepaymentAmountAsync(int id, decimal totalAmount)
        {
            var employee = await _unitOfWork.EmployeeRepository.GetByIdAsync(id);
            return (employee.StudentLoan == StudentLoan.Yes) ? _loan.Calculate(totalAmount) : 0;
        }

        public decimal TotalDeductuon(decimal tax, decimal nic, decimal studentLoanRepayment, decimal unionFees)
            => tax + nic + studentLoanRepayment + unionFees;

        public decimal TotalEarnings(decimal overtimeEarnings, decimal contractualEarnings)
            => overtimeEarnings + contractualEarnings;

        public async Task<decimal> UnionFees(int id)
        {
            var employee = await _unitOfWork.EmployeeRepository.GetByIdAsync(id);
            return (employee.UnionMember == UnionMember.Yes) ? 10 : 0;
        }
    }
}
