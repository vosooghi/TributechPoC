using Ground.Samples.Core.Domain.People.ValueObjects;
using TributechPoC.Domain.ValueObjects;

namespace TributechPoC.Domain.Entities
{
    public class Sensor
    {
        #region Properties
        public Guid ID { get; private set; }
        public BusinessId BusinessId { get; private set; } = BusinessId.FromGuid(Guid.NewGuid());
        public SensorName SensorName { get; private set; }
        public SensorLocation SensorLocation { get; private set; }
        public DateTimeOffset CreationTime { get; private set; }
        public double UpperWarningLimit { get; private set; }
        public double LowerWarningLimit { get;private set; }
        #endregion

        #region Ctors
        public Sensor(Guid id, BusinessId businessId,SensorName sensorName, SensorLocation sensorLocation
            , double upperWarningLimit, double lowerWarningLimit)
        {
            ID = id;
            BusinessId = businessId;
            SensorName = sensorName;
            SensorLocation = sensorLocation;
            UpperWarningLimit = upperWarningLimit;
            LowerWarningLimit = lowerWarningLimit;
        }
        #endregion

    }
}
