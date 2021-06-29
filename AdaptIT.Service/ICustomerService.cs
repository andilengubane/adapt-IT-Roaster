using AdaptIT.DTO;

namespace AdaptIT.Service
{
    public interface ICustomerService
    {
        CustomerDTO GetAllCustomers();
        CustomerDTO CreateCustomer(CustomerDTO customerDTO);
    }
}