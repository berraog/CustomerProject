using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CustomerProject.Models;
using static CustomerProject.Models.DataManager;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerProject.Controllers
{
    public class CustomersController : Controller
    {
        // GET: /<controller>/
        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.Customers = GetAllCustomers();
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            AddCustomer(customer);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            DeleteCustomer(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            ViewBag.Customer = GetCustomer(id);
            return View();
        }

        [HttpPost]
        public IActionResult Update(Customer customer, int id)
        {
            UpdateCustomer(customer);
            return RedirectToAction(nameof(Index));
        }
    }
}
