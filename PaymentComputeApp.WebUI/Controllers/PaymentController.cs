using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PaymentComputeApp.Core.Services;
using PaymentComputeApp.DataAccess.Repositories;
using PaymentComputeApp.WebUI.Models;

namespace PaymentComputeApp.WebUI.Controllers
{
    public class PaymentController : Controller
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
    }
}
