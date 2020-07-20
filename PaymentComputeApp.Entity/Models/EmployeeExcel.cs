using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PaymentComputeApp.Entity.Models
{
    public class EmployeeExcel
    {
        [DisplayName("Employee No.")]
        public string EmployeeNo { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        public string Gender { get; set; }
        
        [DisplayName("Date Joined")]
        public DateTime DateJoined { get; set; }
        
        public string Designation { get; set; }
        
        public string City { get; set; }
    }
}
