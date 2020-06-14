using PaymentComputeApp.Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentComputeApp.WebUI.Models
{
    public class PaymentDetailViewModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        [Display(Name = "Name")]
        public string FullName { get; set; }
        [Display(Name = "Pay Date")]
        public DateTime PayDate { get; set; }
        [Display(Name = "Pay Month")]
        public string PayMonth { get; set; }
        public string NiNo { get; set; }
        [Display(Name = "Hourly Rate")]
        public decimal HourlyRate { get; set; }
        [Display(Name = "Hours Worked")]
        public decimal HoursWorked { get; set; }
        [Display(Name = "Contractual Hours")]
        public decimal ContractualHours { get; set; }
        [Display(Name = "Overtime Rate")]
        public decimal OvertimeRate { get; set; }
        [Display(Name = "Overtime Hours")]
        public decimal OvertimeHours { get; set; }
        public string TaxCode { get; set; }
        public decimal Tax { get; set; }
        public decimal? SLC { get; set; }
        [Display(Name = "Union Fee")]
        public decimal? UnionFee { get; set; }
        [Display(Name = "Contractual Earnings")]
        public decimal ContractualEarnings { get; set; }
        [Display(Name = "Overtime Earnings")]
        public decimal OvertimeEarnings { get; set; }
        public int TaxYearId { get; set; }
        [Display(Name = "Tax Year")]
        public TaxYear TaxYear { get; set; }
        public decimal NIC { get; set; }
        public string Year { get; set; }
        [Display(Name = "Total Earnings")]
        public decimal TotalEarnings { get; set; }
        [Display(Name = "Total Deduction")]
        public decimal TotalDeduction { get; set; }
        [Display(Name = "Net Payment")]
        public decimal NetPayment { get; set; }
    }
}
