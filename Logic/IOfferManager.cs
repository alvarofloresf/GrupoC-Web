using System.Collections.Generic;

namespace Logic
{
    public interface IOfferManager
    {
        public List<Offer> GetOffers();
        public Offer PostOffer(Offer offer);
        public Offer PutOffer(Offer offer);
        public Offer DeleteOffer(int offerId);
    }
}