namespace PressCompany.Advertisement.Model
{
    public class AdvertisementRequest
    {
        public string Category { get; set; }
        public CallbackData CallbackData { get; set; }
        public AdvRequirements Requirements { get; set; }
    }
}