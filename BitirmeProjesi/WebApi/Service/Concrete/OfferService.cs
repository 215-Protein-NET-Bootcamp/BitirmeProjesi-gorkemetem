using AutoMapper;
using Base;
using DataAccess;
using Entities;
using System.Collections.Generic;

namespace Service
{
    public class OfferService : BaseService<OfferDto, Offer>, IOfferService
    {
        IOfferRepository _offerRepository;
        public OfferService(IOfferRepository offerRepository, IMapper mapper, IUnitOfWork unitOfWork) : base(offerRepository, mapper, unitOfWork)
        {
            _offerRepository = offerRepository;
        }

        public IDataResult<List<Offer>> GetOfferByProductId(int id)
        {
            return new SuccessDataResult<List<Offer>>(_offerRepository.GetOfferByProductId(o => o.ProductId == id));
        }

        
    }
}
