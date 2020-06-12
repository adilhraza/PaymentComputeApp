using PaymentComputeApp.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentComputeApp.WebUI.Models.Employee
{
    public class EmployeeDetailViewModel
    {
        public int Id { get; set; }
        public string EmployeeNo { get; set; }
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
        public string Gender { get; set; }
        public string ImageUrl { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DateJoined { get; set; }
        public string Phone { get; set; }
        public string Designation { get; set; }
        public string Email { get; set; }
        public string NationalInsuranceNo { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public StudentLoan StudentLoan { get; set; }
        public UnionMember UnionMember { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
    }
}
