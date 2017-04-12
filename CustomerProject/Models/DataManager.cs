using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerProject.Models
{
    public static class DataManager
    {
        private static List<Customer> customers = new List<Customer>
        {
            new Customer {Id = 1, EmployeeCount = 20, CompanyName = "Academy", Address = "Borgarfjordsgatan 4"},
            new Customer {Id = 2, EmployeeCount = 645, CompanyName = "Academic Work", Address = "Södra Kontoret 12"},
            new Customer {Id = 3, EmployeeCount = 4, CompanyName = "Kontorsprylar AB", Address = "Häftapparatsgatan 7, Gemträsk"},
            new Customer {Id = 4, EmployeeCount = 3001, CompanyName = "SEB", Address = "Kungsträdgårdsgatan 8"},
        };

        public static Customer[] GetAllCustomers()
        {
            return customers.ToArray();
        }

        public static void AddCustomer(Customer customer)
        {
            if (customers.Count() > 0)
                customer.Id = (customers.Max(c => c.Id) + 1);
            else
                customer.Id = 1;

            customers.Add(customer);

        }

        internal static Customer GetCustomer(int id)
        {
            return customers.FirstOrDefault(c => c.Id == id);
        }

        internal static void DeleteCustomer(int id)
        {
            Customer customer = customers?.FirstOrDefault(c => c.Id == id);
            customers.Remove(customer);
        }

        internal static void UpdateCustomer(Customer customer)
        {
            int idx = customers.IndexOf(customers.FirstOrDefault(c => c.Id == customer.Id));
            customers[idx] = customer;
        }
    }
}
