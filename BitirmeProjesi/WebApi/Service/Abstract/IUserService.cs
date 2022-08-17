using Base;
using System.Collections.Generic;

namespace Service
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        User GetByMail(string mail);

    }
}
