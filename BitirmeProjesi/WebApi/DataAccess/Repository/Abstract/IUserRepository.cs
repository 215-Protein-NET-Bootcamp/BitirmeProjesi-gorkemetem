using Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess
{
    public interface IUserRepository
    {
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        User Get(Expression<Func<User, bool>> filter);
    }
}
