namespace TributechPoC.Endpoints.WebUI.DTOs
{
    public class SensorDTO
    {
        public string ID { get; set; }
        public string BusinessId { get; set; }
        public string SensorName { get; set; }
        public string SensorLocation { get; set; }
        public string CreationTime { get; set; }
        public double UpperWarningLimit { get; set; }
        public double LowerWarningLimit { get; set; }
    }
}
