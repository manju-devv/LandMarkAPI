﻿namespace LankMarkAPI.Models
{
    public class HomePageModel
    {
        public int ID { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Button { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDay { get; set; }
        public TimeSpan CreatedTime { get; set; }
        public int UpdatedBy { get; set; }
        public TimeSpan UpdatedAt { get; set; }
        public string? image { get; set; }
    }
}
