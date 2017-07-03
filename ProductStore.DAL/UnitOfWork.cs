
using ProductStore.DAL.IRepositories;
using ProductStore.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProductStoreDBContext _context;

        public UnitOfWork(ProductStoreDBContext context)
        {
            _context = context;
            Orders = new OrderRepository(_context);
            OrderItems = new OrderItemRepository(_context);
            Products = new ProductRepository(_context);
            Categories = new CategoryRepository(_context);
        }

        public IOrderRepository Orders { get; private set; }
        public IOrderItemRepository OrderItems { get; private set; }
        public IProductRepository Products { get; private set; }
        public ICategoryRepository Categories { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
