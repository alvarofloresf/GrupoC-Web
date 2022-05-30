using System;
using System.Collections.Generic;

namespace Logic
{
    public class OfferManager : IOfferManager
    {
        public List<Offer> Offers { get; set; }
        public OfferManager()
        {
            Offers = new List<Offer>()
            {
                new Offer() { Id = 1, Name = "Juan"},
                new Offer() { Id = 2,Name = "Cho"},
            };
        }
        public List<Offer> GetOffers()
        {
            return Offers;

        }

        public Offer PostOffer(Offer offer)
        {
            Offers.Add(offer);
            return offer;
        }

        public Offer PutOffer(Offer offer)
        {
            Offer offerUpdate = Offers.Find(u => u.Id == offer.Id);
            if (offerUpdate == null)
            {
                return null;
            }
            else
            {
                offerUpdate.Name = offer.Name;
                offerUpdate.Id = offer.Id;
                return offer;
            }
        }

        public Offer DeleteOffer(int offerId)
        {
            Offer offerFound = Offers.Find(u => u.Id == offerId);
            if (offerFound != null)
            {
                Offers.Remove(offerFound);
                return offerFound;
            }
            else
            {
                return null;
            }
        }
    }
}
