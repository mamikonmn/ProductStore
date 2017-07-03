using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.DAL.IRepositories
{
    public interface IOrderItemRepository : IRepository<OrderItem>
    {

        void Add(OrderItem entity);
        void AddRange(IEnumerable<OrderItem> entities);
        void Remove(OrderItem entity);
        void RemoveRange(IEnumerable<OrderItem> entities);
    }
}
