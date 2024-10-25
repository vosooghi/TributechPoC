using TributechPoC.Domain.ValueObjects;

namespace TributechPoC.Core.ApplicationServices.Queries
{
    public class SensorListResult
    {
        #region Properties
        public long ID { get; protected set; }
        public Guid BusinessId { get; set; } 
        public string SensorName { get; set; }
        public string SensorLocation { get; set; }
        public DateTimeOffset CreationTime { get; set; }
        public double UpperWarningLimit { get; set; }
        public double LowerWarningLimit { get; set; }
        #endregion
    }
}
