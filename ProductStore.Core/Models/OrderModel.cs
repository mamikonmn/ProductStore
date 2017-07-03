using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Core.Models
{
    /// <summary>
    /// Map Order db entity
    /// </summary>
    public class OrderModel
    {
        public int Id { get; set; }
        public Nullable<int> UserId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public System.DateTime OrderDate { get; set; }
        public string Phone { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public decimal Total { get; set; }
        public string UserName { get; set; }
        public IEnumerable<OrderItemModel> OrderItemModels { get; set; }
        //public string Status { get; set; }
    }
}
