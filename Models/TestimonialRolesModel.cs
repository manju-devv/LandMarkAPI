namespace LankMarkAPI.Models
{
    public class TestimonialRolesModel
    {
        public int ID { get; set; }
        public int TestimonialId { get; set; }
        public string? Description { get; set; }
        public string Name { get; set; }
        public string? Role { get; set; }
        public string? UserImage { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDay { get; set; }
        public TimeSpan CreatedTime { get; set; }
        public int? UpdatedBy { get; set; }
        public TimeSpan? UpdatedAt { get; set; }
    }
}
