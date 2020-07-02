using PaymentComputeApp.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentComputeApp.DataAccess.Repositories
{
    public interface IEmployeeRepository:IRepository<Employee>
    {
        IEnumerable<EmployeeCity> CountEmployeeByCity();
    }
}
