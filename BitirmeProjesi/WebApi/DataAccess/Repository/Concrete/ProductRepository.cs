using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public override async Task<Product> GetByIdAsync(int id)
        {
            return await Context.Products.FindAsync(id);
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {          
                return filter == null ?
                     Context.Set<Product>().ToList() :
                     Context.Set<Product>().Where(filter).ToList();          
        }
    }
}
