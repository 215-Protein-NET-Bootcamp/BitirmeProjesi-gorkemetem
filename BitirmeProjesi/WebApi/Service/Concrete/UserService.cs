using Base;
using DataAccess;
using System.Collections.Generic;

namespace Service
{
    public class UserService : IUserService
    {
        IUserDal _userDal;

        public UserService(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        public void Add(User user)
        {
            _userDal.InsertAsync(user);
        }

        public User GetByMail(string mail)
        {
            throw new System.NotImplementedException();
        }

        //public User GetByMail(string email)
        //{
        //    //return _userDal.Get(u => u.Email == email);
        //}


    }
}
