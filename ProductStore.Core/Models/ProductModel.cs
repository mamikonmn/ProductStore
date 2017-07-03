using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Core.Models
{
    /// <summary>
    /// Map Product db  entity
    /// </summary>
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal price { get; set; }
        public string Url { get; set; }
       // public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        //  public string Currency { get; set; }
    }
}
