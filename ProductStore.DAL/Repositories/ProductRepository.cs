using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.DAL.IRepositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(ProductStoreDBContext context) : base(context)
        {
        }

        public Product GeSpecificProduct(int id)
        {
            return ProductStoreContext.Products.Include(a => a.Category).SingleOrDefault(a => a.id == id);
        }

        public ProductStoreDBContext ProductStoreContext
        {
            get { return Context as ProductStoreDBContext; }
        }
    }
}
