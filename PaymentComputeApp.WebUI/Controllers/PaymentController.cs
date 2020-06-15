using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PaymentComputeApp.Core.Services;
using PaymentComputeApp.DataAccess.Repositories;
using PaymentComputeApp.Entity.Models;
using PaymentComputeApp.WebUI.Models;

namespace PaymentComputeApp.WebUI.Controllers
{
    public class PaymentController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPaymentComputeService _paymentComputeService;
        private readonly ITaxService _taxService;
        private readonly INIContributionService _nIContributionService;

        public PaymentController(IUnitOfWork unitOfWork,
                                 IPaymentComputeService paymentComputeService,
                                 ITaxService taxService,
                                 INIContributionService nIContributionService)
        {
            _unitOfWork = unitOfWork;
            _paymentComputeService = paymentComputeService;
            _taxService = taxService;
            _nIContributionService = nIContributionService;
        }

        public async Task<IActionResult> Index()
        {
            var paymentRecords = (await _unitOfWork.PaymentRecordRepository.GetAsync(includeProperties: "Employee"))
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

            return View(paymentRecords);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.employees = (await _unitOfWork.EmployeeRepository.GetAllAsync())
                .Select(employee => new SelectListItem()
                {
                    Text = employee.FirstName + " " + employee.LastName,
                    Value = employee.Id.ToString()
                });

            ViewBag.taxYears = (await _unitOfWork.TaxYearRepository.GetAllAsync())
                .Select(taxYears => new SelectListItem()
                {
                    Text = taxYears.YearOfTax,
                    Value = taxYears.Id.ToString()
                });

            var model = new PaymentCreateViewModel();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PaymentCreateViewModel model)
        {
            decimal overtimeHrs, contractualEarnings, overtimeEarnings, totalEarnings, tax, unionFee, studentLoan,
                nationalInsurance, totalDeduction;

            if (!ModelState.IsValid)
            {
                ViewBag.employees = (await _unitOfWork.EmployeeRepository.GetAllAsync())
                    .Select(employee => new SelectListItem()
                    {
                        Text = employee.FirstName + " " + employee.LastName,
                        Value = employee.Id.ToString()
                    });

                ViewBag.taxYears = (await _unitOfWork.TaxYearRepository.GetAllAsync())
                    .Select(taxYears => new SelectListItem()
                    {
                        Text = taxYears.YearOfTax,
                        Value = taxYears.Id.ToString()
                    });

                return View();
            }

            var paymentRecord = new PaymentRecord();

            paymentRecord.Id = model.Id;
            paymentRecord.EmployeeId = model.EmployeeId;
            paymentRecord.Employee = await _unitOfWork.EmployeeRepository.GetByIdAsync(model.EmployeeId);
            paymentRecord.Employee.NationalInsuranceNo = (await _unitOfWork.EmployeeRepository
                .GetByIdAsync(model.EmployeeId)).NationalInsuranceNo;
            paymentRecord.PayDate = model.PayDate;
            paymentRecord.PayMonth = model.PayMonth;
            paymentRecord.TaxYearId = model.TaxYearId;
            paymentRecord.TaxCode = model.TaxCode;
            paymentRecord.HourlyRate = model.HourlyRate;
            paymentRecord.HoursWorked = model.HoursWorked;
            paymentRecord.ContractualHours = model.ContractualHours;
            paymentRecord.OvertimeHours = overtimeHrs = _paymentComputeService
                .OvertimeHours(model.HoursWorked, model.ContractualHours);
            paymentRecord.ContractualEarnings = contractualEarnings = _paymentComputeService
                .ContractualEarnings(model.ContractualHours, model.HoursWorked, model.HourlyRate);
            paymentRecord.OvertimeEarnings = overtimeEarnings = _paymentComputeService
                .OvertimeEarnings(_paymentComputeService.OvertimeRate(model.HourlyRate), model.OvertimeHours);
            paymentRecord.TotalEarnings = totalEarnings = _paymentComputeService
                .TotalEarnings(overtimeEarnings, contractualEarnings);
            paymentRecord.Tax = tax = _taxService.TaxAmount(totalEarnings);
            paymentRecord.UnionFee = unionFee = _taxService.TaxAmount(totalEarnings);
            paymentRecord.SLC = studentLoan = await _paymentComputeService
                .StudentLoanRepaymentAmountAsync(model.EmployeeId, totalEarnings);
            paymentRecord.NIC = nationalInsurance = _nIContributionService
                .CalculateNIContribution(totalEarnings);
            paymentRecord.TotalDeduction = totalDeduction = _paymentComputeService
                .TotalDeductuon(tax, nationalInsurance, studentLoan, unionFee);
            paymentRecord.NetPayment = _paymentComputeService.NetPay(totalEarnings, totalDeduction);

            await _unitOfWork.PaymentRecordRepository.AddAsync(paymentRecord);

            if (await _unitOfWork.SaveAsync())
                Alert("Successfully created!", NotificationType.success);

            return RedirectToAction(nameof(Index));
        }
    }
}
