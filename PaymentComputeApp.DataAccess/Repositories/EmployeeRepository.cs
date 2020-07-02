using Microsoft.EntityFrameworkCore;
using PaymentComputeApp.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace PaymentComputeApp.DataAccess.Repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ApplicationDbContext context) : base(context) { }

        public IEnumerable<EmployeeCity> CountEmployeeByCity()
        {
            return _context.EmployeeCity.FromSql("SELECT City, Count(*) AS CountCity FROM Employees GROUP BY City").ToList();//_context.Query<EmployeeCity>().FromSql("SELECT City, Count(*) FROM Employees GROUP BY City").ToList();
        }
    }
}
