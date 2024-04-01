using System;
using System.Collections.Generic;
using bookstore_management_app.Entity;
using bookstore_management_app.Model;

namespace bookstore_management_app.Controller
{
    public class CustomerController
    {
        private string username, address, phone;
        private CustomerModel _customerModel;
        public CustomerController()
        {
            this._customerModel = new CustomerModel();
        }

        public List<Customer> searchCustomers(Customer filterCustomer)
        {
            return this._customerModel.find(filterCustomer);
        }

        public List<Customer> allCustomers()
        {
            return this._customerModel.findAll();
        }

        public Customer createCustomer(Customer customer)
        {
           bool isValid = customer.requiredFields();
           if (isValid)
           {
            return this._customerModel.create(customer);
           }
           return new Customer(1, "", "", "");
        }

        public bool isExistCustomer(Customer customer)
        {
            return this._customerModel.exist(customer);
        }

        public Customer updateCustomer(Customer customer)
        {
            bool isValid = customer.requiredFields();
            if (isValid)
            {
                return this._customerModel.update(customer);
            }
            return new Customer(1, "", "", "");
        }

        public Customer deleteCustomer(Customer customer)
        {
            return this._customerModel.delete(customer);
        }
    }
}