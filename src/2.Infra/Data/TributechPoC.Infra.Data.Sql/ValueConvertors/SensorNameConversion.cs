using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TributechPoC.Domain.ValueObjects;

namespace TributechPoC.Infra.Data.Sql.ValueConvertors
{
    public class SensorNameConversion : ValueConverter<SensorName, string>
    {
        public SensorNameConversion() : base(c => c.Value, c => new SensorName(c))
        {

        }
    }
}
