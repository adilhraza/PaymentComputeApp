using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OfficeOpenXml;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using PaymentComputeApp.Core.Helpers;
using PaymentComputeApp.DataAccess.Repositories;
using PaymentComputeApp.WebUI.Models;

namespace PaymentComputeApp.WebUI.Controllers
{
    public class ReportController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ReportController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> EmployeeByName(string searchField, int? pageNumber)
        {
            var employees = await GetEmployeesByName(searchField);

            ViewData["searchField"] = searchField;

            return View(PagedList<EmployeeIndexViewModel>.Create(employees, pageNumber ?? 1));
        }

        public async Task<IActionResult> EmployeeByCity(string city, int? pageNumber)
        {
            IEnumerable<EmployeeIndexViewModel> employees;

            if (!String.IsNullOrEmpty(city))
            {
                employees = (await _unitOfWork.EmployeeRepository.GetAsync(x => x.City.Contains(city)
                    || x.City.Contains(city)))
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
            else
            {
                employees = (await _unitOfWork.EmployeeRepository.GetAllAsync())
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

            ViewData["city"] = city;

            return View(PagedList<EmployeeIndexViewModel>.Create(employees, pageNumber ?? 1));
        }

        public async Task<IActionResult> PaymentByDate(string dateFrom, string dateTo, int? pageNumber)
        {
            var payments = (await _unitOfWork.PaymentRepository.GetAsync(includeProperties: "Employee",
                filter: x => x.PayDate >= Convert.ToDateTime(dateFrom) && x.PayDate <= Convert.ToDateTime(dateTo)))
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

            ViewData["dateFrom"] = dateFrom;
            ViewData["dateTo"] = dateTo;

            return View(PagedList<PaymentIndexViewModel>.Create(payments, pageNumber ?? 1));
        }

        public async Task<IActionResult> PaymentByTotalEarnings(decimal totalEarnings, int? pageNumber)
        {
            var payments = (await _unitOfWork.PaymentRepository.GetAsync(includeProperties: "Employee",
                filter: x => x.TotalEarnings >= totalEarnings))
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

            ViewData["totalEarnings"] = totalEarnings;

            return View(PagedList<PaymentIndexViewModel>.Create(payments, pageNumber ?? 1));
        }

        public async Task<IActionResult> PaymentByTotalDeduction(decimal fromDeduction, decimal toDeduction, int? pageNumber)
        {
            var payments = (await _unitOfWork.PaymentRepository.GetAsync(includeProperties: "Employee",
                filter: x => x.TotalDeduction >= fromDeduction && x.TotalDeduction <= toDeduction))
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

            ViewData["fromDeduction"] = fromDeduction;
            ViewData["toDeduction"] = toDeduction;

            return View(PagedList<PaymentIndexViewModel>.Create(payments, pageNumber ?? 1));
        }

        public async Task<IActionResult> PaymentByTaxYear(string taxYear, int? pageNumber)
        {
            var payments = (await _unitOfWork.PaymentRepository.GetAsync(includeProperties: "Employee",
               filter: x => x.TaxYear.YearOfTax == taxYear))
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

            ViewData["taxYear"] = taxYear;

            return View(PagedList<PaymentIndexViewModel>.Create(payments, pageNumber ?? 1));
        }

        public async Task<IActionResult> EmployeeByCityExportToExcel(string city)
        {
            var employees = await GetEmployeesByCity(city);

            ExcelPackage Ep = new ExcelPackage();
            ExcelWorksheet Sheet = Ep.Workbook.Worksheets.Add("Employee_Info");
            Sheet.Cells[1, 1].Value = "Employee No.";
            Sheet.Cells[1, 2].Value = "First Name";
            Sheet.Cells[1, 3].Value = "Last Name";
            Sheet.Cells[1, 4].Value = "Gender";
            Sheet.Cells[1, 5].Value = "Date Joined";
            Sheet.Cells[1, 6].Value = "Designation";
            Sheet.Cells[1, 7].Value = "City";

            int row = 2;
            foreach (var item in employees)
            {
                Sheet.Cells[row, 1].Value = item.EmployeeNo;
                Sheet.Cells[row, 2].Value = item.FirstName;
                Sheet.Cells[row, 3].Value = item.LastName;
                Sheet.Cells[row, 4].Value = item.Gender;
                Sheet.Cells[row, 5].Value = item.DateJoined;
                Sheet.Cells[row, 6].Value = item.Designation;
                Sheet.Cells[row, 7].Value = item.City;
                row++;
            }

            Sheet.Cells["A:AZ"].AutoFitColumns();

            return GetFileContentResult(Ep, "Employee");
        }

        public async Task<IActionResult> EmployeeByNameExportToExcel(string searchField)
        {
            var employees = await GetEmployeesByName(searchField);

            ExcelPackage Ep = new ExcelPackage();
            ExcelWorksheet Sheet = Ep.Workbook.Worksheets.Add("Employee_Info");
            Sheet.Cells[1,1].Value = "Employee No.";
            Sheet.Cells[1,2].Value = "First Name";
            Sheet.Cells[1,3].Value = "Last Name";
            Sheet.Cells[1,4].Value = "Gender";
            Sheet.Cells[1,5].Value = "Date Joined";
            Sheet.Cells[1,6].Value = "Designation";
            Sheet.Cells[1,7].Value = "City";

            int row = 2;
            foreach (var item in employees)
            {
                Sheet.Cells[row, 1].Value = item.EmployeeNo;
                Sheet.Cells[row, 2].Value = item.FirstName;
                Sheet.Cells[row, 3].Value = item.LastName;
                Sheet.Cells[row, 4].Value = item.Gender;
                Sheet.Cells[row, 5].Value = item.DateJoined;
                Sheet.Cells[row, 6].Value = item.Designation;
                Sheet.Cells[row, 7].Value = item.City;
                row++;
            }

            Sheet.Cells["A:AZ"].AutoFitColumns();

            return GetFileContentResult(Ep, "Employee");
        }

        private IActionResult GetFileContentResult(ExcelPackage Ep, string fileName)
        {
            byte[] fileContents;
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
                fileDownloadName: $"{fileName}.xlsx"
            );
        }

        public async Task<IEnumerable<EmployeeIndexViewModel>> GetEmployeesByCity(string city)
        {
            IEnumerable<EmployeeIndexViewModel> employees;

            if (!String.IsNullOrEmpty(city))
            {
                employees = (await _unitOfWork.EmployeeRepository.GetAsync(x => x.City.Contains(city)))
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
            else
            {
                employees = (await _unitOfWork.EmployeeRepository.GetAllAsync())
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

            return employees;
        }

        private async Task<IEnumerable<EmployeeIndexViewModel>> GetEmployeesByName(string searchField)
        {
            IEnumerable<EmployeeIndexViewModel> employees;

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
            else
            {
                employees = (await _unitOfWork.EmployeeRepository.GetAllAsync())
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

            return employees;
        }

    }
}
