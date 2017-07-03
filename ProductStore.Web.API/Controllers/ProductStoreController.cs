using ProductStore.Core;
using ProductStore.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductStore.Web.API.Controllers
{
    public class ProductStoreController : ApiController
    {
        IStoreManager _manager;
        public ProductStoreController(StoreManager manager)
        {
            this._manager = manager;
        }

        ProductModel Getproduct(int id)
        {
            return _manager.GetProduct(id);
        }

        IEnumerable<ProductModel> GetAllProducts() {

            return _manager.GetAllProducts();
        }

    }
}
