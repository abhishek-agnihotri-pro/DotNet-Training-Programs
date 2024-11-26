using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MVCinMemoryCRUD.Models;
using MVCinMemoryCRUD.Service;

namespace MVCinMemoryCRUD.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            List<Customer> customers = CustomerService.GetAllCusomers();
            return View(customers);
        }
        [HttpGet]
        public IActionResult Details(int id){
            var customer = CustomerService.GetCustomerByID(id);
            return View(customer);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer newStudent)
        {
            CustomerService.Add(newStudent);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int ID)
        {
            var data = CustomerService.GetCustomerByID(ID);
            return View(data);
        }
        [HttpPost]
        public IActionResult Edit(Customer modified)
        {
            CustomerService.Update(modified);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            CustomerService.Delete(id);
            return RedirectToAction("Index");
            // var data = CustomerService.GetStudentById(id);
            // return View(data);
        }

        // [HttpPost]
        // public IActionResult Delete(int id, Student stud)
        // {
        //     CustomerService.Delete(id);
        //     return RedirectToAction("Index");
        // }
    }
}