﻿namespace TributechPoC.Endpoints.WebUI.DTOs
{ 
    public class SensorValueItemDTO
    {
        public string SensorId { get; set; }
        public string Timestamp { get; set; }
        public string StoredAt { get; set; }
        public string Value { get; set; }
    }
}
