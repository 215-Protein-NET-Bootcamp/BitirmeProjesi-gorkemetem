using Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess
{
    public class UserRepository : IUserRepository
    {
        readonly AppDbContext db;
        public UserRepository(AppDbContext dbContext)
        {
            db = dbContext;
        }

        public List<OperationClaim> GetClaims(User user)
        {         
                var result = from operationClaim in db.OperationClaims
                             join userOperationClaim in db.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();
        }

        public void Add(User user)
        {
                var addedEntity = db.Entry(user);
                addedEntity.State = EntityState.Added;
                db.SaveChanges();     
        }

        public User Get(Expression<Func<User, bool>> filter)
        {        
                return db.Set<User>().SingleOrDefault(filter);   
        }
    }
}
