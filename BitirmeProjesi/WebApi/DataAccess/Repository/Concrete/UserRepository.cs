using Base;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class UserRepository : BaseRepository<User>, IUserDal
    {
        readonly AppDbContext db;
        public UserRepository(AppDbContext dbContext) : base(dbContext)
        {
            db = dbContext;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = db)
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }
    }
}
