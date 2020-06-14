using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Internal;
using Microsoft.AspNetCore.Mvc;
using PaymentComputeApp.Core.Services;
using PaymentComputeApp.DataAccess.Repositories;
using PaymentComputeApp.Entity.Models;
using PaymentComputeApp.WebUI.Models;

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

        public async Task<IActionResult> Edit(int id)
        {
            var employee = await _unitOfWork.EmployeeRepository.GetByIdAsync(id);

            if (employee == null)
                return NotFound();

            var model = new EmployeeEditViewModel()
            {
                Id = employee.Id,
                EmployeeNo = employee.EmployeeNo,
                FirstName = employee.FirstName,
                MiddleName = employee.MiddleName,
                LastName = employee.LastName,
                Gender = employee.Gender,
                Email = employee.Email,
                DOB = employee.DOB,
                DateJoined = employee.DateJoined,
                NationalInsuranceNo = employee.NationalInsuranceNo,
                PaymentMethod = employee.PaymentMethod,
                StudentLoan = employee.StudentLoan,
                UnionMember = employee.UnionMember,
                Address = employee.Address,
                City = employee.City,
                Phone = employee.Phone,
                Postcode = employee.Postcode,
                Designation = employee.Designation
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EmployeeEditViewModel model)
        {
            if (!ModelState.IsValid)
                return View();

            var employee = await _unitOfWork.EmployeeRepository.GetByIdAsync(model.Id);

            if (employee == null)
                return NotFound();

            employee.EmployeeNo = model.EmployeeNo;
            employee.FirstName = model.FirstName;
            employee.LastName = model.LastName;
            employee.MiddleName = model.MiddleName;
            employee.NationalInsuranceNo = model.NationalInsuranceNo;
            employee.Gender = model.Gender;
            employee.Email = model.Email;
            employee.DOB = model.DOB;
            employee.DateJoined = model.DateJoined;
            employee.Phone = model.Phone;
            employee.Designation = model.Designation;
            employee.PaymentMethod = model.PaymentMethod;
            employee.StudentLoan = model.StudentLoan;
            employee.UnionMember = model.UnionMember;
            employee.Address = model.Address;
            employee.City = model.City;
            employee.Postcode = model.Postcode;

            if (model.ImageUrl != null && model.ImageUrl.Length > 0)
                employee.ImageUrl = await model.ImageUrl.SetImageUrlAsync(_hostingEnvironment);

            _unitOfWork.EmployeeRepository.Update(employee);

            if(await _unitOfWork.SaveAsync())
                Alert("Successfully edited!", NotificationType.success);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Detail(int id)
        {
            var employee = await _unitOfWork.EmployeeRepository.GetByIdAsync(id);

            if (employee == null)
                return NotFound();

            var model = new EmployeeDetailViewModel()
            {
                Id = employee.Id,
                EmployeeNo = employee.EmployeeNo,
                FirstName = employee.FirstName,
                MiddleName = employee.MiddleName,
                LastName = employee.LastName,
                Gender = employee.Gender,
                DOB = employee.DOB,
                DateJoined = employee.DateJoined,
                Designation = employee.Designation,
                NationalInsuranceNo = employee.NationalInsuranceNo,
                Phone = employee.Phone,
                Email = employee.Email,
                PaymentMethod = employee.PaymentMethod,
                StudentLoan = employee.StudentLoan,
                UnionMember = employee.UnionMember,
                Address = employee.Address,
                City = employee.City,
                ImageUrl = employee.ImageUrl,
                Postcode = employee.Postcode
            };

            return View(model);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var employee = await _unitOfWork.EmployeeRepository.GetByIdAsync(id);

            if (employee == null)
                return NotFound();

            var model = new EmployeeDeleteViewModel()
            {
                Id = employee.Id,
                FirstName = employee.FirstName,
                LastName = employee.LastName
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(EmployeeDeleteViewModel model)
        {
            _unitOfWork.EmployeeRepository.Remove(model.Id);
            var employee = await _unitOfWork.EmployeeRepository.GetByIdAsync(model.Id);

            if (await _unitOfWork.SaveAsync())
            {
                Alert("Successfully deleted!", NotificationType.success);

                var filePath = Path.Combine(_hostingEnvironment.WebRootPath,
                    employee.ImageUrl.Substring(1, employee.ImageUrl.Length - 1));
                if (!System.IO.File.Exists(filePath))
                    return NotFound();

                GC.Collect();
                GC.WaitForPendingFinalizers();
                System.IO.File.Delete(filePath);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
