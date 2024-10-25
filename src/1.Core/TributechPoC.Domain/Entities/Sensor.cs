using TributechPoC.Domain.ValueObjects;

namespace TributechPoC.Domain.Entities
{
    public class Sensor
    {
        #region Properties
        public long ID { get; protected set; }
        public BusinessId BusinessId { get;  set; } = BusinessId.FromGuid(Guid.NewGuid());
        public SensorName SensorName { get;  set; }
        public SensorLocation SensorLocation { get;  set; }
        public DateTimeOffset CreationTime { get; set; }
        public double UpperWarningLimit { get; set; }
        public double LowerWarningLimit { get; set; }
        #endregion

        #region Ctors
        public Sensor(SensorName sensorName, SensorLocation sensorLocation, double upperWarningLimit, double lowerWarningLimit)
        {            
            SensorName = sensorName;
            SensorLocation = sensorLocation;
            UpperWarningLimit = upperWarningLimit;
            LowerWarningLimit = lowerWarningLimit;
        }
        public Sensor() { }
        #endregion

    }
}
