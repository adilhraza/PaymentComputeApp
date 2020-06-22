using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PaymentComputeApp.Core.Helpers;
using PaymentComputeApp.DataAccess.Repositories;
using PaymentComputeApp.WebUI.Models;

namespace PaymentComputeApp.WebUI.Controllers
{
    public class ReportController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private PaymentByDateReportViewModel model;

        public ReportController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

       /* public async Task<IActionResult> PaymentByDate()
        {
            PaymentByDateReportViewModel model = new PaymentByDateReportViewModel()
            {
                DateFrom = DateTime.Now,
                DateTo = DateTime.Now,
            };

            return View(model);
        }*/

     //   [HttpPost]
        public async Task<IActionResult> PaymentByDate(PaymentByDateReportViewModel paymentReportModel, int pageNumber=1)
        {
            var paymentsRepo = (await _unitOfWork.PaymentRepository.GetAsync(includeProperties: "Employee",
                filter: x => x.PayDate >= paymentReportModel.DateFrom && x.PayDate <= paymentReportModel.DateTo))
                .Select(payment => new PaymentIndexViewModel()
                {
                    Id = payment.Id,
                    EmployeeId = payment.EmployeeId,
                    FullName = payment.Employee.FirstName + " " + payment.Employee.LastName,
                    PayDate = payment.PayDate,
                    PayMonth = payment.PayMonth,
                    TaxYearId = payment.TaxYearId,
                    Year = _unitOfWork.TaxYearRepository.GetById(payment.TaxYearId).YearOfTax,
                    TotalEarnings = payment.TotalEarnings,
                    TotalDeduction = payment.TotalDeduction,
                    NetPayment = payment.NetPayment,
                    Employee = payment.Employee
                });


            model = new PaymentByDateReportViewModel()
            {
                DateFrom = DateTime.Now,
                DateTo = DateTime.Now,
                Payments = PagedList<PaymentIndexViewModel>.Create(paymentsRepo, pageNumber, 1)
            };

            return View(model);
        }

        public async Task<IActionResult> EmployeeByName(string searchField, int pageNumber=1)
        {
            var employees = (await _unitOfWork.EmployeeRepository.GetAllAsync())
                .Select(employee => new EmployeeIndexViewModel
                {
                    Id = employee.Id,
                    EmployeeNo = employee.EmployeeNo,
                    FirstName = employee.FirstName,
                    LastName = employee.LastName,
                    Gender = employee.Gender,
                    ImageUrl = employee.ImageUrl,
                    DateJoined = employee.DateJoined,
                    Designation = employee.Designation,
                    City = employee.City
                }); 

            if (!String.IsNullOrEmpty(searchField))
            {
                employees = (await _unitOfWork.EmployeeRepository.GetAsync(x => x.FirstName.Contains(searchField) 
                    || x.LastName.Contains(searchField)))
                    .Select(employee => new EmployeeIndexViewModel
                    {
                        Id = employee.Id,
                        EmployeeNo = employee.EmployeeNo,
                        FirstName = employee.FirstName,
                        LastName = employee.LastName,
                        Gender = employee.Gender,
                        ImageUrl = employee.ImageUrl,
                        DateJoined = employee.DateJoined,
                        Designation = employee.Designation,
                        City = employee.City
                    }); 
            }

            ViewData["searchField"] = searchField;

            return View(PagedList<EmployeeIndexViewModel>.Create(employees, pageNumber,2));
        }
    }
}
