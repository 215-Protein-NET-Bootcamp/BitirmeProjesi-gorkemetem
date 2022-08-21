using AutoMapper;
using Base;
using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        [ValidationAspect(typeof(OfferValidator))]
        public override async Task<BaseResponse<OfferDto>> InsertAsync(OfferDto insertOffer)
        {
            try
            {
                var entity = Mapper.Map<OfferDto, Offer>(insertOffer);

                await _offerRepository.InsertAsync(entity);
                await UnitOfWork.CompleteAsync();

                return new BaseResponse<OfferDto>(Mapper.Map<Offer, OfferDto>(entity));
            }
            catch (Exception ex)
            {
                throw new MessageResultException("Offer_Saving_Error", ex);
            }
        }

        [ValidationAspect(typeof(OfferValidator))]
        public override async Task<BaseResponse<OfferDto>> UpdateAsync(int id, OfferDto updateOffer)
        {
            try
            {
                var entity = await _offerRepository.GetByIdAsync(id);
                if (entity is null)
                    return new BaseResponse<OfferDto>("NoData");
                Mapper.Map(updateOffer, entity);

                await UnitOfWork.CompleteAsync();
                var resource = Mapper.Map<Offer, OfferDto>(entity);

                return new BaseResponse<OfferDto>(resource);
            }
            catch (Exception ex)
            {
                throw new MessageResultException("Offer_Updating_Error", ex);
            }
        }


    }
}
