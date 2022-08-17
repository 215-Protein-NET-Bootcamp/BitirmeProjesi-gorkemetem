using Base;
using System.Collections.Generic;

namespace DataAccess
{
    public interface IUserDal : IBaseRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
