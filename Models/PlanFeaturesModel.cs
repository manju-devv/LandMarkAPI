namespace LankMarkAPI.Models
{
    public class PlanFeaturesModel
    {
        public int ID { get; set; }
        public int PlanFeatureID { get; set; }
        public string? Description { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDay { get; set; }
        public TimeSpan CreatedTime { get; set; }
        public int? UpdatedBy { get; set; }
        public TimeSpan? UpdatedAt { get; set; }
    }
}
