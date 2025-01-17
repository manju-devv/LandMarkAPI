namespace LankMarkAPI.Models
{
    public class FeatureToolsModel
    {
        public int ID { get; set; }
        public int FeatureToolId { get; set; }
        public string? ImagePath { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Link { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDay { get; set; }
        public TimeSpan CreatedTime { get; set; }
        public int UpdatedBy { get; set; }
        public TimeSpan UpdatedAt { get; set; }
    }
}
