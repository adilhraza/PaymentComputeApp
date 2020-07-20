using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OfficeOpenXml;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;
using PaymentComputeApp.Core.Helpers;
using PaymentComputeApp.DataAccess.Repositories;
using PaymentComputeApp.Entity.Models;
using PaymentComputeApp.WebUI.Extensions;
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
            //CreateExcelFileEmployeeIndex(Ep, employees, "Employee_Info");
            //CreateExcel(Ep, employees.ToList());

            var employeesExcel = employees.Select(x => new EmployeeExcel
            {
                EmployeeNo = x.EmployeeNo,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Gender = x.Gender,
                DateJoined = x.DateJoined,
                Designation = x.Designation,
                City = x.City
            });

            Ep.ExportToExcel("Employee_Info", employeesExcel);
            return GetFileContentResult(Ep, "Employee_by_city");
        }

        public async Task<IActionResult> EmployeeByNameExportToExcel(string searchField)
        {
            var employees = await GetEmployeesByName(searchField);

            ExcelPackage Ep = new ExcelPackage();
            CreateExcelFileEmployeeIndex(Ep, employees, "Employee_Info");

            return GetFileContentResult(Ep, "Employee_by_name");
        }

        public async Task<IActionResult> PaymentByDateExportToExcel(string dateFrom, string dateTo)
        {
            var payments = await GetPaymentsByDate(Convert.ToDateTime(dateFrom), Convert.ToDateTime(dateTo));

            ExcelPackage Ep = new ExcelPackage();
            CreateExcelFilePaymentIndex(Ep, payments, "Payment_Info");

            return GetFileContentResult(Ep, "Payment_by_date");
        }

        public async Task<IActionResult> PaymentByTotalEarningsExportToExcel(decimal totalEarnings)
        {
            var payments = await GetPaymentsByTotalEarnings(totalEarnings);

            ExcelPackage Ep = new ExcelPackage();
            CreateExcelFilePaymentIndex(Ep, payments, "Payment_Info");

            return GetFileContentResult(Ep, "Payments_by_total_earnings");
        }

        public async Task<IActionResult> PaymentByTotalDeductionExportToExcel(decimal fromDeduction, decimal toDeduction)
        {
            var payments = await GetPaymentsBytTotalDeduction(fromDeduction, toDeduction);

            ExcelPackage Ep = new ExcelPackage();
            CreateExcelFilePaymentIndex(Ep, payments, "Payment_Info");

            return GetFileContentResult(Ep, "Payments_by_total_deduction");
        }

        public async Task<IActionResult> PaymentByTaxYearExportToExcel(string taxYear)
        {
            var payments = await GetPaymentByTaxYear(taxYear);

            ExcelPackage Ep = new ExcelPackage();
            CreateExcelFilePaymentIndex(Ep, payments, "Payment_Info");

            return GetFileContentResult(Ep, "Payment_by_tax_year");
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

        private async Task<IEnumerable<PaymentIndexViewModel>> GetPaymentsByDate(DateTime dateFrom, DateTime dateTo)
        {
            return (await _unitOfWork.PaymentRepository.GetAsync(includeProperties: "Employee",
                filter: x => x.PayDate >= dateFrom && x.PayDate <= dateTo))
                .Select(payment => new PaymentIndexViewModel
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
        }

        private async Task<IEnumerable<PaymentIndexViewModel>> GetPaymentsByTotalEarnings(decimal totalEarnings)
        {
            return (await _unitOfWork.PaymentRepository.GetAsync(includeProperties: "Employee",
                filter: x => x.TotalEarnings>=totalEarnings))
                .Select(payment => new PaymentIndexViewModel
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
        }

        private async Task<IEnumerable<PaymentIndexViewModel>> GetPaymentsBytTotalDeduction(decimal fromDeduction, decimal toDeduction)
        {
            return (await _unitOfWork.PaymentRepository.GetAsync(includeProperties: "Employee",
                filter: x => x.TotalDeduction >= fromDeduction && x.TotalDeduction<=toDeduction))
                .Select(payment => new PaymentIndexViewModel
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
        }

        private async Task<IEnumerable<PaymentIndexViewModel>> GetPaymentByTaxYear(string taxYear)
        {
            return (await _unitOfWork.PaymentRepository.GetAsync(includeProperties: "Employee",
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
        }

        private void CreateExcelFileEmployeeIndex(ExcelPackage ep, IEnumerable<EmployeeIndexViewModel> employees, string sheetName)
        {
            ExcelWorksheet Sheet = ep.Workbook.Worksheets.Add(sheetName);
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
        }

        private void CreateExcelFilePaymentIndex(ExcelPackage ep, IEnumerable<PaymentIndexViewModel> payments, string sheetName)
        {
            ExcelWorksheet Sheet = ep.Workbook.Worksheets.Add("Payment_Info");
            Sheet.Cells[1, 1].Value = "Full Name";
            Sheet.Cells[1, 2].Value = "Pay Date";
            Sheet.Cells[1, 3].Value = "Pay Month";
            Sheet.Cells[1, 4].Value = "Year";
            Sheet.Cells[1, 5].Value = "Total Earnings";
            Sheet.Cells[1, 6].Value = "Total Deduction";
            Sheet.Cells[1, 7].Value = "Net Payment";

            int row = 2;
            foreach (var item in payments)
            {
                Sheet.Cells[row, 1].Value = item.FullName;
                Sheet.Cells[row, 2].Value = item.PayDate;
                Sheet.Cells[row, 3].Value = item.PayMonth;
                Sheet.Cells[row, 4].Value = item.Year;
                Sheet.Cells[row, 5].Value = item.TotalEarnings;
                Sheet.Cells[row, 6].Value = item.TotalDeduction;
                Sheet.Cells[row, 7].Value = item.NetPayment;
                row++;
            }

            Sheet.Cells["A:AZ"].AutoFitColumns();
        }

        public void CreateExcel<T>(ExcelPackage ep, IList<T> data)
        {
            ExcelWorksheet Sheet = ep.Workbook.Worksheets.Add("Payment_Informer");
            PropertyDescriptorCollection props =
                TypeDescriptor.GetProperties(typeof(T));

            int row = 2;
            foreach(T item in data)
            {
                for (int i = 1; i < props.Count; i++) 
                {
                    Sheet.Cells[row, i].Value = props[i - 1].DisplayName;
                    //Sheet.Cells[row, i].Value = props[i - 1].GetValue(item);
                }
            }

            Sheet.Cells["A:AZ"].AutoFitColumns();
        }
    }
}
