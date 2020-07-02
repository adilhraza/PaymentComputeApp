using PaymentComputeApp.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PaymentComputeApp.DataAccess.Repositories
{
    public interface IUnitOfWork:IDisposable
    {
        IRepository<TaxYear> TaxYearRepository { get; }
        IRepository<PaymentRecord> PaymentRepository { get; }
        IEmployeeRepository EmployeeRepository { get; }
        Task<bool> SaveAsync();
    }
}
