using PaymentComputeApp.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PaymentComputeApp.DataAccess.Repositories
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IEmployeeRepository _employeeRepo;
        private IRepository<PaymentRecord> _paymentRepo;
        private IRepository<TaxYear> _taxYear;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEmployeeRepository EmployeeRepository
            => _employeeRepo = _employeeRepo ?? new EmployeeRepository(_context);

        public IRepository<PaymentRecord> PaymentRepository
            => _paymentRepo = _paymentRepo ?? new Repository<PaymentRecord>(_context);

        public IRepository<TaxYear> TaxYearRepository
            => _taxYear = _taxYear ?? new Repository<TaxYear>(_context);

        public void Dispose()
            => _context.Dispose();

        public async Task<bool> SaveAsync()
            => await _context.SaveChangesAsync() > 0;
    }
}
