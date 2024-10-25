using TributechPoC.Domain.Exceptions;
using TributechPoC.Domain.Shared;
using TributechPoC.Utilities;

namespace TributechPoC.Domain.ValueObjects
{
    public class SensorLocation : BaseValueObject<SensorName>
    {
        public string Value { get; private set; }
        public SensorLocation(string value)
        {
            if (string.IsNullOrEmpty(value)) throw new InvalidValueObjectStateException(Messages.InvalidNullValue, Messages.SensorLocation);
            value = value.Trim();
            if (!value.IsLengthBetween(2, 100)) throw new InvalidValueObjectStateException(Messages.InvalidStringLength, Messages.SensorLocation, "2", "100");
            Value = value;
        }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
