using ProductStore.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductStore.MVC.Client.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult GetProduct(int id)
        {
            //make request to web api
            ProductModel model = new ProductModel();
            return View(model: model);
        }

        public ActionResult GetAllProducts()
        {
            //make request to web api
            IEnumerable<ProductModel> products = new List<ProductModel>();
            return View(model:products);
        }
    }
}