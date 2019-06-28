
using System.Collections.Generic;

namespace ProductStore.DAL.IRepositories
{
    public interface IOrderRepository : IBaseRepository<Order>
    {
        //IEnumerable<Order> GetFailedOrder(int count);
        Order GetUnfinishedOrder(string username);
        void Remove(Order entity);
        void Add(Order entity);

    }
}