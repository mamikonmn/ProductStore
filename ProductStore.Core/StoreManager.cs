using ProductStore.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductStore.Core.Models;
using System.Runtime.Remoting.Contexts;

namespace ProductStore.Core
{
    public class StoreManager : IStoreManager, IDisposable
    {
        IUnitOfWork _UnitOfWork;
        public StoreManager()
        {
            _UnitOfWork = new UnitOfWork(new ProductStoreDBContext());
        }

        #region Product
        public IEnumerable<ProductModel> GetAllProducts()
        {
            if (_UnitOfWork == null)
            {
                _UnitOfWork = new UnitOfWork(new ProductStoreDBContext());
            }
            IEnumerable<Product> products = _UnitOfWork.Products.GetAll();
            if (products != null)
            {
                return products.Select(i => new ProductModel
                {
                    Id = i.id,
                    Name = i.name,
                    price = i.price,
                    CategoryName = i.Category.name
                });
            }
            return null;
        }
        public ProductModel GetProduct(int id)
        {
            Product product = _UnitOfWork.Products.Get(id);
            if (product != null)
            {
                return new ProductModel
                {
                    Id = product.id,
                    Name = product.name,
                    price = product.price,
                    Url = product.url,
                    CategoryName = product.Category.name
                };
            }
            return null;
        }
        #endregion

        #region Order
        public bool AddOrder(OrderModel model)
        {
            bool orderCreated = false;
            //model validation
            if (true)
            {

                IEnumerable<Order> oredritems = model.OrderItemModels.Select(i=>new Order{
                //init db orderitems
                });
                Order order = new Order
                {
                    address = model.Address,
                    city = model.City,
                    country = model.Country,
                    email = model.Email,
                    firstname = model.FirstName,
                    lastname = model.LastName,
                    orderdate = model.OrderDate,
                    phone = model.Phone,
                    postal_code = model.PostalCode,
                    state = model.State,
                    total = model.Total,
                    username = model.UserName,
                    user_id = model.UserId,
                    OrderItems = oredritems as ICollection<OrderItem>
                };
                _UnitOfWork.Orders.Add(order);

                _UnitOfWork.Complete();
                orderCreated = true;
            }
            return orderCreated;
        }

        #endregion

        #region OrderItem

        #endregion

        #region IDisposable Support
        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _UnitOfWork.Dispose();
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion

    }
}
