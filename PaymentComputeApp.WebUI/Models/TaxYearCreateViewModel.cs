using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentComputeApp.WebUI.Models
{
    public class TaxYearCreateViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Tax Year")]
        public string YearOfTax { get; set; }
    }
}
