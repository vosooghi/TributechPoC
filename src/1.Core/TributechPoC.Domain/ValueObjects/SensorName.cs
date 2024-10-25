using TributechPoC.Domain.Exceptions;
using TributechPoC.Domain.Shared;
using TributechPoC.Domain.ValueObjects;
using TributechPoC.Utilities;

namespace Ground.Samples.Core.Domain.People.ValueObjects
{
    public class SensorName : BaseValueObject<SensorName>
    {
        public string Value { get;private set; }
        public SensorName(string value)
        {
            if (string.IsNullOrEmpty(value)) throw new InvalidValueObjectStateException(Messages.InvalidNullValue, Messages.SensorName);
            value = value.Trim();            
            if (!value.IsLengthBetween(2,100)) throw new InvalidValueObjectStateException(Messages.InvalidStringLength,Messages.SensorName, "2", "100");
            Value = value;
        }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
