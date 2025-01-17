﻿namespace LankMarkAPI.Models
{
    public class FooterDetailsModel
    {
        public int ID { get; set; }
        public int DetailsID { get; set; }
        public string? Policies { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDay { get; set; }
        public TimeSpan CreatedTime { get; set; }
        public int? UpdatedBy { get; set; }
        public TimeSpan? UpdatedAt { get; set; }
    }
}
