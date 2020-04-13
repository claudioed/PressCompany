namespace PressCompany.Advertisement.Model
{
    public class Opportunity
    {
        public string Id { get; set; }
        public string CustomerKey { get; set; }
        public AdvRequirements AdvReq { get; set; }
    }
}