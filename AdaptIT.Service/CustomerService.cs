using System;
using System.Collections.Generic;
using System.Linq;
using AdaptIT.DTO;
using AdaptIT.EntityFrameWork;
using System.Text;
using System.Threading.Tasks;

namespace AdaptIT.Service
{
    public class CustomerService : ICustomerService
    {
       
        private readonly static AdaptITEntities context = new AdaptITEntities();

        public CustomerService() { }

        public CustomerDTO GetAllCustomers()
        {
            CustomerDTO customerDTO = new CustomerDTO();
            var data = context.Customer.FirstOrDefault();
            if (data != null)
            {
                customerDTO.Id = data.Id;
                customerDTO.Firstname = data.Firstname;
                customerDTO.Surname = data.Surname;
                customerDTO.Email = data.Email;
                customerDTO.Cellphone = data.Cellphone;
                customerDTO.DataLookUpId = data.DataLookUpId;
                customerDTO.TotalAmount = data.TotalAmount;
                customerDTO.DateLogged = data.DateLogged;
            }
            return customerDTO;
        }

        public CustomerDTO CreateCustomer(CustomerDTO customerDTO)
        {
            string emailAddresss = string.Empty;
            if (customerDTO.Id == 0)
            {
                context.Customer.Add(new Customer
                {
                    Firstname = customerDTO.Firstname,
                    Surname = customerDTO.Surname,
                    Email = customerDTO.Email,
                    Cellphone = customerDTO.Cellphone,
                    DataLookUpId = customerDTO.DataLookUpId,
                    TotalAmount = customerDTO.TotalAmount,
                    DateLogged = DateTime.Now
                });
                context.SaveChanges();
            }
            return customerDTO;
        }
    }
}
