using PaymentComputeApp.Core.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentComputeApp.WebUI.Models
{
    public class PaymentByDateReportViewModel
    {
        [DataType(DataType.Date), Display(Name = "Date From")]
        public DateTime DateFrom { get; set; }
        [DataType(DataType.Date), Display(Name = "Date To")]
        public DateTime DateTo { get; set; }
        public PagedList<PaymentIndexViewModel> Payments { get; set; }
    }
}
