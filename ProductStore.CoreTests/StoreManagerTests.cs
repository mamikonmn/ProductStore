using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductStore.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Core.Tests
{
    [TestClass()]
    public class StoreManagerTests
    {

        [TestMethod()]
        public void StoreManagerTest()
        {
        }

        [TestMethod()]
        public void GetAllProductsTest()
        {
            StoreManager mg = new StoreManager();
            var products = mg.GetAllProducts();
            Assert.IsTrue(products.Count()>0);
            foreach (var item in products)
            {
                Assert.IsFalse(String.IsNullOrEmpty(item.Name));
            }
        }

        [TestMethod()]
        public void GetProductTest()
        {
            StoreManager mg = new StoreManager();
            var product = mg.GetProduct(2);
            Assert.IsNotNull(product);
            Assert.IsFalse(String.IsNullOrEmpty(product.Name));
        }
      
    }
}