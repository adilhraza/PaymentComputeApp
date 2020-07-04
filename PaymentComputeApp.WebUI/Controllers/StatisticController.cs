using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PaymentComputeApp.DataAccess.Repositories;
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

            var cities = _unitOfWork.EmployeeRepository.CountEmployeeByCity();

            foreach(var city in cities)
            {
                dataPoints.Add(new DataPoint(city.City, city.CountCity));
            }

            ViewBag.DataPointsCity = JsonConvert.SerializeObject(dataPoints);

            dataPoints.Clear();

            var avgTotalEarningsYear = _unitOfWork.PaymentRepository.AvgTotalEarningsByYear();

            foreach (var item in avgTotalEarningsYear)
            {
                dataPoints.Add(new DataPoint(item.YearOfPayment.ToString(), Convert.ToDouble(item.Amount)));
            }

            ViewBag.DataPointsYear = JsonConvert.SerializeObject(dataPoints);

            dataPoints.Clear();

            var avgTotalDeductionYear = _unitOfWork.PaymentRepository.AvgTotalDeductionByYear();

            foreach (var item in avgTotalDeductionYear)
            {
                dataPoints.Add(new DataPoint(item.Year.ToString(), Convert.ToDouble(item.Amount)));
            }

            ViewBag.DataPointsAvgTotalEarningsYear = JsonConvert.SerializeObject(dataPoints);

            return View();
        }
    }
}
