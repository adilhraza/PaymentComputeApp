using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OfficeOpenXml;
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
                Payments = PagedList<PaymentIndexViewModel>.Create(paymentsRepo, pageNumber)
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

            return View(PagedList<EmployeeIndexViewModel>.Create(employees, pageNumber));
        }

        public async Task<IActionResult> ExportToExcel()
        {
            byte[] fileContents;
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

            ExcelPackage Ep = new ExcelPackage();
            ExcelWorksheet Sheet = Ep.Workbook.Worksheets.Add("EmployeeInfo");
            Sheet.Cells["A1"].Value = "Employee No.";
            Sheet.Cells["B1"].Value = "First Name";
            Sheet.Cells["C1"].Value = "Last Name";
            Sheet.Cells["D1"].Value = "Gender";
            Sheet.Cells["E1"].Value = "Date Joined";
            Sheet.Cells["F1"].Value = "Designation";
            Sheet.Cells["G1"].Value = "City";

            int row = 2;
            foreach (var item in employees)
            {
                Sheet.Cells[string.Format("A{0}", row)].Value = item.EmployeeNo;
                Sheet.Cells[string.Format("B{0}", row)].Value = item.FirstName;
                Sheet.Cells[string.Format("C{0}", row)].Value = item.LastName;
                Sheet.Cells[string.Format("D{0}", row)].Value = item.Gender;
                Sheet.Cells[string.Format("E{0}", row)].Value = item.DateJoined;
                Sheet.Cells[string.Format("F{0}", row)].Value = item.Designation;
                Sheet.Cells[string.Format("G{0}", row)].Value = item.City;
                row++;
            }

            Sheet.Cells["A:AZ"].AutoFitColumns();
            Response.Clear();
            Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            fileContents = Ep.GetAsByteArray();

            if (fileContents == null || fileContents.Length == 0)
            {
                return NotFound();
            }

            return File(
                fileContents: fileContents,
                contentType: "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                fileDownloadName: "Employee.xlsx"
            );
        }
    }
}
