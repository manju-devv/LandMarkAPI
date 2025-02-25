namespace LankMarkAPI.Models
{
    public class PricePlanModel
    {
        public int ID { get; set; }
        public int PriceId { get; set; }
        public string? Cost { get; set; }
        public string? PlanDetails { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDay { get; set; }
        public TimeSpan CreatedTime { get; set; }
        public int? UpdatedBy { get; set; }
        public TimeSpan? UpdatedAt { get; set; }
    }
}
