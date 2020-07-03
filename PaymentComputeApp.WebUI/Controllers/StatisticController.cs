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
            var cities = _unitOfWork.EmployeeRepository.CountEmployeeByCity();

            List<DataPoint> dataPoints = new List<DataPoint>();

            foreach(var city in cities)
            {
                dataPoints.Add(new DataPoint(city.City, city.CountCity));
            }

            ViewBag.DataPointsCity = JsonConvert.SerializeObject(dataPoints);

            dataPoints.Clear();

            var totalEarningsYear = _unitOfWork.PaymentRepository.TotalEarningsByYear();

            foreach (var year in totalEarningsYear)
            {
                dataPoints.Add(new DataPoint(year.YearOfPayment.ToString(), Convert.ToDouble(year.AvgTotalEarnings)));
            }

            ViewBag.DataPointsYear = JsonConvert.SerializeObject(dataPoints);

            return View();
        }
    }
}
