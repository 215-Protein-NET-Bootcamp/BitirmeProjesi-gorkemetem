using Entities;
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
    }
}
