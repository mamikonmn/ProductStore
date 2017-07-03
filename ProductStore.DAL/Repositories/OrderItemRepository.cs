using ProductStore.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.DAL.Repositories
{
    public class OrderItemRepository : Repository<OrderItem>, IOrderItemRepository
    {
        public OrderItemRepository(ProductStoreDBContext context) : base(context)
        {
        }

        public void Add(OrderItem entity)
        {
            ProductStoreContext.Set<OrderItem>().Add(entity);
        }

        public void AddRange(IEnumerable<OrderItem> entities)
        {
            ProductStoreContext.Set<OrderItem>().AddRange(entities);
        }

        public void Remove(OrderItem entity)
        {
            ProductStoreContext.Set<OrderItem>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<OrderItem> entities)
        {
            ProductStoreContext.Set<OrderItem>().RemoveRange(entities);
        }

        public ProductStoreDBContext ProductStoreContext
        {
            get { return Context as ProductStoreDBContext; }
        }

    }
}
