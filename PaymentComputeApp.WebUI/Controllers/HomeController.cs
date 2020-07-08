using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PaymentComputeApp.DataAccess.Repositories;
using PaymentComputeApp.WebUI.Models;

namespace PaymentComputeApp.WebUI.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.employeesNum = (await _unitOfWork.EmployeeRepository.GetAllAsync()).Count();
            ViewBag.avgHourlyRate = Convert.ToDecimal(_unitOfWork.PaymentRepository.AvgHourlyRateInfo().Amount.ToString("n2"));
            ViewBag.avgOvertimeEarnings = Convert.ToDecimal(_unitOfWork.PaymentRepository.AvgOvertimeEarningsInfo().Amount.ToString("n2"));

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
