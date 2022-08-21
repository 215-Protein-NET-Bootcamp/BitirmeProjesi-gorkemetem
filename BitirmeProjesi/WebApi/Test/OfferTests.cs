using NUnit.Framework;
using WebApi;

namespace Test
{
    public class OfferTests
    {

        public int userId = 1;
        public static int productId = 1;
        public int offerAmount = 100;

        [Test]
        public static void Offer()
        {
            OfferController.DeleteOfferAsync(productId);
        }
    }
}