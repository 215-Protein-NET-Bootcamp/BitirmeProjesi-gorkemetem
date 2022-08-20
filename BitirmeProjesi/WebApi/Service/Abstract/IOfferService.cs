using Base;
using Entities;
using System.Collections.Generic;

namespace Service
{
    public interface IOfferService : IBaseService<OfferDto, Offer>
    {
        IDataResult<List<Offer>> GetOfferByProductId(int id);
    }
}
