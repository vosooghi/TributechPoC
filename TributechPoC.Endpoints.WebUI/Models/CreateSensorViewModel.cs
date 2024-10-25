namespace TributechPoC.Endpoints.WebUI.Models
{
    public class CreateSensorViewModel
    {        
        public string SensorName { get; set; }
        public string SensorLocation { get; set; }
        public string CreationTime { get; set; }
        public double UpperWarningLimit { get; set; }
        public double LowerWarningLimit { get; set; }
    }
}
