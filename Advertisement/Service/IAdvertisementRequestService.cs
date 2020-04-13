using PressCompany.Advertisement.Model;

namespace PressCompany.Advertisement.Service
{
    public interface IAdvertisementRequestService
    {
        
        public Opportunity Request(AdvertisementRequest request);
        
    }
}