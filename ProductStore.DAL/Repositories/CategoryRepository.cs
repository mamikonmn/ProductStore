using ProductStore.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace ProductStore.DAL.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(ProductStoreDBContext context) : base(context)
        {
        }

        public ProductStoreDBContext CategoryStoreContext
        {
            get { return Context as ProductStoreDBContext; }
        }
    }
}
