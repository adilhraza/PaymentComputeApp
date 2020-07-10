using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
            List<DataPoint> dataPoints = new List<DataPoint>();

            ViewBag.employeesNum = (await _unitOfWork.EmployeeRepository.GetAllAsync()).Count();
            ViewBag.paymentRecords = (await _unitOfWork.PaymentRepository.GetAllAsync()).Count();
            ViewBag.avgHourlyRate = Convert.ToDecimal(_unitOfWork.PaymentRepository.AvgHourlyRateInfo().Amount.ToString("n2"));
            ViewBag.avgOvertimeEarnings = Convert.ToDecimal(_unitOfWork.PaymentRepository.AvgOvertimeEarningsInfo().Amount.ToString("n2"));
            
            ViewBag.DataPointsAvgTotalEarningsYear =
                JsonConvert.SerializeObject(SetDataPointsAvgTotalEarningsYear(dataPoints));
            dataPoints.Clear();

            ViewBag.DataPointsAvgTotalDeductionYear =
                JsonConvert.SerializeObject(SetDataPointsAvgTotalDeductionYear(dataPoints));
            dataPoints.Clear();

            ViewBag.DataPointsAvgNetPaymentYear =
                JsonConvert.SerializeObject(SetDataPointsAvgNetPaymentYear(dataPoints));
            dataPoints.Clear();

            ViewBag.avgPaymentsInfoPercent = _unitOfWork.PaymentRepository.AvgPaymentsInfoPercent();

            return View();
        }

        private List<DataPoint> SetDataPointsAvgTotalEarningsYear(List<DataPoint> dataPoints)
        {
            var avgTotalEarningsYear = _unitOfWork.PaymentRepository.AvgTotalEarningsByYear();

            foreach (var item in avgTotalEarningsYear)
            {
                dataPoints.Add(new DataPoint(item.Year.ToString(), Convert.ToDouble(item.Amount)));
            }

            return dataPoints;
        }

        private List<DataPoint> SetDataPointsAvgTotalDeductionYear(List<DataPoint> dataPoints)
        {
            var avgTotalDeductionYear = _unitOfWork.PaymentRepository.AvgTotalDeductionByYear();

            foreach (var item in avgTotalDeductionYear)
            {
                dataPoints.Add(new DataPoint(item.Year.ToString(), Convert.ToDouble(item.Amount)));
            }

            return dataPoints;
        }

        private List<DataPoint> SetDataPointsAvgNetPaymentYear(List<DataPoint> dataPoints)
        {
            var avgNetPaymentYear = _unitOfWork.PaymentRepository.AvgNetPaymentByYear();

            foreach (var item in avgNetPaymentYear)
            {
                dataPoints.Add(new DataPoint(item.Year.ToString(), Convert.ToDouble(item.Amount)));
            }

            return dataPoints;
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
