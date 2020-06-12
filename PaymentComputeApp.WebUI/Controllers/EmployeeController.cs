using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Internal;
using Microsoft.AspNetCore.Mvc;
using PaymentComputeApp.Core.Services;
using PaymentComputeApp.DataAccess.Repositories;
using PaymentComputeApp.Entity.Models;
using PaymentComputeApp.WebUI.Models.Employee;

namespace PaymentComputeApp.WebUI.Controllers
{
    public class EmployeeController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly HostingEnvironment _hostingEnvironment;

        public EmployeeController(IUnitOfWork unitOfWork, HostingEnvironment hostingEnvironment)
        {
            _unitOfWork = unitOfWork;
            _hostingEnvironment = hostingEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            var employees = (await _unitOfWork.EmployeeRepository.GetAllAsync())
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

            return View(employees);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var employee = new EmployeeCreateViewModel();
            return View(employee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EmployeeCreateViewModel model)
        {
            if (!ModelState.IsValid)
                return View();

            var employee = new Employee
            {
                Id = model.Id,
                EmployeeNo = model.EmployeeNo,
                FirstName = model.FirstName,
                MiddleName = model.MiddleName,
                LastName = model.LastName,
                Gender = model.Gender,
                Email = model.Email,
                DOB = model.DOB,
                DateJoined = model.DateJoined,
                NationalInsuranceNo = model.NationalInsuranceNo,
                PaymentMethod = model.PaymentMethod,
                StudentLoan = model.StudentLoan,
                UnionMember = model.UnionMember,
                Address = model.Address,
                City = model.City,
                Phone = model.Phone,
                Postcode = model.Postcode,
                Designation = model.Designation
            };

            if (model.ImageUrl != null && model.ImageUrl.Length > 0)
                employee.ImageUrl = await model.ImageUrl.SetImageUrlAsync(_hostingEnvironment);

            await _unitOfWork.EmployeeRepository.AddAsync(employee);

            if (await _unitOfWork.SaveAsync())
                Alert("Successfully created!", NotificationType.success);

            return RedirectToAction(nameof(Index));
        }
    }
}
