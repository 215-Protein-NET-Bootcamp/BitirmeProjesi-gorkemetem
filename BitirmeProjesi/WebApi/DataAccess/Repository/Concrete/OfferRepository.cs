using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess
{
    public class OfferRepository : BaseRepository<Offer>, IOfferRepository
    {
        public OfferRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public List<Offer> GetOfferById(Expression<Func<Offer, bool>> filter = null)
        {
            return filter == null ?
                 Context.Set<Offer>().ToList() :
                 Context.Set<Offer>().Where(filter).ToList();
        }
    }
}
