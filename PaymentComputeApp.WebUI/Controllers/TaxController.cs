using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using PaymentComputeApp.DataAccess.Repositories;
using PaymentComputeApp.Entity.Models;
using PaymentComputeApp.WebUI.Models;

namespace PaymentComputeApp.WebUI.Controllers
{
    public class TaxController : BaseController
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

        public async Task<IActionResult> Create()
        {
            var model = new TaxYearCreateViewModel();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TaxYearCreateViewModel model)
        {
            var taxYearRepo = _unitOfWork.TaxYearRepository.Find(x => x.YearOfTax == model.YearOfTax);
            
            if(taxYearRepo!=null)
                Alert("Tax year already exist!", NotificationType.error);

            var taxYear = new TaxYear()
            {
                Id = model.Id,
                YearOfTax = model.YearOfTax
            };

            await _unitOfWork.TaxYearRepository.AddAsync(taxYear);

            if(await _unitOfWork.SaveAsync())
                Alert("Successfully created!", NotificationType.success);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var taxYear = await _unitOfWork.TaxYearRepository.GetByIdAsync(id);
            if (taxYear == null)
                return NotFound();

            _unitOfWork.TaxYearRepository.Remove(taxYear);
            if(await _unitOfWork.SaveAsync())
                Alert("Successfully deleted!", NotificationType.success);

            return RedirectToAction(nameof(Index));
        }
    }
}
