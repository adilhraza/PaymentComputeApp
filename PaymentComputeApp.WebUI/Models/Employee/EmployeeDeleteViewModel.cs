using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentComputeApp.WebUI.Models.Employee
{
    public class EmployeeDeleteViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + (string.IsNullOrEmpty(MiddleName) ? " "
                    : (" " + (char?)MiddleName[0] + ". ").ToUpper())
                    + LastName;
            }
        }
    }
}
