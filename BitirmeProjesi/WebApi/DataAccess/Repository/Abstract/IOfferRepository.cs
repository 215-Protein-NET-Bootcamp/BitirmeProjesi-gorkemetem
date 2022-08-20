using Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess
{
    public interface IOfferRepository : IBaseRepository<Offer>
    {
        List<Offer> GetOfferByProductId(Expression<Func<Offer, bool>> filter = null);
    }
}
