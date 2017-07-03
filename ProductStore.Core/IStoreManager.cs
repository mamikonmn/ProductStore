using ProductStore.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Core
{
    public interface IStoreManager
    {
        ProductModel GetProduct(int id);
        IEnumerable<ProductModel> GetAllProducts();
    }
}
