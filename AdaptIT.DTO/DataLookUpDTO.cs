using System;

namespace AdaptIT.DTO
{
    public class DataLookUpDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> DataSchemeId { get; set; }
        public System.DateTime DateLogged { get; set; }
       
        //public virtual ICollection<Customer> Customer { get; set; }
        //public virtual DataScheme DataScheme { get; set; }
    }
}
