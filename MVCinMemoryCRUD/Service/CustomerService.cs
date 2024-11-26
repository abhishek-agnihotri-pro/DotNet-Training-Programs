using System.Collections.Generic;
using System;
using MVCinMemoryCRUD.Models;
using System.Linq;

namespace MVCinMemoryCRUD.Service
{
    public static class CustomerService
    {
        public static List<Customer> customers = new List<Customer>(){
            new Customer(){CustomerId = 101, Name = "Bill", Address= "New York", DOB = new DateTime(2000,1,1),PAN_Number="Ebfdf234h"},
            new Customer(){CustomerId = 102, Name = "Chill", Address= "Goa", DOB = new DateTime(2000,12,23),PAN_Number="Ebfdf234h"},
            new Customer(){CustomerId = 103, Name = "Dill", Address= "Miami", DOB = new DateTime(2000,1,25),PAN_Number="Ebfdf234h"},
            new Customer(){CustomerId = 104, Name = "Gill", Address= "Paris", DOB = new DateTime(2000,7,15),PAN_Number="Ebfdf234h"},
            new Customer(){CustomerId = 105, Name = "Micheal", Address= "Tokiyo", DOB = new DateTime(2000,5,1),PAN_Number="Ebfdf234h"}
        };
        public static int nextCustomerId = 106;

        public static void Add(Customer customer)
        {
            customer.CustomerId = nextCustomerId++;
            customers.Add(customer);
        }
        public static List<Customer> GetAllCusomers(){
            return customers;
        } 
        public static Customer GetCustomerByID(int id){
            return customers.FirstOrDefault(c => c.CustomerId == id);
        }
        public static void Delete(int id){
            var c = customers.FirstOrDefault(c => c.CustomerId == id);
            if(c != null) customers.Remove(c);
        }
        public static void Update(Customer modifiedCusomer){
            var index = customers.FindIndex(c => c.CustomerId == modifiedCusomer.CustomerId);
            if(index != -1){
                customers[index] = modifiedCusomer;
            }

        }

    }
}