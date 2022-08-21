using AutoMapper;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using Service;
using System.Threading.Tasks;

namespace WebApi
{
    [Route("api/final/protein/[controller]")]
    [ApiController]
    public class OfferController : BaseController<OfferDto, Offer>
    {
        IProductService _productService;
        IOfferService _offerService;
        public OfferController(IOfferService offerService, IProductService productService, IMapper mapper) : base(offerService, mapper)
        {
            _productService = productService;
            _offerService = offerService;
        }

        [Route("Offer")]
        [HttpPost]
        public new async Task<IActionResult> CreateOfferAsync([FromQuery] int userId, [FromQuery] int productId, [FromQuery] int offerAmount)
        {
            Log.Information($"{User.Identity?.Name}: create a Employee.");

            var productResult = await _productService.GetByIdAsync(productId);
            if(productResult.Response.IsOfferable == 0)
            {
                return BadRequest("The product cannot be offered");
            }

            OfferDto offer = new OfferDto { ProductId= productId, UserId= userId, OfferAmount= offerAmount };
            var result = await _offerService.InsertAsync(offer);

            return Ok(result);
        }

        [Route("PercentageOffer")]
        [HttpPost]
        public new async Task<IActionResult> CreateOfferWithPercentageAsync([FromQuery] int userId, [FromQuery] int productId, [FromQuery] int percentageAmount)
        {
            Log.Information($"{User.Identity?.Name}: create a Employee.");

            var productResult = await _productService.GetByIdAsync(productId);
            if (productResult.Response.IsOfferable == 0)
            {
                return BadRequest("The product cannot be offered");
            }

            var offerAmount = (productResult.Response.Price * percentageAmount) / 100;

            OfferDto offer = new OfferDto { ProductId = productId, UserId = userId, OfferAmount = offerAmount };
            var result = await _offerService.InsertAsync(offer);

            return Ok(result);
        }

        [HttpDelete]
        public virtual async Task<IActionResult> DeleteOfferAsync([FromQuery] int productId)
        {
            var offerResult =  _offerService.GetOfferByProductId(productId);
            var result = await _offerService.RemoveAsync(offerResult.Data[0].Id);

            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }
    }

}
