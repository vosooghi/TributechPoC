namespace TributechPoC.Core.Contracts.DTOs
{
    public class SensorDTO
    {
        public string SensorName { get; set; }
        public string SensorLocation { get; set; }
        public string CreationTime { get; set; }
        public double UpperWarningLimit { get; set; }
        public double LowerWarningLimit { get; set; }
    }
}
