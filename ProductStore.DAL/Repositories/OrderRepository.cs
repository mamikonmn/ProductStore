using ProductStore.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.DAL.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {

        public OrderRepository(ProductStoreDBContext context)
            : base(context)
        {
        }

        public void Add(Order entity)
        {
            ProductStoreContext.Set<Order>().Add(entity);
        }

        //public void AddRange(IEnumerable<TEntity> entities)
        //{
        //    Context.Set<TEntity>().AddRange(entities);
        //}

        public void Remove(Order entity)
        {
            ProductStoreContext.Set<Order>().Remove(entity);
        }

        public Order GetUnfinishedOrder(string username)
        {
            //return ProductStoreContext.Orders.Where(i=>i.username == username);
            return null;
        }

        //public void RemoveRange(IEnumerable<Order> entities)
        //{
        //    ProductStoreContext.Set<Order>().RemoveRange(entities);
        //}
        //public IEnumerable<Order> GetTopSellingCourses(int count)
        //{
        //    return ProductStoreContext.Orders.OrderByDescending(c => c.orderdate).Take(count).ToList();
        //}

        //public IEnumerable<Order> GetCoursesWithAuthors(int pageIndex, int pageSize = 10)
        //{
        //    return ProductStoreContext.Orders;
        //}

        public ProductStoreDBContext ProductStoreContext
        {
            get { return Context as ProductStoreDBContext; }
        }
    }
}
