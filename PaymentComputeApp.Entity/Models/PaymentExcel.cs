using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;

namespace PaymentComputeApp.Entity.Models
{
    public class PaymentExcel
    {
        [DisplayName("Full Name")]
        public string FullName { get; set; }

        [DisplayName("Pay Date")]
        public DateTime PayDate { get; set; }

        [DisplayName("Pay Month")]
        public string PayMonth { get; set; }
        
        public string Year { get; set; }
        
        [DisplayName("Total Earnings")]
        public decimal TotalEarnings { get; set; }

        [DisplayName("Total Deduction")]
        public decimal TotalDeduction { get; set; }

        [DisplayName("Net Payment")]
        public decimal NetPayment { get; set; }
    }
}
