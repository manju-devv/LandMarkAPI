namespace LankMarkAPI.Models
{
    public class CopyWrightModel
    {
        public int ID { get; set; }
        public string? DistributedBy { get; set; }
        public string? Rights { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDay { get; set; }
        public TimeSpan CreatedTime { get; set; }
        public int? UpdatedBy { get; set; }
        public TimeSpan? UpdatedAt { get; set; }
    }
}