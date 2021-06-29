using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using AdaptIT.DTO;
using System.Web.Http;
using AdaptIT.Service;

namespace AdaptIT.Web.Controllers
{
    public class CustomerController : ApiController
    {
        private readonly ICustomerService _customerService;

        public CustomerController()
        {
            _customerService = new CustomerService();
        }

        [HttpGet]
        public IHttpActionResult GetAllCustomers()
        {
            var results = _customerService.GetAllCustomers();

            if (results != null)
            {
                return Ok(results);
            }
            return BadRequest("Something went wrong");
        }

        [HttpPost]
        public IHttpActionResult CreateCustomer([FromBody] CustomerDTO customerDTO)
        {
            var results = _customerService.CreateCustomer(customerDTO);
            if (results != null)
            {
                return Ok(results);
            }
            return BadRequest("Something went wrong");
        }
    }
}
