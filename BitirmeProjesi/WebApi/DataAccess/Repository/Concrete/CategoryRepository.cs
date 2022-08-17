using Entities;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public override async Task<Category> GetByIdAsync(int id)
        {
            return await Context.Categories.FindAsync(id);
        }
    }
}
