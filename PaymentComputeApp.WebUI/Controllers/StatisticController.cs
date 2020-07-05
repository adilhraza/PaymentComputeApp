using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PaymentComputeApp.DataAccess.Repositories;
using PaymentComputeApp.Entity.Models;
using PaymentComputeApp.WebUI.Models;

namespace PaymentComputeApp.WebUI.Controllers
{
    public class StatisticController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public StatisticController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            List<DataPoint> dataPoints = new List<DataPoint>();

            ViewBag.DataPointsEmployeesCity = 
                JsonConvert.SerializeObject(SetDataPointsEmployeesCity(dataPoints));
            dataPoints.Clear();
            
            ViewBag.DataPointsAvgTotalEarningsYear = 
                JsonConvert.SerializeObject(SetDataPointsAvgTotalEarningsYear(dataPoints));
            dataPoints.Clear();

            ViewBag.DataPointsAvgTotalDeuctionYear = 
                JsonConvert.SerializeObject(SetDataPointsAvgTotalDeductionYear(dataPoints));
            dataPoints.Clear();

            ViewBag.DataPointsAvgNetPaymentYear =
                JsonConvert.SerializeObject(SetDataPointsAvgNetPaymentYear(dataPoints));
            dataPoints.Clear();

            return View();
        }

        private List<DataPoint> SetDataPointsEmployeesCity(List<DataPoint> dataPoints)
        {
            var cities = _unitOfWork.EmployeeRepository.CountEmployeeByCity();

            foreach (var city in cities)
            {
                dataPoints.Add(new DataPoint(city.City, city.CountCity));
            }

            return dataPoints;
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
    }
}
