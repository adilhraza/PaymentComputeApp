using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PaymentComputeApp.DataAccess.Repositories;
using PaymentComputeApp.WebUI.Models;

namespace PaymentComputeApp.WebUI.Controllers
{
    public class TaxController : Controller
    {
        private IUnitOfWork _unitOfWork;

        public TaxController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            var taxYears = (await _unitOfWork.TaxYearRepository.GetAllAsync())
                .Select(taxYear=>new TaxYearIndexViewModel()
                {
                    Id=taxYear.Id,
                    YearOfTax=taxYear.YearOfTax
                });

            return View(taxYears);
        }
    }
}
