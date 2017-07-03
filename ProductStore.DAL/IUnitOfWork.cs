using ProductStore.DAL.IRepositories;
using System;

namespace ProductStore.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        IOrderRepository Orders { get; }
        IOrderItemRepository OrderItems { get; }
        IProductRepository Products { get; }
        ICategoryRepository Categories { get; }
        int Complete();
    }
}