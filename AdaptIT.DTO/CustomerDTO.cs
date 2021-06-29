using System;

namespace AdaptIT.DTO
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Cellphone { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public Nullable<int> DataLookUpId { get; set; }
        public System.DateTime DateLogged { get; set; }
    }
}
